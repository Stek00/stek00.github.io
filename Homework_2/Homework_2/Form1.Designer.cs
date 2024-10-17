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
            meanKtext = new TextBox();
            varKtext = new TextBox();
            meanEtext = new TextBox();
            varEtext = new TextBox();
            meanEnd = new Label();
            varEnd = new Label();
            meanK = new Label();
            varK = new Label();
            atTimeK = new Label();
            finalValues = new Label();
            absoluteGraph = new PictureBox();
            relativeGraph = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)graphBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)absoluteGraph).BeginInit();
            ((System.ComponentModel.ISupportInitialize)relativeGraph).BeginInit();
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
            nServers.Location = new Point(166, 38);
            nServers.Name = "nServers";
            nServers.Size = new Size(129, 23);
            nServers.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(166, 18);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 3;
            label2.Text = "Number of servers";
            // 
            // probability
            // 
            probability.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            probability.Location = new Point(315, 38);
            probability.Name = "probability";
            probability.Size = new Size(122, 23);
            probability.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(315, 18);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 5;
            label3.Text = "Probability";
            // 
            // runBtn
            // 
            runBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            runBtn.AutoSize = true;
            runBtn.Location = new Point(688, 20);
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
            graphBox.Location = new Point(14, 67);
            graphBox.Name = "graphBox";
            graphBox.Size = new Size(770, 210);
            graphBox.TabIndex = 7;
            graphBox.TabStop = false;
            // 
            // kText
            // 
            kText.Location = new Point(458, 38);
            kText.Name = "kText";
            kText.Size = new Size(120, 23);
            kText.TabIndex = 12;
            // 
            // kTime
            // 
            kTime.AutoSize = true;
            kTime.Location = new Point(458, 20);
            kTime.Name = "kTime";
            kTime.Size = new Size(85, 15);
            kTime.TabIndex = 13;
            kTime.Text = "Sample Time K";
            // 
            // meanKtext
            // 
            meanKtext.Location = new Point(291, 520);
            meanKtext.Name = "meanKtext";
            meanKtext.ReadOnly = true;
            meanKtext.Size = new Size(143, 23);
            meanKtext.TabIndex = 14;
            // 
            // varKtext
            // 
            varKtext.Location = new Point(507, 520);
            varKtext.Name = "varKtext";
            varKtext.ReadOnly = true;
            varKtext.Size = new Size(143, 23);
            varKtext.TabIndex = 15;
            // 
            // meanEtext
            // 
            meanEtext.Location = new Point(291, 564);
            meanEtext.Name = "meanEtext";
            meanEtext.ReadOnly = true;
            meanEtext.Size = new Size(143, 23);
            meanEtext.TabIndex = 16;
            // 
            // varEtext
            // 
            varEtext.Location = new Point(507, 564);
            varEtext.Name = "varEtext";
            varEtext.ReadOnly = true;
            varEtext.Size = new Size(143, 23);
            varEtext.TabIndex = 17;
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
            // absoluteGraph
            // 
            absoluteGraph.BackColor = Color.White;
            absoluteGraph.BorderStyle = BorderStyle.FixedSingle;
            absoluteGraph.Location = new Point(14, 286);
            absoluteGraph.Name = "absoluteGraph";
            absoluteGraph.Size = new Size(380, 210);
            absoluteGraph.TabIndex = 24;
            absoluteGraph.TabStop = false;
            // 
            // relativeGraph
            // 
            relativeGraph.BackColor = Color.White;
            relativeGraph.BorderStyle = BorderStyle.FixedSingle;
            relativeGraph.Location = new Point(404, 286);
            relativeGraph.Name = "relativeGraph";
            relativeGraph.Size = new Size(380, 210);
            relativeGraph.TabIndex = 25;
            relativeGraph.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 607);
            Controls.Add(relativeGraph);
            Controls.Add(absoluteGraph);
            Controls.Add(finalValues);
            Controls.Add(atTimeK);
            Controls.Add(varK);
            Controls.Add(meanK);
            Controls.Add(varEnd);
            Controls.Add(meanEnd);
            Controls.Add(varEtext);
            Controls.Add(meanEtext);
            Controls.Add(varKtext);
            Controls.Add(meanKtext);
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
            ((System.ComponentModel.ISupportInitialize)absoluteGraph).EndInit();
            ((System.ComponentModel.ISupportInitialize)relativeGraph).EndInit();
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
        private TextBox meanKtext;
        private TextBox varKtext;
        private TextBox meanEtext;
        private TextBox varEtext;
        private Label meanEnd;
        private Label varEnd;
        private Label meanK;
        private Label varK;
        private Label atTimeK;
        private Label finalValues;
        private PictureBox absoluteGraph;
        private PictureBox relativeGraph;
    }
}
