namespace SQLApp
{
    partial class AuthForm
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
            this.authPanel = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.userField = new System.Windows.Forms.TextBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.authLabel = new System.Windows.Forms.Label();
            this.singUp = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.authPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // authPanel
            // 
            this.authPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.authPanel.Controls.Add(this.buttonLogin);
            this.authPanel.Controls.Add(this.passwordField);
            this.authPanel.Controls.Add(this.userField);
            this.authPanel.Controls.Add(this.pictureBox2);
            this.authPanel.Controls.Add(this.pictureBox1);
            this.authPanel.Controls.Add(this.headerPanel);
            this.authPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authPanel.Location = new System.Drawing.Point(0, 0);
            this.authPanel.Name = "authPanel";
            this.authPanel.Size = new System.Drawing.Size(354, 446);
            this.authPanel.TabIndex = 0;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Gray;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLogin.Location = new System.Drawing.Point(77, 200);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(220, 30);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Sing In";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // passwordField
            // 
            this.passwordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordField.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordField.Location = new System.Drawing.Point(77, 168);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(220, 19);
            this.passwordField.TabIndex = 4;
            this.passwordField.UseSystemPasswordChar = true;
            this.passwordField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // userField
            // 
            this.userField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userField.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userField.Location = new System.Drawing.Point(77, 130);
            this.userField.Multiline = true;
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(220, 26);
            this.userField.TabIndex = 4;
            this.userField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.headerPanel.Controls.Add(this.singUp);
            this.headerPanel.Controls.Add(this.authLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(354, 100);
            this.headerPanel.TabIndex = 0;
            // 
            // authLabel
            // 
            this.authLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.authLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authLabel.Location = new System.Drawing.Point(0, 0);
            this.authLabel.Name = "authLabel";
            this.authLabel.Size = new System.Drawing.Size(354, 100);
            this.authLabel.TabIndex = 0;
            this.authLabel.Text = "Authentication Form";
            this.authLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.authLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.authLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // singUp
            // 
            this.singUp.AutoSize = true;
            this.singUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.singUp.Location = new System.Drawing.Point(291, 9);
            this.singUp.Name = "singUp";
            this.singUp.Size = new System.Drawing.Size(60, 16);
            this.singUp.TabIndex = 7;
            this.singUp.TabStop = true;
            this.singUp.Text = "Sing up";
            this.singUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SingUp_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SQLApp.Properties.Resources.iconfinder_user_1608727;
            this.pictureBox2.Location = new System.Drawing.Point(39, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SQLApp.Properties.Resources.password;
            this.pictureBox1.Location = new System.Drawing.Point(39, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 446);
            this.Controls.Add(this.authPanel);
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthForm_FormClosed);
            this.authPanel.ResumeLayout(false);
            this.authPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel authPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label authLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.LinkLabel singUp;
    }
}