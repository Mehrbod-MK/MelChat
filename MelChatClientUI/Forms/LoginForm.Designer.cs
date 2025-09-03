namespace MelChatClientUI.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBoxMelChatLogo = new PictureBox();
            labelLoginToMelChat = new Label();
            labelUsername = new Label();
            textBoxUsername = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            labelServerIP = new Label();
            textBoxServerIP = new TextBox();
            buttonLogin = new Button();
            labelDontHaveAccount = new Label();
            linkLabelSignUp = new LinkLabel();
            linkLabelAccountRecovery = new LinkLabel();
            labelForgotCredentials = new Label();
            pictureBoxInfoUsername = new PictureBox();
            labelInfoUsername = new Label();
            labelInfoPassword = new Label();
            pictureBoxInfoPassword = new PictureBox();
            labelInfoServerIPDomain = new Label();
            pictureBoxInfoServerIPDomain = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMelChatLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfoUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfoPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfoServerIPDomain).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMelChatLogo
            // 
            pictureBoxMelChatLogo.Image = Properties.Resources.melChat_Logo_Day;
            pictureBoxMelChatLogo.Location = new Point(12, 12);
            pictureBoxMelChatLogo.Name = "pictureBoxMelChatLogo";
            pictureBoxMelChatLogo.Size = new Size(162, 74);
            pictureBoxMelChatLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMelChatLogo.TabIndex = 0;
            pictureBoxMelChatLogo.TabStop = false;
            // 
            // labelLoginToMelChat
            // 
            labelLoginToMelChat.Font = new Font("Segoe UI", 14F);
            labelLoginToMelChat.Location = new Point(12, 89);
            labelLoginToMelChat.Name = "labelLoginToMelChat";
            labelLoginToMelChat.Size = new Size(598, 39);
            labelLoginToMelChat.TabIndex = 2;
            labelLoginToMelChat.Text = "Login to your MelChat account.";
            labelLoginToMelChat.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelUsername
            // 
            labelUsername.Font = new Font("Segoe UI", 12F);
            labelUsername.Location = new Point(12, 147);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(310, 39);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "Username:";
            labelUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(12, 189);
            textBoxUsername.MaxLength = 32;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(310, 27);
            textBoxUsername.TabIndex = 4;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            textBoxUsername.Leave += textBoxUsername_Leave;
            // 
            // labelPassword
            // 
            labelPassword.Font = new Font("Segoe UI", 12F);
            labelPassword.Location = new Point(12, 251);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(310, 39);
            labelPassword.TabIndex = 5;
            labelPassword.Text = "Password:";
            labelPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(12, 293);
            textBoxPassword.MaxLength = 100;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(310, 27);
            textBoxPassword.TabIndex = 6;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            textBoxPassword.Leave += textBoxPassword_Leave;
            // 
            // labelServerIP
            // 
            labelServerIP.Font = new Font("Segoe UI", 12F);
            labelServerIP.Location = new Point(12, 359);
            labelServerIP.Name = "labelServerIP";
            labelServerIP.Size = new Size(310, 39);
            labelServerIP.TabIndex = 7;
            labelServerIP.Text = "MelChat™ Server IP/Domain:Port:";
            labelServerIP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxServerIP
            // 
            textBoxServerIP.Location = new Point(12, 401);
            textBoxServerIP.Name = "textBoxServerIP";
            textBoxServerIP.Size = new Size(310, 27);
            textBoxServerIP.TabIndex = 8;
            textBoxServerIP.TextChanged += textBoxServerIP_TextChanged;
            textBoxServerIP.Leave += textBoxServerIP_Leave;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Transparent;
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatAppearance.BorderColor = Color.White;
            buttonLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            buttonLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 14F);
            buttonLogin.ForeColor = Color.FromArgb(37, 91, 141);
            buttonLogin.Location = new Point(498, 408);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(112, 69);
            buttonLogin.TabIndex = 9;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonStartChatting_Click;
            // 
            // labelDontHaveAccount
            // 
            labelDontHaveAccount.Font = new Font("Segoe UI", 9F);
            labelDontHaveAccount.Location = new Point(361, 189);
            labelDontHaveAccount.Name = "labelDontHaveAccount";
            labelDontHaveAccount.Size = new Size(249, 23);
            labelDontHaveAccount.TabIndex = 10;
            labelDontHaveAccount.Text = "Don't have an account?";
            labelDontHaveAccount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // linkLabelSignUp
            // 
            linkLabelSignUp.AutoSize = true;
            linkLabelSignUp.Cursor = Cursors.Hand;
            linkLabelSignUp.Location = new Point(361, 212);
            linkLabelSignUp.Name = "linkLabelSignUp";
            linkLabelSignUp.Size = new Size(116, 20);
            linkLabelSignUp.TabIndex = 11;
            linkLabelSignUp.TabStop = true;
            linkLabelSignUp.Text = "Request sign-up";
            // 
            // linkLabelAccountRecovery
            // 
            linkLabelAccountRecovery.AutoSize = true;
            linkLabelAccountRecovery.Cursor = Cursors.Hand;
            linkLabelAccountRecovery.Location = new Point(361, 318);
            linkLabelAccountRecovery.Name = "linkLabelAccountRecovery";
            linkLabelAccountRecovery.Size = new Size(123, 20);
            linkLabelAccountRecovery.TabIndex = 13;
            linkLabelAccountRecovery.TabStop = true;
            linkLabelAccountRecovery.Text = "Account recovery";
            // 
            // labelForgotCredentials
            // 
            labelForgotCredentials.Font = new Font("Segoe UI", 9F);
            labelForgotCredentials.Location = new Point(361, 295);
            labelForgotCredentials.Name = "labelForgotCredentials";
            labelForgotCredentials.Size = new Size(249, 23);
            labelForgotCredentials.TabIndex = 12;
            labelForgotCredentials.Text = "Forgot your credentials?";
            labelForgotCredentials.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxInfoUsername
            // 
            pictureBoxInfoUsername.Image = Properties.Resources.information;
            pictureBoxInfoUsername.Location = new Point(12, 222);
            pictureBoxInfoUsername.Name = "pictureBoxInfoUsername";
            pictureBoxInfoUsername.Size = new Size(24, 24);
            pictureBoxInfoUsername.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxInfoUsername.TabIndex = 14;
            pictureBoxInfoUsername.TabStop = false;
            // 
            // labelInfoUsername
            // 
            labelInfoUsername.Font = new Font("Segoe UI", 9F);
            labelInfoUsername.ForeColor = Color.Gray;
            labelInfoUsername.Location = new Point(42, 222);
            labelInfoUsername.Name = "labelInfoUsername";
            labelInfoUsername.Size = new Size(280, 24);
            labelInfoUsername.TabIndex = 15;
            labelInfoUsername.Text = "Registered username.";
            labelInfoUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelInfoPassword
            // 
            labelInfoPassword.Font = new Font("Segoe UI", 9F);
            labelInfoPassword.ForeColor = Color.Gray;
            labelInfoPassword.Location = new Point(42, 326);
            labelInfoPassword.Name = "labelInfoPassword";
            labelInfoPassword.Size = new Size(280, 24);
            labelInfoPassword.TabIndex = 17;
            labelInfoPassword.Text = "Corresponding account password.";
            labelInfoPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxInfoPassword
            // 
            pictureBoxInfoPassword.Image = Properties.Resources.information;
            pictureBoxInfoPassword.Location = new Point(12, 326);
            pictureBoxInfoPassword.Name = "pictureBoxInfoPassword";
            pictureBoxInfoPassword.Size = new Size(24, 24);
            pictureBoxInfoPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxInfoPassword.TabIndex = 16;
            pictureBoxInfoPassword.TabStop = false;
            // 
            // labelInfoServerIPDomain
            // 
            labelInfoServerIPDomain.Font = new Font("Segoe UI", 9F);
            labelInfoServerIPDomain.ForeColor = Color.Gray;
            labelInfoServerIPDomain.Location = new Point(42, 434);
            labelInfoServerIPDomain.Name = "labelInfoServerIPDomain";
            labelInfoServerIPDomain.Size = new Size(280, 24);
            labelInfoServerIPDomain.TabIndex = 19;
            labelInfoServerIPDomain.Text = "IP/Domain:Port of MelChat Server";
            labelInfoServerIPDomain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxInfoServerIPDomain
            // 
            pictureBoxInfoServerIPDomain.Image = Properties.Resources.information;
            pictureBoxInfoServerIPDomain.Location = new Point(12, 434);
            pictureBoxInfoServerIPDomain.Name = "pictureBoxInfoServerIPDomain";
            pictureBoxInfoServerIPDomain.Size = new Size(24, 24);
            pictureBoxInfoServerIPDomain.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxInfoServerIPDomain.TabIndex = 18;
            pictureBoxInfoServerIPDomain.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(622, 485);
            Controls.Add(labelInfoServerIPDomain);
            Controls.Add(pictureBoxInfoServerIPDomain);
            Controls.Add(labelInfoPassword);
            Controls.Add(pictureBoxInfoPassword);
            Controls.Add(labelInfoUsername);
            Controls.Add(pictureBoxInfoUsername);
            Controls.Add(linkLabelAccountRecovery);
            Controls.Add(labelForgotCredentials);
            Controls.Add(linkLabelSignUp);
            Controls.Add(labelDontHaveAccount);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxServerIP);
            Controls.Add(labelServerIP);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelUsername);
            Controls.Add(labelLoginToMelChat);
            Controls.Add(pictureBoxMelChatLogo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MelChat - Login";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMelChatLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfoUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfoPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfoServerIPDomain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxMelChatLogo;
        private Label labelLoginToMelChat;
        private Label labelUsername;
        private TextBox textBoxUsername;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Label labelServerIP;
        private TextBox textBoxServerIP;
        private Button buttonLogin;
        private Label labelDontHaveAccount;
        private LinkLabel linkLabelSignUp;
        private LinkLabel linkLabelAccountRecovery;
        private Label labelForgotCredentials;
        private PictureBox pictureBoxInfoUsername;
        private Label labelInfoUsername;
        private Label labelInfoPassword;
        private PictureBox pictureBoxInfoPassword;
        private Label labelInfoServerIPDomain;
        private PictureBox pictureBoxInfoServerIPDomain;
    }
}