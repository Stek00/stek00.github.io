using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Homework_1
{
    internal class UnivDist
    {
        private double[] probs;
        public int[] outcomes;
        private double[] cumulativeProb;
        private int sampleSize;  // number of samples to generate
        private int numBins;     // number of possible outcomes (previously sampleNumber)
        private Histogram histogram;
        private Random rnd = new Random();
        public Dictionary<int, double> probMap;


        public double theoreticalMean;
        public double theoreticalVariance;
        public double empiricalMean;
        public double empiricalVariance;


        // Changed constructor parameter name to be more clear
        public UnivDist(Histogram histogram, int sampleSize, int numBins = 10)
        {
            if (histogram == null) throw new ArgumentNullException(nameof(histogram));
            if (sampleSize <= 0) throw new ArgumentException("Sample size must be positive");
            if (numBins <= 0) throw new ArgumentException("Number of bins must be positive");

            this.sampleSize = sampleSize;
            this.numBins = numBins;
            this.histogram = histogram;
            generateProbs(this.numBins);  // Generate probabilities for numBins outcomes
        }

        private void generateProbs(int n)
        {
            if (n <= 0) throw new ArgumentException("n must be positive");

            double[] probabilities = new double[n];
            double sum = 0;
            double[] cumulative = new double[n];

            // Generate random numbers
            for (int i = 0; i < n; i++)
            {
                probabilities[i] = this.rnd.NextDouble();
                sum += probabilities[i];
            }

            double total = 0;
            // Normalize so they sum to 1
            for (int i = 0; i < n; i++)
            {
                probabilities[i] /= sum;
                total += probabilities[i];
                cumulative[i] = total;
            }
            

            this.probs = probabilities;
            this.cumulativeProb = cumulative;
            this.outcomes = Enumerable.Range(0, n).ToArray();
            CalculateTheoreticalStatistics();
        }

        public void Paint_Graph(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            float padding = 50;
            float width = (float)this.histogram.width - 40;
            float height = (float)this.histogram.height - 1.4f * padding;

            float barWidth = (width / this.numBins) / 3;
            float barSpacing = width / this.numBins;
            float barGap = barWidth *0.25f;  // Add gap between theoretical and empirical bars

            var samples = GenerateSamples(this.sampleSize, this.outcomes, this.cumulativeProb);
            this.probMap = CalculateEmpiricalDistribution(samples, this.outcomes);


            double maxTheoretical = this.probs.Max();

            double maxEmpirical = this.probMap.MaxBy(kvp => kvp.Value).Value;

            double maxProbability = Math.Max(maxTheoretical, maxEmpirical);

            float scaleFactor = height / (float)maxProbability;

            using (Font probFont = new Font(SystemFonts.DefaultFont.FontFamily, 8f))
            {
                for (int i = 0; i < this.numBins; i++)
                {
                    float x = 40 + i * barSpacing + barWidth / 2;
                    string label = this.outcomes[i].ToString();

                    // Draw x-axis label
                    g.DrawString(label,
                                SystemFonts.DefaultFont,
                                Brushes.Black,
                                x,
                                height + padding + 5,
                                new StringFormat { Alignment = StringAlignment.Center });

                    // Theoretical probabilities (left bar) - moved left by barGap/2
                    float theoreticalBarHeight = (float)this.probs[i] * scaleFactor;
                    g.FillRectangle(Brushes.Blue,
                                   x - barWidth - barGap / 5,
                                   height + padding - theoreticalBarHeight,
                                   barWidth,
                                   theoreticalBarHeight);

                    // Draw theoretical probability label
                    string theoreticalLabel = string.Format("{0:P1}", this.probs[i]);
                    g.DrawString(theoreticalLabel,
                                probFont,
                                Brushes.Black,
                                x - barWidth - barGap / 2 + 15,
                                height + padding - theoreticalBarHeight - 15,
                                new StringFormat { Alignment = StringAlignment.Center });

                    // Empirical probabilities (right bar) - moved right by barGap/2
                    float empiricalBarHeight = (float)(this.probMap[i] * scaleFactor);
                    g.FillRectangle(Brushes.Red,
                                   x + barGap / 2,
                                   height + padding - empiricalBarHeight,
                                   barWidth,
                                   empiricalBarHeight);

                    // Draw empirical probability label
                    string empiricalLabel = string.Format("{0:P1}", this.probMap[i]);
                    g.DrawString(empiricalLabel,
                                probFont,
                                Brushes.Black,
                                x + barGap / 2 +15,
                                height + padding - empiricalBarHeight - 15,
                                new StringFormat { Alignment = StringAlignment.Center });
                }
            }
        }

        private int[] GenerateSamples(int sampleSize, int[] outcomes, double[] cumulativeProbs)
        {
            int[] samples = new int[sampleSize];
            var welford = new WelfordAccumulator();

            for (int i = 0; i < sampleSize; i++)
            {
                double rnd = this.rnd.NextDouble();

                int outcome = 0;
                while (outcome < cumulativeProbs.Length &&
                       rnd > cumulativeProbs[outcome])
                {
                    outcome++;
                }
                samples[i] = outcomes[outcome];
                welford.Update(outcomes[outcome]);
            }

            empiricalMean = welford.Mean;
            empiricalVariance = welford.Variance;
            return samples;
        }

        private Dictionary<int, double> CalculateEmpiricalDistribution(int[] samples, int[] possibleOutcomes)
        {
            var counts = new Dictionary<int, int>();
            foreach (int outcome in possibleOutcomes)
                counts[outcome] = 0;

            foreach (int sample in samples)
                counts[sample]++;

            return counts.ToDictionary(
                kvp => kvp.Key,
                kvp => (double)kvp.Value / samples.Length);
        }

        private void CalculateTheoreticalStatistics()
        {
            // Calculate theoretical mean (Expected Value)
            theoreticalMean = 0;
            for (int i = 0; i < outcomes.Length; i++)
            {
                theoreticalMean += this.outcomes[i] * probs[i];
            }

            // Calculate theoretical variance
            theoreticalVariance = 0;
            for (int i = 0; i < outcomes.Length; i++)
            {
                theoreticalVariance += Math.Pow(outcomes[i] - theoreticalMean, 2) * probs[i];
            }
        }


        private class WelfordAccumulator
        {
            private int count = 0;
            private double mean = 0;
            private double m2 = 0;

            public void Update(double value)
            {
                count++;
                double delta = value - mean;
                mean += delta / count;
                double delta2 = value - mean;
                m2 += delta * delta2;
            }

            public double Mean => mean;
            public double Variance => count > 1 ? m2 / (count - 1) : 0;
        }
    }


}
