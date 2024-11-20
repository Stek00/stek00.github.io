using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Homework_1
{
    internal class Histogram
    {
        private int server;
        private int hacker;
        private float linewidth;
        private float lineheight;
        public int height;
        public int width;
        public double var, mean, varK, meanK;
        bool grid;


        public Histogram(int hacker, int server, int Height, int Width, bool grid = true)
        {
            this.server = server;
            this.hacker = hacker;
            this.height = Height;
            this.width = Width;
            this.grid = grid;
        }

        public void Paint_Histogram(object sender, PaintEventArgs e, int[] scores, float time, int start)
        {
            if (this.hacker == 0 || this.server == 0)
            {
                return;
            }

            Graphics g = e.Graphics;

            float heightAdj = 1;
            float adj = 1;

            if (start == 2 || start == 6)
            {
                adj /= 2;
                heightAdj *= 2;
            }



            this.lineheight = this.height / (float)(this.server*heightAdj);
            this.linewidth = this.width * 0.7f/ (float)this.server;

            // Group and order the scores
            var groupedScores = scores.GroupBy(i => i).OrderBy(group => group.Key);

            // Calculate histogram bar dimensions
            int maxCount = groupedScores.Max(g => g.Count());
            float barWidth = (this.width * 0.25f) / maxCount;  // Width of one count
            float histogramStartX;         // Starting X position for histogram

            if (time < (float)this.server)
            {
                histogramStartX = time * this.linewidth;
            }
            else
            {
                histogramStartX = this.width * 0.7f;
            }

            foreach (var grp in groupedScores)
            {
                using (SolidBrush blueBrush = new SolidBrush(Color.LightBlue))
                {
                    // Calculate y position
                    // grp.Key represents the server number (0-based)
                    // Subtract 1 from server count to account for 0-based indexing

                    float yPosition = this.height*adj - ((grp.Key + 1) * this.lineheight);

                    // Create rectangle
                    RectangleF rect = new RectangleF(
                        histogramStartX,                    // X position
                        yPosition,                          // Y position
                        barWidth * grp.Count(),            // Width based on count
                        this.lineheight                    // Height matches line spacing
                    );

                    g.FillRectangle(blueBrush, rect);

                }
            }
        }

        public void Create_Graphics(object sender, PaintEventArgs e,bool grid = true)
        {
            Graphics g = e.Graphics;
            gridLayout(g, grid);
        }

        private void gridLayout(Graphics graph, bool grid)
        {
            float width = this.width * 0.7f;
            float height = this.height;

            if (grid == false)
                width = this.width;

            var color = Color.FromArgb(70, Color.Black);

            Pen pen = new Pen(color);

            float stepX = width / 10f;
            float stepY = height / 20f;
            PointF end1 = new PointF(width, this.height);
            PointF end2 = new PointF(width, 0.0f);
            graph.DrawLine(pen, end1, end2);



            for (int i = 0; i < 10; i++)
            {
                graph.DrawLine(pen, stepX * i, 0f, i * stepX, this.height);
            }
            for (int i = 0; i < 20; i++)
            {
                graph.DrawLine(pen, 0f, stepY * i, width , i * stepY);
            }

        }


        public (double,double) Variance_Mean(int[] scores)
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

            variance = variance / (scores.Length - 1);

            variance = Math.Round(variance, 2, MidpointRounding.AwayFromZero);
            mean = Math.Round(mean, 2, MidpointRounding.AwayFromZero);

            return (mean, variance);
        }
    }
}
