namespace Server
{
    partial class SignInUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInUp));
            this.SignInPanel = new System.Windows.Forms.Panel();
            this.SigninQrcodeButton = new System.Windows.Forms.Button();
            this.HidePasswordPicture = new System.Windows.Forms.PictureBox();
            this.ShowPasswordPicture = new System.Windows.Forms.PictureBox();
            this.SignInPassword = new Server.CustomTextBox();
            this.SignInEmail = new Server.CustomTextBox();
            this.SignInButton = new System.Windows.Forms.Button();
            this.SignInLabel = new System.Windows.Forms.Label();
            this.SignUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.InviteToSignUpLabel = new System.Windows.Forms.Label();
            this.SignUpPanel = new System.Windows.Forms.Panel();
            this.HidePasswordPicture2 = new System.Windows.Forms.PictureBox();
            this.ShowPasswordPicture2 = new System.Windows.Forms.PictureBox();
            this.SignUpEmail = new Server.CustomTextBox();
            this.SignUpLastName = new Server.CustomTextBox();
            this.SignUpPassword = new Server.CustomTextBox();
            this.SignUpFirstName = new Server.CustomTextBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.SignInLinkLabel = new System.Windows.Forms.LinkLabel();
            this.InviteToSignInLabel = new System.Windows.Forms.Label();
            this.VerificationPanel = new System.Windows.Forms.Panel();
            this.VerificationExplainLabel = new System.Windows.Forms.Label();
            this.VerifyButton = new System.Windows.Forms.Button();
            this.VerificationCode = new Server.CustomTextBox();
            this.VerificationLabel = new System.Windows.Forms.Label();
            this.QrcodePanel = new System.Windows.Forms.Panel();
            this.SignInManuallyLinkLabel = new System.Windows.Forms.LinkLabel();
            this.QrcodeStart = new System.Windows.Forms.Button();
            this.QrcodeCameraPresent = new System.Windows.Forms.ComboBox();
            this.verifyQrcodePicturebox = new System.Windows.Forms.PictureBox();
            this.QrcodeFilePicturebox = new System.Windows.Forms.PictureBox();
            this.QrcodeFile = new System.Windows.Forms.Button();
            this.QrcodeWebcamPicturebox = new System.Windows.Forms.PictureBox();
            this.QrCodeWebcam = new System.Windows.Forms.Button();
            this.QrcodeSigninLabel = new System.Windows.Forms.Label();
            this.QrcodeMakePicturebox = new System.Windows.Forms.PictureBox();
            this.SignInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HidePasswordPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordPicture)).BeginInit();
            this.SignUpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HidePasswordPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordPicture2)).BeginInit();
            this.VerificationPanel.SuspendLayout();
            this.QrcodePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verifyQrcodePicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QrcodeFilePicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QrcodeWebcamPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QrcodeMakePicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // SignInPanel
            // 
            this.SignInPanel.Controls.Add(this.SigninQrcodeButton);
            this.SignInPanel.Controls.Add(this.HidePasswordPicture);
            this.SignInPanel.Controls.Add(this.ShowPasswordPicture);
            this.SignInPanel.Controls.Add(this.SignInPassword);
            this.SignInPanel.Controls.Add(this.SignInEmail);
            this.SignInPanel.Controls.Add(this.SignInButton);
            this.SignInPanel.Controls.Add(this.SignInLabel);
            this.SignInPanel.Controls.Add(this.SignUpLinkLabel);
            this.SignInPanel.Controls.Add(this.InviteToSignUpLabel);
            this.SignInPanel.Location = new System.Drawing.Point(12, 12);
            this.SignInPanel.Name = "SignInPanel";
            this.SignInPanel.Size = new System.Drawing.Size(341, 343);
            this.SignInPanel.TabIndex = 0;
            // 
            // SigninQrcodeButton
            // 
            this.SigninQrcodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.SigninQrcodeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SigninQrcodeButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SigninQrcodeButton.ForeColor = System.Drawing.Color.White;
            this.SigninQrcodeButton.Location = new System.Drawing.Point(8, 268);
            this.SigninQrcodeButton.Name = "SigninQrcodeButton";
            this.SigninQrcodeButton.Size = new System.Drawing.Size(327, 39);
            this.SigninQrcodeButton.TabIndex = 11;
            this.SigninQrcodeButton.Text = "Sign In By Qr Code";
            this.SigninQrcodeButton.UseVisualStyleBackColor = false;
            this.SigninQrcodeButton.Click += new System.EventHandler(this.SigninQrcodeButton_Click);
            // 
            // HidePasswordPicture
            // 
            this.HidePasswordPicture.BackColor = System.Drawing.Color.Transparent;
            this.HidePasswordPicture.Image = ((System.Drawing.Image)(resources.GetObject("HidePasswordPicture.Image")));
            this.HidePasswordPicture.Location = new System.Drawing.Point(304, 167);
            this.HidePasswordPicture.Name = "HidePasswordPicture";
            this.HidePasswordPicture.Size = new System.Drawing.Size(34, 18);
            this.HidePasswordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HidePasswordPicture.TabIndex = 10;
            this.HidePasswordPicture.TabStop = false;
            this.HidePasswordPicture.Visible = false;
            this.HidePasswordPicture.Click += new System.EventHandler(this.HidePasswordPicture_Click);
            // 
            // ShowPasswordPicture
            // 
            this.ShowPasswordPicture.BackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordPicture.Image = ((System.Drawing.Image)(resources.GetObject("ShowPasswordPicture.Image")));
            this.ShowPasswordPicture.Location = new System.Drawing.Point(304, 167);
            this.ShowPasswordPicture.Name = "ShowPasswordPicture";
            this.ShowPasswordPicture.Size = new System.Drawing.Size(34, 18);
            this.ShowPasswordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPasswordPicture.TabIndex = 9;
            this.ShowPasswordPicture.TabStop = false;
            this.ShowPasswordPicture.Click += new System.EventHandler(this.ShowPasswordPicture_Click);
            // 
            // SignInPassword
            // 
            this.SignInPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SignInPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SignInPassword.BackColor = System.Drawing.SystemColors.Control;
            this.SignInPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.SignInPassword.BorderFocusColor = System.Drawing.Color.Gray;
            this.SignInPassword.BordesSize = 2;
            this.SignInPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInPassword.Location = new System.Drawing.Point(8, 157);
            this.SignInPassword.Margin = new System.Windows.Forms.Padding(4);
            this.SignInPassword.MaxLength = 28;
            this.SignInPassword.Multiline = false;
            this.SignInPassword.Name = "SignInPassword";
            this.SignInPassword.Padding = new System.Windows.Forms.Padding(7);
            this.SignInPassword.PasswordChar = true;
            this.SignInPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.SignInPassword.PlaceholderText = "Password";
            this.SignInPassword.Size = new System.Drawing.Size(327, 34);
            this.SignInPassword.TabIndex = 8;
            this.SignInPassword.UnderlinedStyle = true;
            this.SignInPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SignInPassword_KeyPress);
            // 
            // SignInEmail
            // 
            this.SignInEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SignInEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SignInEmail.BackColor = System.Drawing.SystemColors.Control;
            this.SignInEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.SignInEmail.BorderFocusColor = System.Drawing.Color.Gray;
            this.SignInEmail.BordesSize = 2;
            this.SignInEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInEmail.Location = new System.Drawing.Point(8, 97);
            this.SignInEmail.Margin = new System.Windows.Forms.Padding(4);
            this.SignInEmail.MaxLength = 100;
            this.SignInEmail.Multiline = false;
            this.SignInEmail.Name = "SignInEmail";
            this.SignInEmail.Padding = new System.Windows.Forms.Padding(7);
            this.SignInEmail.PasswordChar = false;
            this.SignInEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.SignInEmail.PlaceholderText = "Email";
            this.SignInEmail.Size = new System.Drawing.Size(327, 34);
            this.SignInEmail.TabIndex = 7;
            this.SignInEmail.UnderlinedStyle = true;
            this.SignInEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SignInEmail_KeyPress);
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.SignInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.ForeColor = System.Drawing.Color.White;
            this.SignInButton.Location = new System.Drawing.Point(8, 223);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(327, 39);
            this.SignInButton.TabIndex = 6;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            this.SignInButton.MouseLeave += new System.EventHandler(this.SignInButton_MouseLeave);
            this.SignInButton.MouseHover += new System.EventHandler(this.SignInButton_MouseHover);
            // 
            // SignInLabel
            // 
            this.SignInLabel.AutoSize = true;
            this.SignInLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.SignInLabel.Location = new System.Drawing.Point(133, 11);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.Size = new System.Drawing.Size(65, 22);
            this.SignInLabel.TabIndex = 4;
            this.SignInLabel.Text = "Sign In";
            // 
            // SignUpLinkLabel
            // 
            this.SignUpLinkLabel.AutoSize = true;
            this.SignUpLinkLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLinkLabel.Location = new System.Drawing.Point(250, 307);
            this.SignUpLinkLabel.Name = "SignUpLinkLabel";
            this.SignUpLinkLabel.Size = new System.Drawing.Size(78, 26);
            this.SignUpLinkLabel.TabIndex = 1;
            this.SignUpLinkLabel.TabStop = true;
            this.SignUpLinkLabel.Text = "Sign Up";
            this.SignUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLinkLabel_LinkClicked);
            // 
            // InviteToSignUpLabel
            // 
            this.InviteToSignUpLabel.AutoSize = true;
            this.InviteToSignUpLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InviteToSignUpLabel.Location = new System.Drawing.Point(13, 307);
            this.InviteToSignUpLabel.Name = "InviteToSignUpLabel";
            this.InviteToSignUpLabel.Size = new System.Drawing.Size(231, 26);
            this.InviteToSignUpLabel.TabIndex = 1;
            this.InviteToSignUpLabel.Text = "Have not an account yet?";
            // 
            // SignUpPanel
            // 
            this.SignUpPanel.Controls.Add(this.HidePasswordPicture2);
            this.SignUpPanel.Controls.Add(this.ShowPasswordPicture2);
            this.SignUpPanel.Controls.Add(this.SignUpEmail);
            this.SignUpPanel.Controls.Add(this.SignUpLastName);
            this.SignUpPanel.Controls.Add(this.SignUpPassword);
            this.SignUpPanel.Controls.Add(this.SignUpFirstName);
            this.SignUpPanel.Controls.Add(this.SignUpButton);
            this.SignUpPanel.Controls.Add(this.SignUpLabel);
            this.SignUpPanel.Controls.Add(this.SignInLinkLabel);
            this.SignUpPanel.Controls.Add(this.InviteToSignInLabel);
            this.SignUpPanel.Location = new System.Drawing.Point(359, 12);
            this.SignUpPanel.Name = "SignUpPanel";
            this.SignUpPanel.Size = new System.Drawing.Size(341, 343);
            this.SignUpPanel.TabIndex = 1;
            this.SignUpPanel.Visible = false;
            // 
            // HidePasswordPicture2
            // 
            this.HidePasswordPicture2.BackColor = System.Drawing.Color.Transparent;
            this.HidePasswordPicture2.Image = ((System.Drawing.Image)(resources.GetObject("HidePasswordPicture2.Image")));
            this.HidePasswordPicture2.Location = new System.Drawing.Point(298, 191);
            this.HidePasswordPicture2.Name = "HidePasswordPicture2";
            this.HidePasswordPicture2.Size = new System.Drawing.Size(34, 18);
            this.HidePasswordPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HidePasswordPicture2.TabIndex = 12;
            this.HidePasswordPicture2.TabStop = false;
            this.HidePasswordPicture2.Visible = false;
            this.HidePasswordPicture2.Click += new System.EventHandler(this.HidePasswordPicture2_Click);
            // 
            // ShowPasswordPicture2
            // 
            this.ShowPasswordPicture2.BackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordPicture2.Image = ((System.Drawing.Image)(resources.GetObject("ShowPasswordPicture2.Image")));
            this.ShowPasswordPicture2.Location = new System.Drawing.Point(298, 191);
            this.ShowPasswordPicture2.Name = "ShowPasswordPicture2";
            this.ShowPasswordPicture2.Size = new System.Drawing.Size(34, 18);
            this.ShowPasswordPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPasswordPicture2.TabIndex = 11;
            this.ShowPasswordPicture2.TabStop = false;
            this.ShowPasswordPicture2.Click += new System.EventHandler(this.ShowPasswordPicture2_Click);
            // 
            // SignUpEmail
            // 
            this.SignUpEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SignUpEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SignUpEmail.BackColor = System.Drawing.SystemColors.Control;
            this.SignUpEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.SignUpEmail.BorderFocusColor = System.Drawing.Color.Gray;
            this.SignUpEmail.BordesSize = 2;
            this.SignUpEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpEmail.Location = new System.Drawing.Point(8, 139);
            this.SignUpEmail.Margin = new System.Windows.Forms.Padding(4);
            this.SignUpEmail.MaxLength = 100;
            this.SignUpEmail.Multiline = false;
            this.SignUpEmail.Name = "SignUpEmail";
            this.SignUpEmail.Padding = new System.Windows.Forms.Padding(7);
            this.SignUpEmail.PasswordChar = false;
            this.SignUpEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.SignUpEmail.PlaceholderText = "Email";
            this.SignUpEmail.Size = new System.Drawing.Size(327, 34);
            this.SignUpEmail.TabIndex = 10;
            this.SignUpEmail.UnderlinedStyle = false;
            this.SignUpEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SignUpEmail_KeyPress);
            // 
            // SignUpLastName
            // 
            this.SignUpLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SignUpLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SignUpLastName.BackColor = System.Drawing.SystemColors.Control;
            this.SignUpLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.SignUpLastName.BorderFocusColor = System.Drawing.Color.Gray;
            this.SignUpLastName.BordesSize = 2;
            this.SignUpLastName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLastName.Location = new System.Drawing.Point(176, 97);
            this.SignUpLastName.Margin = new System.Windows.Forms.Padding(4);
            this.SignUpLastName.MaxLength = 50;
            this.SignUpLastName.Multiline = false;
            this.SignUpLastName.Name = "SignUpLastName";
            this.SignUpLastName.Padding = new System.Windows.Forms.Padding(7);
            this.SignUpLastName.PasswordChar = false;
            this.SignUpLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.SignUpLastName.PlaceholderText = "Last Name";
            this.SignUpLastName.Size = new System.Drawing.Size(159, 34);
            this.SignUpLastName.TabIndex = 9;
            this.SignUpLastName.UnderlinedStyle = false;
            this.SignUpLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SignUpLastName_KeyPress);
            // 
            // SignUpPassword
            // 
            this.SignUpPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SignUpPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SignUpPassword.BackColor = System.Drawing.SystemColors.Control;
            this.SignUpPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.SignUpPassword.BorderFocusColor = System.Drawing.Color.Gray;
            this.SignUpPassword.BordesSize = 2;
            this.SignUpPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpPassword.Location = new System.Drawing.Point(8, 181);
            this.SignUpPassword.Margin = new System.Windows.Forms.Padding(4);
            this.SignUpPassword.MaxLength = 28;
            this.SignUpPassword.Multiline = false;
            this.SignUpPassword.Name = "SignUpPassword";
            this.SignUpPassword.Padding = new System.Windows.Forms.Padding(7);
            this.SignUpPassword.PasswordChar = true;
            this.SignUpPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.SignUpPassword.PlaceholderText = "Password";
            this.SignUpPassword.Size = new System.Drawing.Size(327, 34);
            this.SignUpPassword.TabIndex = 8;
            this.SignUpPassword.UnderlinedStyle = false;
            this.SignUpPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SignUpPassword_KeyPress);
            // 
            // SignUpFirstName
            // 
            this.SignUpFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SignUpFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SignUpFirstName.BackColor = System.Drawing.SystemColors.Control;
            this.SignUpFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.SignUpFirstName.BorderFocusColor = System.Drawing.Color.Gray;
            this.SignUpFirstName.BordesSize = 2;
            this.SignUpFirstName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpFirstName.Location = new System.Drawing.Point(8, 97);
            this.SignUpFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.SignUpFirstName.MaxLength = 50;
            this.SignUpFirstName.Multiline = false;
            this.SignUpFirstName.Name = "SignUpFirstName";
            this.SignUpFirstName.Padding = new System.Windows.Forms.Padding(7);
            this.SignUpFirstName.PasswordChar = false;
            this.SignUpFirstName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.SignUpFirstName.PlaceholderText = "First Name";
            this.SignUpFirstName.Size = new System.Drawing.Size(161, 34);
            this.SignUpFirstName.TabIndex = 7;
            this.SignUpFirstName.UnderlinedStyle = false;
            this.SignUpFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SignUpFirstName_KeyPress);
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.Color.White;
            this.SignUpButton.Location = new System.Drawing.Point(8, 232);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(327, 39);
            this.SignUpButton.TabIndex = 6;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            this.SignUpButton.MouseLeave += new System.EventHandler(this.SignUpButton_MouseLeave);
            this.SignUpButton.MouseHover += new System.EventHandler(this.SignUpButton_MouseHover);
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.SignUpLabel.Location = new System.Drawing.Point(133, 11);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(71, 22);
            this.SignUpLabel.TabIndex = 4;
            this.SignUpLabel.Text = "Sign Up";
            // 
            // SignInLinkLabel
            // 
            this.SignInLinkLabel.AutoSize = true;
            this.SignInLinkLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInLinkLabel.Location = new System.Drawing.Point(240, 307);
            this.SignInLinkLabel.Name = "SignInLinkLabel";
            this.SignInLinkLabel.Size = new System.Drawing.Size(70, 26);
            this.SignInLinkLabel.TabIndex = 1;
            this.SignInLinkLabel.TabStop = true;
            this.SignInLinkLabel.Text = "Sign In";
            this.SignInLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignInLinkLabel_LinkClicked);
            // 
            // InviteToSignInLabel
            // 
            this.InviteToSignInLabel.AutoSize = true;
            this.InviteToSignInLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InviteToSignInLabel.Location = new System.Drawing.Point(26, 307);
            this.InviteToSignInLabel.Name = "InviteToSignInLabel";
            this.InviteToSignInLabel.Size = new System.Drawing.Size(208, 26);
            this.InviteToSignInLabel.TabIndex = 1;
            this.InviteToSignInLabel.Text = "Have account already?";
            // 
            // VerificationPanel
            // 
            this.VerificationPanel.Controls.Add(this.VerificationExplainLabel);
            this.VerificationPanel.Controls.Add(this.VerifyButton);
            this.VerificationPanel.Controls.Add(this.VerificationCode);
            this.VerificationPanel.Controls.Add(this.VerificationLabel);
            this.VerificationPanel.Location = new System.Drawing.Point(706, 12);
            this.VerificationPanel.Name = "VerificationPanel";
            this.VerificationPanel.Size = new System.Drawing.Size(581, 343);
            this.VerificationPanel.TabIndex = 2;
            this.VerificationPanel.Visible = false;
            // 
            // VerificationExplainLabel
            // 
            this.VerificationExplainLabel.AutoSize = true;
            this.VerificationExplainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerificationExplainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.VerificationExplainLabel.Location = new System.Drawing.Point(8, 44);
            this.VerificationExplainLabel.Name = "VerificationExplainLabel";
            this.VerificationExplainLabel.Size = new System.Drawing.Size(306, 64);
            this.VerificationExplainLabel.TabIndex = 11;
            this.VerificationExplainLabel.Text = "Thanks for signing up!\r\nWe send an email to you with verification code and\r\nverif" +
    "ication bar code!\r\nUse them to verify your account.";
            // 
            // VerifyButton
            // 
            this.VerifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.VerifyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VerifyButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyButton.ForeColor = System.Drawing.Color.White;
            this.VerifyButton.Location = new System.Drawing.Point(8, 191);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Size = new System.Drawing.Size(327, 39);
            this.VerifyButton.TabIndex = 8;
            this.VerifyButton.Text = "Verify";
            this.VerifyButton.UseVisualStyleBackColor = false;
            this.VerifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // VerificationCode
            // 
            this.VerificationCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.VerificationCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.VerificationCode.BackColor = System.Drawing.SystemColors.Control;
            this.VerificationCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.VerificationCode.BorderFocusColor = System.Drawing.Color.Gray;
            this.VerificationCode.BordesSize = 2;
            this.VerificationCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerificationCode.Location = new System.Drawing.Point(8, 139);
            this.VerificationCode.Margin = new System.Windows.Forms.Padding(4);
            this.VerificationCode.MaxLength = 6;
            this.VerificationCode.Multiline = false;
            this.VerificationCode.Name = "VerificationCode";
            this.VerificationCode.Padding = new System.Windows.Forms.Padding(7);
            this.VerificationCode.PasswordChar = false;
            this.VerificationCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.VerificationCode.PlaceholderText = "Verification code";
            this.VerificationCode.Size = new System.Drawing.Size(327, 34);
            this.VerificationCode.TabIndex = 7;
            this.VerificationCode.UnderlinedStyle = true;
            // 
            // VerificationLabel
            // 
            this.VerificationLabel.AutoSize = true;
            this.VerificationLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerificationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.VerificationLabel.Location = new System.Drawing.Point(133, 11);
            this.VerificationLabel.Name = "VerificationLabel";
            this.VerificationLabel.Size = new System.Drawing.Size(102, 22);
            this.VerificationLabel.TabIndex = 4;
            this.VerificationLabel.Text = "Verification";
            // 
            // QrcodePanel
            // 
            this.QrcodePanel.Controls.Add(this.SignInManuallyLinkLabel);
            this.QrcodePanel.Controls.Add(this.QrcodeStart);
            this.QrcodePanel.Controls.Add(this.QrcodeCameraPresent);
            this.QrcodePanel.Controls.Add(this.verifyQrcodePicturebox);
            this.QrcodePanel.Controls.Add(this.QrcodeFilePicturebox);
            this.QrcodePanel.Controls.Add(this.QrcodeFile);
            this.QrcodePanel.Controls.Add(this.QrcodeWebcamPicturebox);
            this.QrcodePanel.Controls.Add(this.QrCodeWebcam);
            this.QrcodePanel.Controls.Add(this.QrcodeSigninLabel);
            this.QrcodePanel.Controls.Add(this.QrcodeMakePicturebox);
            this.QrcodePanel.Location = new System.Drawing.Point(1053, 12);
            this.QrcodePanel.Name = "QrcodePanel";
            this.QrcodePanel.Size = new System.Drawing.Size(341, 343);
            this.QrcodePanel.TabIndex = 4;
            this.QrcodePanel.Visible = false;
            // 
            // SignInManuallyLinkLabel
            // 
            this.SignInManuallyLinkLabel.AutoSize = true;
            this.SignInManuallyLinkLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInManuallyLinkLabel.Location = new System.Drawing.Point(210, 316);
            this.SignInManuallyLinkLabel.Name = "SignInManuallyLinkLabel";
            this.SignInManuallyLinkLabel.Size = new System.Drawing.Size(122, 19);
            this.SignInManuallyLinkLabel.TabIndex = 5;
            this.SignInManuallyLinkLabel.TabStop = true;
            this.SignInManuallyLinkLabel.Text = "Sign In manually?";
            this.SignInManuallyLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignInManuallyLinkLabel_LinkClicked);
            // 
            // QrcodeStart
            // 
            this.QrcodeStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.QrcodeStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QrcodeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QrcodeStart.ForeColor = System.Drawing.Color.White;
            this.QrcodeStart.Location = new System.Drawing.Point(197, 36);
            this.QrcodeStart.Name = "QrcodeStart";
            this.QrcodeStart.Size = new System.Drawing.Size(99, 23);
            this.QrcodeStart.TabIndex = 11;
            this.QrcodeStart.Text = "Start Camera";
            this.QrcodeStart.UseVisualStyleBackColor = false;
            this.QrcodeStart.Visible = false;
            this.QrcodeStart.Click += new System.EventHandler(this.QrcodeStart_Click);
            // 
            // QrcodeCameraPresent
            // 
            this.QrcodeCameraPresent.FormattingEnabled = true;
            this.QrcodeCameraPresent.Location = new System.Drawing.Point(31, 38);
            this.QrcodeCameraPresent.Name = "QrcodeCameraPresent";
            this.QrcodeCameraPresent.Size = new System.Drawing.Size(148, 21);
            this.QrcodeCameraPresent.TabIndex = 5;
            this.QrcodeCameraPresent.Visible = false;
            // 
            // verifyQrcodePicturebox
            // 
            this.verifyQrcodePicturebox.BackColor = System.Drawing.Color.Transparent;
            this.verifyQrcodePicturebox.Location = new System.Drawing.Point(54, 36);
            this.verifyQrcodePicturebox.Name = "verifyQrcodePicturebox";
            this.verifyQrcodePicturebox.Size = new System.Drawing.Size(230, 197);
            this.verifyQrcodePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.verifyQrcodePicturebox.TabIndex = 16;
            this.verifyQrcodePicturebox.TabStop = false;
            // 
            // QrcodeFilePicturebox
            // 
            this.QrcodeFilePicturebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.QrcodeFilePicturebox.Image = ((System.Drawing.Image)(resources.GetObject("QrcodeFilePicturebox.Image")));
            this.QrcodeFilePicturebox.Location = new System.Drawing.Point(13, 238);
            this.QrcodeFilePicturebox.Name = "QrcodeFilePicturebox";
            this.QrcodeFilePicturebox.Size = new System.Drawing.Size(49, 30);
            this.QrcodeFilePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QrcodeFilePicturebox.TabIndex = 15;
            this.QrcodeFilePicturebox.TabStop = false;
            this.QrcodeFilePicturebox.Click += new System.EventHandler(this.QrcodeFilePicturebox_Click);
            // 
            // QrcodeFile
            // 
            this.QrcodeFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.QrcodeFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QrcodeFile.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QrcodeFile.ForeColor = System.Drawing.Color.White;
            this.QrcodeFile.Location = new System.Drawing.Point(8, 234);
            this.QrcodeFile.Name = "QrcodeFile";
            this.QrcodeFile.Size = new System.Drawing.Size(327, 39);
            this.QrcodeFile.TabIndex = 14;
            this.QrcodeFile.Text = "Verify qr code by file";
            this.QrcodeFile.UseVisualStyleBackColor = false;
            this.QrcodeFile.Click += new System.EventHandler(this.QrcodeFile_Click);
            // 
            // QrcodeWebcamPicturebox
            // 
            this.QrcodeWebcamPicturebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.QrcodeWebcamPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("QrcodeWebcamPicturebox.Image")));
            this.QrcodeWebcamPicturebox.Location = new System.Drawing.Point(13, 278);
            this.QrcodeWebcamPicturebox.Name = "QrcodeWebcamPicturebox";
            this.QrcodeWebcamPicturebox.Size = new System.Drawing.Size(49, 30);
            this.QrcodeWebcamPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QrcodeWebcamPicturebox.TabIndex = 13;
            this.QrcodeWebcamPicturebox.TabStop = false;
            this.QrcodeWebcamPicturebox.Click += new System.EventHandler(this.QrcodeWebcamPicturebox_Click);
            // 
            // QrCodeWebcam
            // 
            this.QrCodeWebcam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.QrCodeWebcam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QrCodeWebcam.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QrCodeWebcam.ForeColor = System.Drawing.Color.White;
            this.QrCodeWebcam.Location = new System.Drawing.Point(8, 274);
            this.QrCodeWebcam.Name = "QrCodeWebcam";
            this.QrCodeWebcam.Size = new System.Drawing.Size(327, 39);
            this.QrCodeWebcam.TabIndex = 10;
            this.QrCodeWebcam.Text = "Verify qr code by webcam";
            this.QrCodeWebcam.UseVisualStyleBackColor = false;
            this.QrCodeWebcam.Click += new System.EventHandler(this.QrCodeWebcam_Click);
            // 
            // QrcodeSigninLabel
            // 
            this.QrcodeSigninLabel.AutoSize = true;
            this.QrcodeSigninLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QrcodeSigninLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.QrcodeSigninLabel.Location = new System.Drawing.Point(90, 11);
            this.QrcodeSigninLabel.Name = "QrcodeSigninLabel";
            this.QrcodeSigninLabel.Size = new System.Drawing.Size(144, 22);
            this.QrcodeSigninLabel.TabIndex = 4;
            this.QrcodeSigninLabel.Text = "SignInByQrCode";
            // 
            // QrcodeMakePicturebox
            // 
            this.QrcodeMakePicturebox.BackColor = System.Drawing.Color.White;
            this.QrcodeMakePicturebox.Location = new System.Drawing.Point(54, 35);
            this.QrcodeMakePicturebox.Name = "QrcodeMakePicturebox";
            this.QrcodeMakePicturebox.Size = new System.Drawing.Size(230, 197);
            this.QrcodeMakePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.QrcodeMakePicturebox.TabIndex = 17;
            this.QrcodeMakePicturebox.TabStop = false;
            this.QrcodeMakePicturebox.Visible = false;
            // 
            // SignInUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 361);
            this.Controls.Add(this.QrcodePanel);
            this.Controls.Add(this.VerificationPanel);
            this.Controls.Add(this.SignUpPanel);
            this.Controls.Add(this.SignInPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignInUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignInUp";
            this.SignInPanel.ResumeLayout(false);
            this.SignInPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HidePasswordPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordPicture)).EndInit();
            this.SignUpPanel.ResumeLayout(false);
            this.SignUpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HidePasswordPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordPicture2)).EndInit();
            this.VerificationPanel.ResumeLayout(false);
            this.VerificationPanel.PerformLayout();
            this.QrcodePanel.ResumeLayout(false);
            this.QrcodePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verifyQrcodePicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QrcodeFilePicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QrcodeWebcamPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QrcodeMakePicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SignInPanel;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Label SignInLabel;
        private System.Windows.Forms.LinkLabel SignUpLinkLabel;
        private System.Windows.Forms.Label InviteToSignUpLabel;
        private CustomTextBox SignInPassword;
        private CustomTextBox SignInEmail;
        private System.Windows.Forms.Panel SignUpPanel;
        private CustomTextBox SignUpEmail;
        private CustomTextBox SignUpLastName;
        private CustomTextBox SignUpPassword;
        private CustomTextBox SignUpFirstName;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.LinkLabel SignInLinkLabel;
        private System.Windows.Forms.Label InviteToSignInLabel;
        private System.Windows.Forms.PictureBox ShowPasswordPicture;
        private System.Windows.Forms.PictureBox HidePasswordPicture;
        private System.Windows.Forms.PictureBox HidePasswordPicture2;
        private System.Windows.Forms.PictureBox ShowPasswordPicture2;
        private System.Windows.Forms.Panel VerificationPanel;
        private System.Windows.Forms.Button VerifyButton;
        private CustomTextBox VerificationCode;
        private System.Windows.Forms.Label VerificationLabel;
        private System.Windows.Forms.Panel QrcodePanel;
        private System.Windows.Forms.PictureBox QrcodeFilePicturebox;
        private System.Windows.Forms.Button QrcodeFile;
        private System.Windows.Forms.PictureBox QrcodeWebcamPicturebox;
        private System.Windows.Forms.Button QrCodeWebcam;
        private System.Windows.Forms.Label QrcodeSigninLabel;
        private System.Windows.Forms.Button SigninQrcodeButton;
        private System.Windows.Forms.Label VerificationExplainLabel;
        private System.Windows.Forms.PictureBox verifyQrcodePicturebox;
        private System.Windows.Forms.ComboBox QrcodeCameraPresent;
        private System.Windows.Forms.Button QrcodeStart;
        private System.Windows.Forms.LinkLabel SignInManuallyLinkLabel;
        private System.Windows.Forms.PictureBox QrcodeMakePicturebox;
    }
}