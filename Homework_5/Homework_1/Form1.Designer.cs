namespace Homework_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nHackers = new TextBox();
            label1 = new Label();
            nServers = new TextBox();
            label2 = new Label();
            probability = new TextBox();
            label3 = new Label();
            runBtn = new Button();
            graphBox = new PictureBox();
            kText = new TextBox();
            kTime = new Label();
            meanEnd = new Label();
            varEnd = new Label();
            meanK = new Label();
            varK = new Label();
            atTimeK = new Label();
            finalValues = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            meanText = new TextBox();
            varText = new TextBox();
            meanEndText = new TextBox();
            varEndText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)graphBox).BeginInit();
            SuspendLayout();
            // 
            // nHackers
            // 
            nHackers.Location = new Point(14, 38);
            nHackers.Name = "nHackers";
            nHackers.Size = new Size(130, 23);
            nHackers.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 18);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 1;
            label1.Text = "Number of Hackers";
            // 
            // nServers
            // 
            nServers.Location = new Point(187, 38);
            nServers.Name = "nServers";
            nServers.Size = new Size(120, 23);
            nServers.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(187, 18);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 3;
            label2.Text = "Number of servers";
            // 
            // probability
            // 
            probability.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            probability.Location = new Point(507, 38);
            probability.Name = "probability";
            probability.Size = new Size(130, 23);
            probability.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(507, 18);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 5;
            label3.Text = "Probability";
            // 
            // runBtn
            // 
            runBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            runBtn.AutoSize = true;
            runBtn.Location = new Point(677, 53);
            runBtn.Name = "runBtn";
            runBtn.Size = new Size(96, 41);
            runBtn.TabIndex = 6;
            runBtn.Text = "Run";
            runBtn.UseVisualStyleBackColor = true;
            runBtn.Click += runBtn_Click;
            // 
            // graphBox
            // 
            graphBox.BackColor = Color.White;
            graphBox.BorderStyle = BorderStyle.FixedSingle;
            graphBox.Location = new Point(14, 130);
            graphBox.Name = "graphBox";
            graphBox.Size = new Size(770, 374);
            graphBox.TabIndex = 7;
            graphBox.TabStop = false;
            // 
            // kText
            // 
            kText.Location = new Point(355, 38);
            kText.Name = "kText";
            kText.Size = new Size(120, 23);
            kText.TabIndex = 12;
            // 
            // kTime
            // 
            kTime.AutoSize = true;
            kTime.Location = new Point(355, 20);
            kTime.Name = "kTime";
            kTime.Size = new Size(85, 15);
            kTime.TabIndex = 13;
            kTime.Text = "Sample Time K";
            // 
            // meanEnd
            // 
            meanEnd.AutoSize = true;
            meanEnd.Location = new Point(247, 567);
            meanEnd.Name = "meanEnd";
            meanEnd.Size = new Size(37, 15);
            meanEnd.TabIndex = 18;
            meanEnd.Text = "Mean";
            // 
            // varEnd
            // 
            varEnd.AutoSize = true;
            varEnd.Location = new Point(450, 567);
            varEnd.Name = "varEnd";
            varEnd.Size = new Size(51, 15);
            varEnd.TabIndex = 19;
            varEnd.Text = "Variance";
            // 
            // meanK
            // 
            meanK.AutoSize = true;
            meanK.Location = new Point(247, 523);
            meanK.Name = "meanK";
            meanK.Size = new Size(37, 15);
            meanK.TabIndex = 20;
            meanK.Text = "Mean";
            // 
            // varK
            // 
            varK.AutoSize = true;
            varK.Location = new Point(449, 523);
            varK.Name = "varK";
            varK.Size = new Size(51, 15);
            varK.TabIndex = 21;
            varK.Text = "Variance";
            // 
            // atTimeK
            // 
            atTimeK.AutoSize = true;
            atTimeK.Location = new Point(138, 523);
            atTimeK.Name = "atTimeK";
            atTimeK.Size = new Size(79, 15);
            atTimeK.TabIndex = 22;
            atTimeK.Text = "Time K Values";
            // 
            // finalValues
            // 
            finalValues.AutoSize = true;
            finalValues.Location = new Point(138, 567);
            finalValues.Name = "finalValues";
            finalValues.Size = new Size(68, 15);
            finalValues.TabIndex = 23;
            finalValues.Text = "Final Values";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(28, 85);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(72, 19);
            radioButton1.TabIndex = 24;
            radioButton1.TabStop = true;
            radioButton1.Text = "Bernoulli";
            radioButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(118, 85);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(99, 19);
            radioButton2.TabIndex = 25;
            radioButton2.TabStop = true;
            radioButton2.Text = "Random Walk";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(239, 85);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(124, 19);
            radioButton3.TabIndex = 26;
            radioButton3.TabStop = true;
            radioButton3.Text = "Relative Frequency";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(389, 85);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(109, 19);
            radioButton5.TabIndex = 28;
            radioButton5.TabStop = true;
            radioButton5.Text = "Continuos Time";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(533, 85);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(93, 19);
            radioButton6.TabIndex = 29;
            radioButton6.TabStop = true;
            radioButton6.Text = "Scaling Limit";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += Radio_CheckChanged;
            // 
            // textBox1
            // 
            meanText.Location = new Point(308, 523);
            meanText.Name = "textBox1";
            meanText.ReadOnly = true;
            meanText.Size = new Size(100, 23);
            meanText.TabIndex = 30;
            meanText.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            varText.Location = new Point(533, 523);
            varText.Name = "textBox2";
            varText.ReadOnly = true;
            varText.Size = new Size(100, 23);
            varText.TabIndex = 31;
            varText.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            meanEndText.Location = new Point(308, 564);
            meanEndText.Name = "textBox3";
            meanEndText.ReadOnly = true;
            meanEndText.Size = new Size(100, 23);
            meanEndText.TabIndex = 32;
            meanEndText.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            varEndText.Location = new Point(533, 564);
            varEndText.Name = "textBox4";
            varEndText.ReadOnly = true;
            varEndText.Size = new Size(100, 23);
            varEndText.TabIndex = 33;
            varEndText.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 607);
            Controls.Add(varEndText);
            Controls.Add(meanEndText);
            Controls.Add(varText);
            Controls.Add(meanText);
            Controls.Add(radioButton6);
            Controls.Add(radioButton5);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(finalValues);
            Controls.Add(atTimeK);
            Controls.Add(varK);
            Controls.Add(meanK);
            Controls.Add(varEnd);
            Controls.Add(meanEnd);
            Controls.Add(kTime);
            Controls.Add(kText);
            Controls.Add(graphBox);
            Controls.Add(runBtn);
            Controls.Add(label3);
            Controls.Add(probability);
            Controls.Add(label2);
            Controls.Add(nServers);
            Controls.Add(label1);
            Controls.Add(nHackers);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximumSize = new Size(816, 650);
            MinimumSize = new Size(816, 650);
            Name = "Form1";
            Text = "Homework1";
            ((System.ComponentModel.ISupportInitialize)graphBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nHackers;
        private Label label1;
        private TextBox nServers;
        private Label label2;
        private TextBox probability;
        private Label label3;
        private Button runBtn;
        private PictureBox graphBox;
        private TextBox kText;
        private Label kTime;
        private Label meanEnd;
        private Label varEnd;
        private Label meanK;
        private Label varK;
        private Label atTimeK;
        private Label finalValues;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private TextBox meanText;
        private TextBox varText;
        private TextBox meanEndText;
        private TextBox varEndText;
    }
}
