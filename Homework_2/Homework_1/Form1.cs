using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Windows.Forms;
using System.Reflection.Emit;
using static System.Formats.Asn1.AsnWriter;
using System.Collections.Generic;
using static System.Windows.Forms.LinkLabel;

namespace Homework_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            Graphics graph = graphBox.CreateGraphics();
            graph.Clear(Color.White);

            Graphics abs = absoluteGraph.CreateGraphics();
            abs.Clear(Color.White);

            Graphics rel = relativeGraph.CreateGraphics();
            rel.Clear(Color.White);

            gridLayout(abs);
            gridLayout(rel);


            int servers = int.Parse(nServers.Text);
            int hackers = int.Parse(nHackers.Text);
            float prob = float.Parse(probability.Text);
            float k = float.Parse(kText.Text);


            // Plus/Minus Graph data
            float lineWidth = graphBox.Width*0.7f / (float)servers;
            float lineHeight = graphBox.Height / (float)(servers * 2);



            graph.SmoothingMode = SmoothingMode.AntiAlias;
            graph.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graph.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;

            gridLayout(graph);

            (List<int> scores, List<int> partialscores) = DrawGraph(graph, rel, abs, servers, hackers, prob, lineWidth, lineHeight, k);

            (double variance, double mean) = Variance_Mean(scores);
            (double partialVar, double partialMean) = Variance_Mean(partialscores);
            DrawKSample(graph, hackers, k, partialscores, lineHeight, lineWidth);

            meanKtext.Text = partialMean.ToString();
            varKtext.Text = partialVar.ToString();

            meanEtext.Text = mean.ToString();
            varEtext.Text = variance.ToString();

        }

        private void gridLayout(Graphics graph)
        {
            float width = graphBox.Width * 0.7f;
            float height = graphBox.Height;

            var color = Color.FromArgb(70, Color.Black);

            Pen pen = new Pen(color);

            float stepX = width / 10f;
            float stepY = height / 20f;


            for (int i = 0; i < 10; i++)
            {
                graph.DrawLine(pen, stepX*i, 0f, i * stepX, graphBox.Height);
            }
            for (int i = 0; i < 20; i++)
            {
                graph.DrawLine(pen, 0f, stepY * i, graphBox.Width * 0.7f, i * stepY);
            }

        }

        private void drawRelative(Graphics graph, List<int> hackerScores, int servers, double prob, float linew)
        {
            float height = relativeGraph.Height;

            Random rnd = new Random();
            Pen p = new Pen(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));

            PointF position = new PointF(0f, height);
            float score = 0f;

            for (int j = 0; j < servers; j++)
            {
                // Calculate the relative score by dividing the hacker score by (j + 1)
                score = hackerScores[j] / (float)(j + 1);

                PointF end = new PointF(position.X, height * (1 - score));

                graph.DrawLine(p, position, end);

                // Update the position to the end of the vertical line
                position = end;

                PointF next = new PointF(position.X + linew, position.Y);

                graph.DrawLine(p, position, next);

                // Update the position for the next iteration
                position = next;
            }
        }




        private (List<int>, List<int>) DrawGraph(Graphics graph,Graphics relative, Graphics absolute, int servers, int hackers, float prob, float linew, float lineh, float k)
        {
            List<int> totalscores = new List<int>();
            List<int> partialscores = new List<int>();
            List<int> hackerScores = new List<int>();

            Pen line = new Pen(Color.Black);

            float absH = absoluteGraph.Height / (float)servers;
            float absW = absoluteGraph.Width / (float)servers;

            PointF endGraph1 = new PointF(graphBox.Width * 0.7f, graphBox.Height);
            PointF endGraph2 = new PointF(graphBox.Width * 0.7f, 0.0f);

            graph.DrawLine(line, endGraph1, endGraph2);

            Random rnd = new Random();

            for (int i = 0; i < hackers; i++)
            {
                Pen p = new Pen(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));

                int score = 0;
                int hscore = 0;

                PointF position = new PointF(0.0f, graphBox.Height / 2);
                PointF absPosition = new PointF(0.0f, absoluteGraph.Height);

                for (int j = 0; j < servers; j++)
                {
                    if (rnd.NextDouble() <= prob)
                    {
                        PointF end = new PointF(position.X, position.Y - lineh); // go up
                        PointF absEnd = new PointF(absPosition.X, absPosition.Y - absH);

                        absolute.DrawLine(p, absPosition,absEnd);
                        graph.DrawLine(p, position, end);

                        absPosition = absEnd;
                        position = end;

                        score++;
                        hscore++;
                    }
                    else
                    {
                        PointF end = new PointF(position.X, position.Y + lineh); // go down
                        graph.DrawLine(p, position, end);
                        position = end;
                        score--;
                    }

                    if (j == k)
                        partialscores.Add(score);

                    PointF next = new PointF(position.X + linew, position.Y);
                    PointF absNext = new PointF(absPosition.X + absW, absPosition.Y);

                    graph.DrawLine(p, position, next);

                    absolute.DrawLine(p,absPosition,absNext);

                    position = next;
                    absPosition = absNext;

                    hackerScores.Add(hscore);

                }
                drawRelative(relative, hackerScores, servers, prob, linew);
                hackerScores.Clear();
                totalscores.Add(score);
            }

            DrawHistogram(graph, hackers, servers, totalscores, lineh);

            return (totalscores, partialscores);
        }



        private void DrawHistogram(Graphics graph, int hackers, int servers, List<int> scores, float height)
        {
            var groupedScores = scores.GroupBy(i => i).OrderBy(group => group.Key);
            float half = height / 2.0f;
            int maxCount = groupedScores.Max(g => g.Count());

            float scoreHeight = (graphBox.Width * 0.25f) / maxCount;
            foreach (var grp in groupedScores)
            {
                SolidBrush blueBrush = new SolidBrush(Color.LightBlue);
                float yPosition = graphBox.Height / 2.0f - height * grp.Key - half;
                RectangleF rect = new RectangleF(graphBox.Width * 0.7f, yPosition, scoreHeight * grp.Count(), height * 2f);
                graph.FillRectangle(blueBrush, rect);
            }
        }

        private void DrawKSample(Graphics graph, int hackers, float servers, List<int> partialScores, float height, float width)
        {

            var semiBlack = Color.FromArgb(128, Color.Black);

            Pen pen = new Pen(Color.Red);

            var g = partialScores.GroupBy(i => i).OrderBy(group => group.Key);
            float half = height / 2;
            int n = partialScores.Distinct().Count();

            var m1 = partialScores.GroupBy(i => i).OrderByDescending(group => group.Count()).First().Count();

            graph.DrawLine(pen, servers * width, 0f, servers * width, graphBox.Height);
            float scoreHeigth = (graphBox.Width*0.7f - servers * width) * 0.6f / (float)m1;
            foreach (var grp in g)
            {
                SolidBrush blackBrush = new SolidBrush(semiBlack);

                float yPosition = graphBox.Height / 2 - height * grp.Key - half;
                RectangleF rect = new RectangleF(servers * width, yPosition, scoreHeigth * grp.Count(), height*2f);
                graph.FillRectangle(blackBrush, rect);

            }
        }

        private (double, double) Variance_Mean(List<int> scores)
        {
            double mean = 0;
            double oldM;
            double variance = 0;
            int i = 1;

            foreach (double score in scores)
            {
                oldM = mean;
                mean += (score - mean) / i;
                variance += (score - mean) * (score - oldM);
                i++;
            }

            variance = variance / (scores.Count - 1);

            variance=Math.Round(variance, 2, MidpointRounding.AwayFromZero);
            mean = Math.Round(mean, 2, MidpointRounding.AwayFromZero);

            return (variance, mean);
        }


    }
}
