using Homework_1;
using System;
using System.Windows.Forms;

namespace Homework_1
{
    public partial class Form1 : Form
    {
        private Bernoulli bernoulli;
        private RelativeFreq relativeFreq;
        private ScalingLimit scalingLimit;
        private RandomWalk randomWalk;
        private ContinuousTime continuousTime;
        private Histogram histogram;
        private int k, server;
        private int graphType = 1; // 1 = Ber, 2 = RW, 3 = RelFreq, 5 = CT, 6 = SL

        public Form1()
        {
            InitializeComponent();
            // Subscribe to PictureBox Paint event only
            graphBox.Paint += Form1_Paint;
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            int hacker, server, k;
            float prob;

            if (!int.TryParse(nServers.Text, out server) ||
                !int.TryParse(nHackers.Text, out hacker) ||
                !int.TryParse(kText.Text, out k) ||
                !float.TryParse(probability.Text, out prob))
            {
                MessageBox.Show("Please enter valid numeric values.");
                return;
            }

            this.server = server;
            this.k = k;

            try
            {
                // Initialize histogram with PictureBox dimensions instead of Form dimensions
                this.histogram = new Histogram(hacker, server, graphBox.Height, graphBox.Width);
                this.bernoulli = new Bernoulli(histogram, server, hacker, k, prob);
                this.continuousTime = new ContinuousTime(histogram, server, hacker, k, prob);
                this.relativeFreq = new RelativeFreq(histogram, server, hacker, k, prob);
                this.randomWalk = new RandomWalk(histogram, server, hacker, k, prob);
                this.scalingLimit = new ScalingLimit(histogram, server, hacker, k, prob);

                if (radioButton1.Checked)
                    this.graphType = 1;
                else if (radioButton2.Checked)
                    this.graphType = 2;
                else if (radioButton3.Checked)
                    this.graphType = 3;
                else if (radioButton5.Checked)
                    this.graphType = 5;
                else if (radioButton6.Checked)
                    this.graphType = 6;

                // Invalidate the PictureBox instead of the Form
                graphBox.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing simulation: {ex.Message}");
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (histogram == null) return;

            int[] scores = new int[1];
            int[] scores_t = new int[1];
            float[] fscores = new float[1];
            float[] fscores_t = new float[1];

            this.histogram.Create_Graphics(sender, e);

            switch (graphType)
            {
                case 1:
                    this.bernoulli.Paint_Graph(sender, e);
                    scores = bernoulli.scores;
                    scores_t = bernoulli.scores_t;
                    break;
                case 2:
                    this.randomWalk.Paint_Graph(sender, e);
                    scores = randomWalk.scores;
                    scores_t = randomWalk.scores_t;
                    break;
                case 3:
                    this.relativeFreq.Paint_Graph(sender, e);
                    fscores = relativeFreq.scores;
                    fscores_t = relativeFreq.scores_t;
                    break;
                case 5:
                    this.continuousTime.Paint_Graph(sender, e);
                    scores = continuousTime.scores;
                    scores_t = continuousTime.scores_t;
                    break;
                case 6:
                    this.scalingLimit.Paint_Graph(sender, e);
                    scores = scalingLimit.scores;
                    scores_t = scalingLimit.scores_t;
                    break;
            }

            this.histogram.Paint_Histogram(sender, e, scores, this.server + 1, graphType);
            this.histogram.Paint_Histogram(sender, e, scores_t, this.k, graphType);

            (double mean, double var) = this.histogram.Variance_Mean(scores);
            (double meanT, double varT) = this.histogram.Variance_Mean(scores_t);

            meanEndText.Text = mean.ToString();
            varEndText.Text = var.ToString();

            meanText.Text = meanT.ToString();
            varText.Text = varT.ToString();


        }

        protected void Radio_CheckChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked && (radioButton.Text == "Continuos Time" || radioButton.Text == "Scaling Limit"))
                {
                    label1.Text = "Attacks";
                    label2.Text = "Time";
                    label3.Text = "Lambda";
                }
                else
                {
                    label1.Text = "Number of Hackers";
                    label2.Text = "Number of servers";
                    label3.Text = "Probability";
                }
            }
        }
    }
}