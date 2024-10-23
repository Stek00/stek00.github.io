using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Windows.Forms;
using System.Reflection.Emit;

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


            int time = int.Parse(nServers.Text);
            int hackers = int.Parse(nHackers.Text);
            float lambda = float.Parse(probability.Text);


            float lineWidth = graphBox.Width * 0.7f / (float)time;
            float lineHeight = graphBox.Height / (float)time;


            graph.SmoothingMode = SmoothingMode.AntiAlias;
            graph.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graph.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;



            List<int> scores = DrawGraph(graph, time, hackers, lambda, lineWidth, lineHeight);

            (double var, double mean) = Variance_Mean(scores);

            graph.DrawString("Mean = " + mean.ToString(), font, brush, 10f, 10f);
            graph.DrawString("Variance = " + var.ToString(), font, brush, 10f, 30f);

        }



        private List<int> DrawGraph(Graphics graph, int time, int hackers, float lambda, float linew, float lineh)
        {
            List<int> totalscores = new List<int>();

            Pen line = new Pen(Color.Black);
            PointF endGraph1 = new PointF(graphBox.Width * 0.7f, graphBox.Height);
            PointF endGraph2 = new PointF(graphBox.Width * 0.7f, 0.0f);

            graph.DrawLine(line, endGraph1, endGraph2);

            Random rnd = new Random();

            for (int i = 0; i < hackers; i++)
            {
                Pen p = new Pen(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));

                int score = 0;

                PointF position = new PointF(0.0f, graphBox.Height);

                for (int j = 0; j < time; j++)
                {
                    if (rnd.NextDouble() < lambda/j)
                    {
                        PointF end = new PointF(position.X, position.Y - lineh);
                        graph.DrawLine(p, position, end);
                        position = end;
                        score++;
                    }

                    PointF next = new PointF(position.X + linew, position.Y);

                    graph.DrawLine(p, position, next);

                    position = next;

                }
                totalscores.Add(score);
            }
            DrawHistogram(graph, hackers, time, totalscores, lineh);

            return totalscores;
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
                float yPosition =  graphBox.Height - height * grp.Key - half;
                RectangleF rect = new RectangleF(graphBox.Width * 0.7f, yPosition, scoreHeight * grp.Count(), height);
                graph.FillRectangle(blueBrush, rect);
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

            variance = Math.Round(variance, 2, MidpointRounding.AwayFromZero);
            mean = Math.Round(mean, 2, MidpointRounding.AwayFromZero);

            return (variance, mean);
        }

    }
}
