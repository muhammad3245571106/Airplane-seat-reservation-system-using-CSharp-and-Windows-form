namespace Server
{
    partial class Admin_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Panel));
            this.AdminButton = new System.Windows.Forms.Button();
            this.AdminBlockDropdown = new System.Windows.Forms.Panel();
            this.AdminBlcokVerifiedButton = new System.Windows.Forms.Button();
            this.AdminBlockPendingButton = new System.Windows.Forms.Button();
            this.AdminBlockButton = new System.Windows.Forms.Button();
            this.AdminUnblockButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AdminDropdown = new System.Windows.Forms.Panel();
            this.VerifyDropdown = new System.Windows.Forms.Panel();
            this.VerifyBlockedAdminButton = new System.Windows.Forms.Button();
            this.VerifyPendingAdminButton = new System.Windows.Forms.Button();
            this.VerifyAdminButton = new System.Windows.Forms.Button();
            this.AddToPendingDropdown = new System.Windows.Forms.Panel();
            this.AddVerifiedAdminToPendingButton = new System.Windows.Forms.Button();
            this.AddBlockedAdminToPendingButton = new System.Windows.Forms.Button();
            this.AddAdminToPendingButton = new System.Windows.Forms.Button();
            this.ClientDropdown = new System.Windows.Forms.Panel();
            this.ClientButton = new System.Windows.Forms.Button();
            this.ClientBlockButton = new System.Windows.Forms.Button();
            this.ClientUnblockButton = new System.Windows.Forms.Button();
            this.MianPanel = new System.Windows.Forms.Panel();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.VerifyBlockedAdminFormButton = new System.Windows.Forms.Button();
            this.PendingBlockedAdminFormButton = new System.Windows.Forms.Button();
            this.PendingVerifiedAdminFormButton = new System.Windows.Forms.Button();
            this.BlockClientFormButton = new System.Windows.Forms.Button();
            this.UnblockClientFormButton = new System.Windows.Forms.Button();
            this.BlockVerifiedAdminFormButton = new System.Windows.Forms.Button();
            this.BlockPendingAdminFormButton = new System.Windows.Forms.Button();
            this.VerifyPendingAdminFormButton = new System.Windows.Forms.Button();
            this.UnblockAdminFormButton = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.Minimize = new Server.CircularPictureBox();
            this.Close = new Server.CircularPictureBox();
            this.AdminBlockDropdown.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.AdminDropdown.SuspendLayout();
            this.VerifyDropdown.SuspendLayout();
            this.AddToPendingDropdown.SuspendLayout();
            this.ClientDropdown.SuspendLayout();
            this.MianPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.Color.Lime;
            this.AdminButton.Location = new System.Drawing.Point(0, 0);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(200, 53);
            this.AdminButton.TabIndex = 0;
            this.AdminButton.Text = "Admin";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // AdminBlockDropdown
            // 
            this.AdminBlockDropdown.Controls.Add(this.AdminBlcokVerifiedButton);
            this.AdminBlockDropdown.Controls.Add(this.AdminBlockPendingButton);
            this.AdminBlockDropdown.Controls.Add(this.AdminBlockButton);
            this.AdminBlockDropdown.Location = new System.Drawing.Point(0, 54);
            this.AdminBlockDropdown.MaximumSize = new System.Drawing.Size(200, 102);
            this.AdminBlockDropdown.MinimumSize = new System.Drawing.Size(200, 43);
            this.AdminBlockDropdown.Name = "AdminBlockDropdown";
            this.AdminBlockDropdown.Size = new System.Drawing.Size(200, 43);
            this.AdminBlockDropdown.TabIndex = 1;
            // 
            // AdminBlcokVerifiedButton
            // 
            this.AdminBlcokVerifiedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AdminBlcokVerifiedButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminBlcokVerifiedButton.Location = new System.Drawing.Point(0, 72);
            this.AdminBlcokVerifiedButton.Name = "AdminBlcokVerifiedButton";
            this.AdminBlcokVerifiedButton.Size = new System.Drawing.Size(200, 29);
            this.AdminBlcokVerifiedButton.TabIndex = 2;
            this.AdminBlcokVerifiedButton.Text = "Block Verified";
            this.AdminBlcokVerifiedButton.UseVisualStyleBackColor = false;
            this.AdminBlcokVerifiedButton.Click += new System.EventHandler(this.AdminBlcokVerifiedButton_Click);
            // 
            // AdminBlockPendingButton
            // 
            this.AdminBlockPendingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AdminBlockPendingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminBlockPendingButton.Location = new System.Drawing.Point(0, 43);
            this.AdminBlockPendingButton.Name = "AdminBlockPendingButton";
            this.AdminBlockPendingButton.Size = new System.Drawing.Size(200, 29);
            this.AdminBlockPendingButton.TabIndex = 1;
            this.AdminBlockPendingButton.Text = "Block Pending";
            this.AdminBlockPendingButton.UseVisualStyleBackColor = false;
            this.AdminBlockPendingButton.Click += new System.EventHandler(this.AdminBlockPendingButton_Click);
            // 
            // AdminBlockButton
            // 
            this.AdminBlockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AdminBlockButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminBlockButton.Location = new System.Drawing.Point(0, 0);
            this.AdminBlockButton.Name = "AdminBlockButton";
            this.AdminBlockButton.Size = new System.Drawing.Size(200, 43);
            this.AdminBlockButton.TabIndex = 0;
            this.AdminBlockButton.Text = "Block";
            this.AdminBlockButton.UseVisualStyleBackColor = false;
            this.AdminBlockButton.Click += new System.EventHandler(this.AdminBlockButton_Click);
            // 
            // AdminUnblockButton
            // 
            this.AdminUnblockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AdminUnblockButton.Location = new System.Drawing.Point(0, 97);
            this.AdminUnblockButton.Name = "AdminUnblockButton";
            this.AdminUnblockButton.Size = new System.Drawing.Size(200, 43);
            this.AdminUnblockButton.TabIndex = 2;
            this.AdminUnblockButton.Text = "Unblock";
            this.AdminUnblockButton.UseVisualStyleBackColor = false;
            this.AdminUnblockButton.Click += new System.EventHandler(this.AdminUnblockButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.AdminDropdown);
            this.flowLayoutPanel1.Controls.Add(this.ClientDropdown);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(205, 567);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // AdminDropdown
            // 
            this.AdminDropdown.Controls.Add(this.AdminButton);
            this.AdminDropdown.Controls.Add(this.VerifyDropdown);
            this.AdminDropdown.Controls.Add(this.AdminBlockDropdown);
            this.AdminDropdown.Controls.Add(this.AddToPendingDropdown);
            this.AdminDropdown.Controls.Add(this.AdminUnblockButton);
            this.AdminDropdown.Location = new System.Drawing.Point(3, 3);
            this.AdminDropdown.MaximumSize = new System.Drawing.Size(200, 228);
            this.AdminDropdown.MinimumSize = new System.Drawing.Size(200, 53);
            this.AdminDropdown.Name = "AdminDropdown";
            this.AdminDropdown.Size = new System.Drawing.Size(200, 53);
            this.AdminDropdown.TabIndex = 10;
            // 
            // VerifyDropdown
            // 
            this.VerifyDropdown.Controls.Add(this.VerifyBlockedAdminButton);
            this.VerifyDropdown.Controls.Add(this.VerifyPendingAdminButton);
            this.VerifyDropdown.Controls.Add(this.VerifyAdminButton);
            this.VerifyDropdown.Location = new System.Drawing.Point(0, 141);
            this.VerifyDropdown.MaximumSize = new System.Drawing.Size(200, 102);
            this.VerifyDropdown.MinimumSize = new System.Drawing.Size(200, 43);
            this.VerifyDropdown.Name = "VerifyDropdown";
            this.VerifyDropdown.Size = new System.Drawing.Size(200, 43);
            this.VerifyDropdown.TabIndex = 3;
            // 
            // VerifyBlockedAdminButton
            // 
            this.VerifyBlockedAdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.VerifyBlockedAdminButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.VerifyBlockedAdminButton.Location = new System.Drawing.Point(0, 72);
            this.VerifyBlockedAdminButton.Name = "VerifyBlockedAdminButton";
            this.VerifyBlockedAdminButton.Size = new System.Drawing.Size(200, 29);
            this.VerifyBlockedAdminButton.TabIndex = 2;
            this.VerifyBlockedAdminButton.Text = "Verify Blocked";
            this.VerifyBlockedAdminButton.UseVisualStyleBackColor = false;
            this.VerifyBlockedAdminButton.Click += new System.EventHandler(this.VerifyBlockedAdminButton_Click);
            // 
            // VerifyPendingAdminButton
            // 
            this.VerifyPendingAdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.VerifyPendingAdminButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.VerifyPendingAdminButton.Location = new System.Drawing.Point(0, 43);
            this.VerifyPendingAdminButton.Name = "VerifyPendingAdminButton";
            this.VerifyPendingAdminButton.Size = new System.Drawing.Size(200, 29);
            this.VerifyPendingAdminButton.TabIndex = 1;
            this.VerifyPendingAdminButton.Text = "Verify Pending";
            this.VerifyPendingAdminButton.UseVisualStyleBackColor = false;
            this.VerifyPendingAdminButton.Click += new System.EventHandler(this.VerifyPendingAdminButton_Click);
            // 
            // VerifyAdminButton
            // 
            this.VerifyAdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.VerifyAdminButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.VerifyAdminButton.Location = new System.Drawing.Point(0, 0);
            this.VerifyAdminButton.Name = "VerifyAdminButton";
            this.VerifyAdminButton.Size = new System.Drawing.Size(200, 43);
            this.VerifyAdminButton.TabIndex = 0;
            this.VerifyAdminButton.Text = "Verify";
            this.VerifyAdminButton.UseVisualStyleBackColor = false;
            this.VerifyAdminButton.Click += new System.EventHandler(this.VerifyAdminButton_Click);
            // 
            // AddToPendingDropdown
            // 
            this.AddToPendingDropdown.Controls.Add(this.AddVerifiedAdminToPendingButton);
            this.AddToPendingDropdown.Controls.Add(this.AddBlockedAdminToPendingButton);
            this.AddToPendingDropdown.Controls.Add(this.AddAdminToPendingButton);
            this.AddToPendingDropdown.Location = new System.Drawing.Point(0, 184);
            this.AddToPendingDropdown.MaximumSize = new System.Drawing.Size(200, 102);
            this.AddToPendingDropdown.MinimumSize = new System.Drawing.Size(200, 43);
            this.AddToPendingDropdown.Name = "AddToPendingDropdown";
            this.AddToPendingDropdown.Size = new System.Drawing.Size(200, 43);
            this.AddToPendingDropdown.TabIndex = 4;
            // 
            // AddVerifiedAdminToPendingButton
            // 
            this.AddVerifiedAdminToPendingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddVerifiedAdminToPendingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddVerifiedAdminToPendingButton.Location = new System.Drawing.Point(0, 72);
            this.AddVerifiedAdminToPendingButton.Name = "AddVerifiedAdminToPendingButton";
            this.AddVerifiedAdminToPendingButton.Size = new System.Drawing.Size(200, 29);
            this.AddVerifiedAdminToPendingButton.TabIndex = 2;
            this.AddVerifiedAdminToPendingButton.Text = "Add Verified To Pending";
            this.AddVerifiedAdminToPendingButton.UseVisualStyleBackColor = false;
            this.AddVerifiedAdminToPendingButton.Click += new System.EventHandler(this.AddVerifiedAdminToPendingButton_Click);
            // 
            // AddBlockedAdminToPendingButton
            // 
            this.AddBlockedAdminToPendingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddBlockedAdminToPendingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddBlockedAdminToPendingButton.Location = new System.Drawing.Point(0, 43);
            this.AddBlockedAdminToPendingButton.Name = "AddBlockedAdminToPendingButton";
            this.AddBlockedAdminToPendingButton.Size = new System.Drawing.Size(200, 29);
            this.AddBlockedAdminToPendingButton.TabIndex = 1;
            this.AddBlockedAdminToPendingButton.Text = "Add Blocked To Pending";
            this.AddBlockedAdminToPendingButton.UseVisualStyleBackColor = false;
            this.AddBlockedAdminToPendingButton.Click += new System.EventHandler(this.AddBlockedAdminToPendingButton_Click);
            // 
            // AddAdminToPendingButton
            // 
            this.AddAdminToPendingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddAdminToPendingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddAdminToPendingButton.Location = new System.Drawing.Point(0, 0);
            this.AddAdminToPendingButton.Name = "AddAdminToPendingButton";
            this.AddAdminToPendingButton.Size = new System.Drawing.Size(200, 43);
            this.AddAdminToPendingButton.TabIndex = 0;
            this.AddAdminToPendingButton.Text = "Add Admin To Pending";
            this.AddAdminToPendingButton.UseVisualStyleBackColor = false;
            this.AddAdminToPendingButton.Click += new System.EventHandler(this.AddAdminToPendingButton_Click);
            // 
            // ClientDropdown
            // 
            this.ClientDropdown.Controls.Add(this.ClientButton);
            this.ClientDropdown.Controls.Add(this.ClientBlockButton);
            this.ClientDropdown.Controls.Add(this.ClientUnblockButton);
            this.ClientDropdown.Location = new System.Drawing.Point(3, 62);
            this.ClientDropdown.MaximumSize = new System.Drawing.Size(200, 141);
            this.ClientDropdown.MinimumSize = new System.Drawing.Size(200, 53);
            this.ClientDropdown.Name = "ClientDropdown";
            this.ClientDropdown.Size = new System.Drawing.Size(200, 53);
            this.ClientDropdown.TabIndex = 0;
            // 
            // ClientButton
            // 
            this.ClientButton.BackColor = System.Drawing.Color.Lime;
            this.ClientButton.Location = new System.Drawing.Point(0, 0);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Size = new System.Drawing.Size(200, 53);
            this.ClientButton.TabIndex = 0;
            this.ClientButton.Text = "Client";
            this.ClientButton.UseVisualStyleBackColor = false;
            this.ClientButton.Click += new System.EventHandler(this.ClientButton_Click);
            // 
            // ClientBlockButton
            // 
            this.ClientBlockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientBlockButton.Location = new System.Drawing.Point(0, 54);
            this.ClientBlockButton.Name = "ClientBlockButton";
            this.ClientBlockButton.Size = new System.Drawing.Size(200, 43);
            this.ClientBlockButton.TabIndex = 1;
            this.ClientBlockButton.Text = "Block";
            this.ClientBlockButton.UseVisualStyleBackColor = false;
            this.ClientBlockButton.Click += new System.EventHandler(this.ClientBlockButton_Click);
            // 
            // ClientUnblockButton
            // 
            this.ClientUnblockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientUnblockButton.Location = new System.Drawing.Point(0, 97);
            this.ClientUnblockButton.Name = "ClientUnblockButton";
            this.ClientUnblockButton.Size = new System.Drawing.Size(200, 43);
            this.ClientUnblockButton.TabIndex = 2;
            this.ClientUnblockButton.Text = "Unblock";
            this.ClientUnblockButton.UseVisualStyleBackColor = false;
            this.ClientUnblockButton.Click += new System.EventHandler(this.ClientUnblockButton_Click);
            // 
            // MianPanel
            // 
            this.MianPanel.Controls.Add(this.SignOutButton);
            this.MianPanel.Controls.Add(this.VerifyBlockedAdminFormButton);
            this.MianPanel.Controls.Add(this.PendingBlockedAdminFormButton);
            this.MianPanel.Controls.Add(this.PendingVerifiedAdminFormButton);
            this.MianPanel.Controls.Add(this.BlockClientFormButton);
            this.MianPanel.Controls.Add(this.UnblockClientFormButton);
            this.MianPanel.Controls.Add(this.BlockVerifiedAdminFormButton);
            this.MianPanel.Controls.Add(this.BlockPendingAdminFormButton);
            this.MianPanel.Controls.Add(this.VerifyPendingAdminFormButton);
            this.MianPanel.Controls.Add(this.UnblockAdminFormButton);
            this.MianPanel.Controls.Add(this.ListBox);
            this.MianPanel.Location = new System.Drawing.Point(211, 57);
            this.MianPanel.Name = "MianPanel";
            this.MianPanel.Size = new System.Drawing.Size(558, 498);
            this.MianPanel.TabIndex = 0;
            // 
            // SignOutButton
            // 
            this.SignOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SignOutButton.Location = new System.Drawing.Point(159, 393);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(200, 43);
            this.SignOutButton.TabIndex = 15;
            this.SignOutButton.Text = "Sign Out";
            this.SignOutButton.UseVisualStyleBackColor = false;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // VerifyBlockedAdminFormButton
            // 
            this.VerifyBlockedAdminFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.VerifyBlockedAdminFormButton.Location = new System.Drawing.Point(159, 285);
            this.VerifyBlockedAdminFormButton.Name = "VerifyBlockedAdminFormButton";
            this.VerifyBlockedAdminFormButton.Size = new System.Drawing.Size(200, 43);
            this.VerifyBlockedAdminFormButton.TabIndex = 0;
            this.VerifyBlockedAdminFormButton.Text = "Verify Blocked Admin";
            this.VerifyBlockedAdminFormButton.UseVisualStyleBackColor = false;
            this.VerifyBlockedAdminFormButton.Visible = false;
            this.VerifyBlockedAdminFormButton.Click += new System.EventHandler(this.VerifyBlockedAdminFormButton_Click);
            // 
            // PendingBlockedAdminFormButton
            // 
            this.PendingBlockedAdminFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PendingBlockedAdminFormButton.Location = new System.Drawing.Point(159, 285);
            this.PendingBlockedAdminFormButton.Name = "PendingBlockedAdminFormButton";
            this.PendingBlockedAdminFormButton.Size = new System.Drawing.Size(200, 43);
            this.PendingBlockedAdminFormButton.TabIndex = 0;
            this.PendingBlockedAdminFormButton.Text = "Pending Blocked Admin";
            this.PendingBlockedAdminFormButton.UseVisualStyleBackColor = false;
            this.PendingBlockedAdminFormButton.Visible = false;
            this.PendingBlockedAdminFormButton.Click += new System.EventHandler(this.PendingBlockedAdminFormButton_Click);
            // 
            // PendingVerifiedAdminFormButton
            // 
            this.PendingVerifiedAdminFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PendingVerifiedAdminFormButton.Location = new System.Drawing.Point(159, 285);
            this.PendingVerifiedAdminFormButton.Name = "PendingVerifiedAdminFormButton";
            this.PendingVerifiedAdminFormButton.Size = new System.Drawing.Size(200, 43);
            this.PendingVerifiedAdminFormButton.TabIndex = 0;
            this.PendingVerifiedAdminFormButton.Text = "Pending Verified Admin";
            this.PendingVerifiedAdminFormButton.UseVisualStyleBackColor = false;
            this.PendingVerifiedAdminFormButton.Visible = false;
            this.PendingVerifiedAdminFormButton.Click += new System.EventHandler(this.PendingVerifiedAdminFormButton_Click);
            // 
            // BlockClientFormButton
            // 
            this.BlockClientFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BlockClientFormButton.Location = new System.Drawing.Point(159, 285);
            this.BlockClientFormButton.Name = "BlockClientFormButton";
            this.BlockClientFormButton.Size = new System.Drawing.Size(200, 43);
            this.BlockClientFormButton.TabIndex = 14;
            this.BlockClientFormButton.Text = "Block Client";
            this.BlockClientFormButton.UseVisualStyleBackColor = false;
            this.BlockClientFormButton.Visible = false;
            this.BlockClientFormButton.Click += new System.EventHandler(this.BlockClientFormButton_Click);
            // 
            // UnblockClientFormButton
            // 
            this.UnblockClientFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.UnblockClientFormButton.Location = new System.Drawing.Point(159, 285);
            this.UnblockClientFormButton.Name = "UnblockClientFormButton";
            this.UnblockClientFormButton.Size = new System.Drawing.Size(200, 43);
            this.UnblockClientFormButton.TabIndex = 0;
            this.UnblockClientFormButton.Text = "Unblock Client";
            this.UnblockClientFormButton.UseVisualStyleBackColor = false;
            this.UnblockClientFormButton.Visible = false;
            this.UnblockClientFormButton.Click += new System.EventHandler(this.UnblockClientFormButton_Click);
            // 
            // BlockVerifiedAdminFormButton
            // 
            this.BlockVerifiedAdminFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BlockVerifiedAdminFormButton.Location = new System.Drawing.Point(159, 285);
            this.BlockVerifiedAdminFormButton.Name = "BlockVerifiedAdminFormButton";
            this.BlockVerifiedAdminFormButton.Size = new System.Drawing.Size(200, 43);
            this.BlockVerifiedAdminFormButton.TabIndex = 0;
            this.BlockVerifiedAdminFormButton.Text = "Block Verified Admin";
            this.BlockVerifiedAdminFormButton.UseVisualStyleBackColor = false;
            this.BlockVerifiedAdminFormButton.Visible = false;
            this.BlockVerifiedAdminFormButton.Click += new System.EventHandler(this.BlockVerifiedAdminFormButton_Click);
            // 
            // BlockPendingAdminFormButton
            // 
            this.BlockPendingAdminFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BlockPendingAdminFormButton.Location = new System.Drawing.Point(159, 285);
            this.BlockPendingAdminFormButton.Name = "BlockPendingAdminFormButton";
            this.BlockPendingAdminFormButton.Size = new System.Drawing.Size(200, 43);
            this.BlockPendingAdminFormButton.TabIndex = 0;
            this.BlockPendingAdminFormButton.Text = "Block Pending Admin";
            this.BlockPendingAdminFormButton.UseVisualStyleBackColor = false;
            this.BlockPendingAdminFormButton.Visible = false;
            this.BlockPendingAdminFormButton.Click += new System.EventHandler(this.BlockPendingAdminFormButton_Click);
            // 
            // VerifyPendingAdminFormButton
            // 
            this.VerifyPendingAdminFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.VerifyPendingAdminFormButton.Location = new System.Drawing.Point(159, 285);
            this.VerifyPendingAdminFormButton.Name = "VerifyPendingAdminFormButton";
            this.VerifyPendingAdminFormButton.Size = new System.Drawing.Size(200, 43);
            this.VerifyPendingAdminFormButton.TabIndex = 0;
            this.VerifyPendingAdminFormButton.Text = "Verify Pending Admin";
            this.VerifyPendingAdminFormButton.UseVisualStyleBackColor = false;
            this.VerifyPendingAdminFormButton.Visible = false;
            this.VerifyPendingAdminFormButton.Click += new System.EventHandler(this.VerifyPendingAdminFormButton_Click);
            // 
            // UnblockAdminFormButton
            // 
            this.UnblockAdminFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.UnblockAdminFormButton.Location = new System.Drawing.Point(159, 285);
            this.UnblockAdminFormButton.Name = "UnblockAdminFormButton";
            this.UnblockAdminFormButton.Size = new System.Drawing.Size(200, 43);
            this.UnblockAdminFormButton.TabIndex = 0;
            this.UnblockAdminFormButton.Text = "Unblock Admin";
            this.UnblockAdminFormButton.UseVisualStyleBackColor = false;
            this.UnblockAdminFormButton.Visible = false;
            this.UnblockAdminFormButton.Click += new System.EventHandler(this.UnblockAdminFormButton_Click);
            // 
            // ListBox
            // 
            this.ListBox.BackColor = System.Drawing.Color.Lime;
            this.ListBox.ForeColor = System.Drawing.Color.DimGray;
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 18;
            this.ListBox.Location = new System.Drawing.Point(3, 3);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(552, 256);
            this.ListBox.TabIndex = 0;
            this.ListBox.Visible = false;
            // 
            // Minimize
            // 
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(708, 3);
            this.Minimize.Margin = new System.Windows.Forms.Padding(4);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(27, 23);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize.TabIndex = 11;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Close
            // 
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(743, 3);
            this.Close.Margin = new System.Windows.Forms.Padding(4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(27, 23);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 0;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(772, 567);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.MianPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Admin_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Panel";
            this.AdminBlockDropdown.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.AdminDropdown.ResumeLayout(false);
            this.VerifyDropdown.ResumeLayout(false);
            this.AddToPendingDropdown.ResumeLayout(false);
            this.ClientDropdown.ResumeLayout(false);
            this.MianPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CircularPictureBox Close;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Panel AdminBlockDropdown;
        private System.Windows.Forms.Button AdminBlockPendingButton;
        private System.Windows.Forms.Button AdminBlockButton;
        private System.Windows.Forms.Button AdminUnblockButton;
        private System.Windows.Forms.Button AdminBlcokVerifiedButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel AdminDropdown;
        private System.Windows.Forms.Panel ClientDropdown;
        private System.Windows.Forms.Button ClientButton;
        private System.Windows.Forms.Button ClientBlockButton;
        private System.Windows.Forms.Button ClientUnblockButton;
        private System.Windows.Forms.Panel MianPanel;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button UnblockAdminFormButton;
        private System.Windows.Forms.Button VerifyPendingAdminFormButton;
        private CircularPictureBox Minimize;
        private System.Windows.Forms.Button BlockVerifiedAdminFormButton;
        private System.Windows.Forms.Button BlockPendingAdminFormButton;
        private System.Windows.Forms.Button BlockClientFormButton;
        private System.Windows.Forms.Button UnblockClientFormButton;
        private System.Windows.Forms.Panel AddToPendingDropdown;
        private System.Windows.Forms.Button AddVerifiedAdminToPendingButton;
        private System.Windows.Forms.Button AddBlockedAdminToPendingButton;
        private System.Windows.Forms.Button AddAdminToPendingButton;
        private System.Windows.Forms.Button PendingBlockedAdminFormButton;
        private System.Windows.Forms.Button PendingVerifiedAdminFormButton;
        private System.Windows.Forms.Panel VerifyDropdown;
        private System.Windows.Forms.Button VerifyBlockedAdminButton;
        private System.Windows.Forms.Button VerifyPendingAdminButton;
        private System.Windows.Forms.Button VerifyAdminButton;
        private System.Windows.Forms.Button VerifyBlockedAdminFormButton;
        private System.Windows.Forms.Button SignOutButton;
    }
}