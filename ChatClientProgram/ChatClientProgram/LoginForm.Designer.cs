namespace ChatClientProgram
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
            this.enterUsername = new System.Windows.Forms.Button();
            this.enterServerName = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterUsername
            // 
            this.enterUsername.Location = new System.Drawing.Point(277, 85);
            this.enterUsername.Name = "enterUsername";
            this.enterUsername.Size = new System.Drawing.Size(75, 30);
            this.enterUsername.TabIndex = 0;
            this.enterUsername.Text = "Enter";
            this.enterUsername.UseVisualStyleBackColor = true;
            // 
            // enterServerName
            // 
            this.enterServerName.Location = new System.Drawing.Point(277, 135);
            this.enterServerName.Name = "enterServerName";
            this.enterServerName.Size = new System.Drawing.Size(75, 30);
            this.enterServerName.TabIndex = 1;
            this.enterServerName.Text = "Enter";
            this.enterServerName.UseVisualStyleBackColor = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(145, 86);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 26);
            this.textBoxUsername.TabIndex = 2;
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Location = new System.Drawing.Point(145, 135);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.Size = new System.Drawing.Size(100, 26);
            this.textBoxServerName.TabIndex = 3;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(23, 91);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(87, 20);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username:";
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Location = new System.Drawing.Point(23, 135);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(59, 20);
            this.serverNameLabel.TabIndex = 5;
            this.serverNameLabel.Text = "Server:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 239);
            this.Controls.Add(this.serverNameLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.textBoxServerName);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.enterServerName);
            this.Controls.Add(this.enterUsername);
            this.Name = "LoginForm";
            this.Text = "ChatClient";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterUsername;
        private System.Windows.Forms.Button enterServerName;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label serverNameLabel;
    }
}

