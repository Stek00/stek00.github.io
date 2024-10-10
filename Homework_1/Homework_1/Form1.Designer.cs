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
            histoBox = new PictureBox();
            labelTxt1 = new PictureBox();
            labelTxt3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)graphBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)histoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)labelTxt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)labelTxt3).BeginInit();
            SuspendLayout();
            // 
            // nHackers
            // 
            nHackers.Location = new Point(51, 38);
            nHackers.Name = "nHackers";
            nHackers.Size = new Size(130, 23);
            nHackers.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 18);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 1;
            label1.Text = "Number of Hackers";
            // 
            // nServers
            // 
            nServers.Location = new Point(224, 38);
            nServers.Name = "nServers";
            nServers.Size = new Size(129, 23);
            nServers.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(224, 18);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 3;
            label2.Text = "Number of servers";
            // 
            // probability
            // 
            probability.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            probability.Location = new Point(395, 38);
            probability.Name = "probability";
            probability.Size = new Size(122, 23);
            probability.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(395, 18);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 5;
            label3.Text = "Probability";
            // 
            // runBtn
            // 
            runBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            runBtn.AutoSize = true;
            runBtn.Location = new Point(617, 25);
            runBtn.Name = "runBtn";
            runBtn.Size = new Size(96, 47);
            runBtn.TabIndex = 6;
            runBtn.Text = "Run";
            runBtn.UseVisualStyleBackColor = true;
            runBtn.Click += runBtn_Click;
            // 
            // graphBox
            // 
            graphBox.BackColor = Color.White;
            graphBox.BorderStyle = BorderStyle.FixedSingle;
            graphBox.Location = new Point(12, 92);
            graphBox.Name = "graphBox";
            graphBox.Size = new Size(549, 375);
            graphBox.TabIndex = 7;
            graphBox.TabStop = false;
            // 
            // histoBox
            // 
            histoBox.BackColor = Color.White;
            histoBox.BorderStyle = BorderStyle.FixedSingle;
            histoBox.Location = new Point(567, 92);
            histoBox.Name = "histoBox";
            histoBox.Size = new Size(221, 375);
            histoBox.TabIndex = 8;
            histoBox.TabStop = false;
            // 
            // labelTxt1
            // 
            labelTxt1.Location = new Point(12, 468);
            labelTxt1.Name = "labelTxt1";
            labelTxt1.Size = new Size(549, 17);
            labelTxt1.TabIndex = 9;
            labelTxt1.TabStop = false;
            // 
            // labelTxt3
            // 
            labelTxt3.Location = new Point(567, 468);
            labelTxt3.Name = "labelTxt3";
            labelTxt3.Size = new Size(221, 17);
            labelTxt3.TabIndex = 11;
            labelTxt3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 530);
            Controls.Add(labelTxt3);
            Controls.Add(labelTxt1);
            Controls.Add(histoBox);
            Controls.Add(graphBox);
            Controls.Add(runBtn);
            Controls.Add(label3);
            Controls.Add(probability);
            Controls.Add(label2);
            Controls.Add(nServers);
            Controls.Add(label1);
            Controls.Add(nHackers);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximumSize = new Size(816, 573);
            MinimumSize = new Size(816, 573);
            Name = "Form1";
            Text = "Homework1";
            ((System.ComponentModel.ISupportInitialize)graphBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)histoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)labelTxt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)labelTxt3).EndInit();
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
        private PictureBox histoBox;
        private PictureBox labelTxt1;
        private PictureBox labelTxt3;
    }
}
