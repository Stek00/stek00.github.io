using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Bernoulli
    {
        private Random rnd = new Random();
        private Histogram histogram;
        private float prob;
        private int server;
        private int hacker;
        private int k;
        public int[] scores;
        public int[] scores_t; // scores at time T from input


        public Bernoulli(Histogram histogram, int server, int hacker, int k, float probability)
        {
            this.histogram = histogram;
            this.server = server;
            this.hacker = hacker;
            this.k = k;
            this.prob = probability;
            this.scores = new int[hacker];
            this.scores_t = new int[hacker];
        }

        public void Paint_Graph(object sender, PaintEventArgs e)
        {
            if (this.hacker == 0 || this.server == 0)
            {
                return;
            }

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            float linewidth = this.histogram.width * 0.7f / (float)this.server;
            float lineheight = this.histogram.height / (float)this.server;
            Pen p;

            PointF position, next, end;
            PointF end1 = new PointF(this.histogram.width *0.7f, this.histogram.height);
            PointF end2 = new PointF(this.histogram.width * 0.7f, 0.0f);
            int score;

            for (int i = 0; i < this.hacker; i++)
            {
                score = 0;
                position = new PointF(0.0f, this.histogram.height);
                p = new Pen(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));

                for (int j = 0; j < this.server; j++)
                {
                    if (Attack())
                    {
                        next = new PointF(position.X, position.Y - lineheight);
                        g.DrawLine(p, position, next);
                        position = next;
                        score++;
                    }
                    if (j == k)
                        scores_t[i] = score;
                    
                    end = new PointF(position.X + linewidth, position.Y);

                    g.DrawLine(p, position, end);

                    position = end;

                }
                scores[i] = score;
            }

        }

        private Boolean Attack()
        {
            float random = (float)rnd.NextDouble();
            return this.prob > random;
        }
    }
}
