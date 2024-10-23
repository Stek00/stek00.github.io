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
            ((System.ComponentModel.ISupportInitialize)graphBox).BeginInit();
            SuspendLayout();
            // 
            // nHackers
            // 
            nHackers.Location = new Point(75, 40);
            nHackers.Name = "nHackers";
            nHackers.Size = new Size(130, 23);
            nHackers.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 20);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 1;
            label1.Text = "Number of Hackers";
            // 
            // nServers
            // 
            nServers.Location = new Point(280, 40);
            nServers.Name = "nServers";
            nServers.Size = new Size(129, 23);
            nServers.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(280, 20);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 3;
            label2.Text = "Time interval";
            // 
            // probability
            // 
            probability.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            probability.Location = new Point(480, 40);
            probability.Name = "Lambda";
            probability.Size = new Size(122, 23);
            probability.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(480, 20);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 5;
            label3.Text = "Lambda";
            // 
            // runBtn
            // 
            runBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            runBtn.AutoSize = true;
            runBtn.Location = new Point(692, 20);
            runBtn.Name = "runBtn";
            runBtn.Size = new Size(96, 52);
            runBtn.TabIndex = 6;
            runBtn.Text = "Run";
            runBtn.UseVisualStyleBackColor = true;
            runBtn.Click += runBtn_Click;
            // 
            // graphBox
            // 
            graphBox.BackColor = Color.White;
            graphBox.BorderStyle = BorderStyle.FixedSingle;
            graphBox.Location = new Point(12, 82);
            graphBox.Name = "graphBox";
            graphBox.Size = new Size(1155, 529);
            graphBox.TabIndex = 7;
            graphBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 635);
            Controls.Add(graphBox);
            Controls.Add(runBtn);
            Controls.Add(label3);
            Controls.Add(probability);
            Controls.Add(label2);
            Controls.Add(nServers);
            Controls.Add(label1);
            Controls.Add(nHackers);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximumSize = new Size(1200, 678);
            MinimumSize = new Size(1200, 678);
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

    }
}
