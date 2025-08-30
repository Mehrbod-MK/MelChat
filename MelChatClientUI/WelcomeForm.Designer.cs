namespace MelChatClientUI
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            labelInTheNameOfGod = new Label();
            labelWelcomeTo = new Label();
            pictureBox1 = new PictureBox();
            buttonStartChatting = new Button();
            labelAbout = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelInTheNameOfGod
            // 
            labelInTheNameOfGod.Font = new Font("Segoe UI", 14F);
            labelInTheNameOfGod.Location = new Point(12, 10);
            labelInTheNameOfGod.Name = "labelInTheNameOfGod";
            labelInTheNameOfGod.Size = new Size(602, 39);
            labelInTheNameOfGod.TabIndex = 0;
            labelInTheNameOfGod.Text = "In the name of God";
            labelInTheNameOfGod.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelWelcomeTo
            // 
            labelWelcomeTo.Font = new Font("Segoe UI", 16F);
            labelWelcomeTo.Location = new Point(12, 62);
            labelWelcomeTo.Name = "labelWelcomeTo";
            labelWelcomeTo.Size = new Size(602, 39);
            labelWelcomeTo.TabIndex = 1;
            labelWelcomeTo.Text = "Welcome to";
            labelWelcomeTo.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.melChat_Logo_Day;
            pictureBox1.Location = new Point(12, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(602, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // buttonStartChatting
            // 
            buttonStartChatting.BackColor = Color.Transparent;
            buttonStartChatting.Cursor = Cursors.Hand;
            buttonStartChatting.FlatAppearance.BorderColor = Color.White;
            buttonStartChatting.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            buttonStartChatting.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            buttonStartChatting.FlatStyle = FlatStyle.Flat;
            buttonStartChatting.Font = new Font("Segoe UI", 20F);
            buttonStartChatting.ForeColor = Color.FromArgb(81, 149, 210);
            buttonStartChatting.Location = new Point(151, 249);
            buttonStartChatting.Name = "buttonStartChatting";
            buttonStartChatting.Size = new Size(324, 96);
            buttonStartChatting.TabIndex = 3;
            buttonStartChatting.Text = "Start Chatting!";
            buttonStartChatting.UseVisualStyleBackColor = false;
            // 
            // labelAbout
            // 
            labelAbout.Font = new Font("Segoe UI", 8F);
            labelAbout.Location = new Point(12, 348);
            labelAbout.Name = "labelAbout";
            labelAbout.Size = new Size(602, 39);
            labelAbout.TabIndex = 4;
            labelAbout.Text = "Developed by: Mehrbod Molla Kazemi \r\nApp Version:";
            labelAbout.TextAlign = ContentAlignment.BottomCenter;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(626, 396);
            Controls.Add(labelAbout);
            Controls.Add(buttonStartChatting);
            Controls.Add(pictureBox1);
            Controls.Add(labelWelcomeTo);
            Controls.Add(labelInTheNameOfGod);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MelChat - Welcome!";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelInTheNameOfGod;
        private Label labelWelcomeTo;
        private PictureBox pictureBox1;
        private Button buttonStartChatting;
        private Label labelAbout;
    }
}
