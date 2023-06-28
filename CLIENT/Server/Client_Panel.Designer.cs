namespace Server
{
    partial class Client_Panel
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
            this.Go = new System.Windows.Forms.Button();
            this.ToTextbox = new Server.CustomTextBox();
            this.FromTextbox = new Server.CustomTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Go
            // 
            this.Go.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Go.Location = new System.Drawing.Point(290, 89);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(200, 43);
            this.Go.TabIndex = 16;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = false;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // ToTextbox
            // 
            this.ToTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ToTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ToTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.ToTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.ToTextbox.BorderFocusColor = System.Drawing.Color.Gray;
            this.ToTextbox.BordesSize = 2;
            this.ToTextbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToTextbox.Location = new System.Drawing.Point(397, 13);
            this.ToTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.ToTextbox.MaxLength = 100;
            this.ToTextbox.Multiline = false;
            this.ToTextbox.Name = "ToTextbox";
            this.ToTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.ToTextbox.PasswordChar = false;
            this.ToTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ToTextbox.PlaceholderText = "To";
            this.ToTextbox.Size = new System.Drawing.Size(375, 34);
            this.ToTextbox.TabIndex = 1;
            this.ToTextbox.UnderlinedStyle = true;
            this.ToTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToTextbox_KeyPress);
            // 
            // FromTextbox
            // 
            this.FromTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.FromTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.FromTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.FromTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(54)))));
            this.FromTextbox.BorderFocusColor = System.Drawing.Color.Gray;
            this.FromTextbox.BordesSize = 2;
            this.FromTextbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromTextbox.Location = new System.Drawing.Point(13, 13);
            this.FromTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.FromTextbox.MaxLength = 100;
            this.FromTextbox.Multiline = false;
            this.FromTextbox.Name = "FromTextbox";
            this.FromTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.FromTextbox.PasswordChar = false;
            this.FromTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.FromTextbox.PlaceholderText = "From";
            this.FromTextbox.Size = new System.Drawing.Size(375, 34);
            this.FromTextbox.TabIndex = 0;
            this.FromTextbox.UnderlinedStyle = true;
            this.FromTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FromTextbox_KeyPress);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 152);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(376, 160);
            this.listBox1.TabIndex = 17;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(397, 152);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(375, 160);
            this.listBox2.TabIndex = 18;
            // 
            // Client_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 462);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.ToTextbox);
            this.Controls.Add(this.FromTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Client_Panel";
            this.Text = "Client_Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_Panel_FormClosing);
            this.Load += new System.EventHandler(this.Client_Panel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomTextBox FromTextbox;
        private CustomTextBox ToTextbox;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}