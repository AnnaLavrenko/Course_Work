using System.ComponentModel;

namespace SQLApp
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.userField = new System.Windows.Forms.TextBox();
            this.generalPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.singUp = new System.Windows.Forms.LinkLabel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LastNameField = new System.Windows.Forms.TextBox();
            this.firstNameField = new System.Windows.Forms.TextBox();
            this.CapsLockOntoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.generalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.passwordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordField.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.passwordField.Location = new System.Drawing.Point(92, 264);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(220, 20);
            this.passwordField.TabIndex = 4;
            this.passwordField.Text = "Password";
            this.passwordField.UseSystemPasswordChar = true;
            this.passwordField.Enter += new System.EventHandler(this.PasswordField_Enter);
            this.passwordField.Leave += new System.EventHandler(this.PasswordField_Leave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.buttonRegister.Location = new System.Drawing.Point(77, 310);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(220, 30);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "REGISTER";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // userField
            // 
            this.userField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.userField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userField.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.userField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.userField.Location = new System.Drawing.Point(92, 130);
            this.userField.Multiline = true;
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(220, 25);
            this.userField.TabIndex = 4;
            this.userField.Text = "User Name";
            this.userField.Enter += new System.EventHandler(this.UserField_Enter);
            this.userField.Leave += new System.EventHandler(this.UserField_Leave);
            // 
            // generalPanel
            // 
            this.generalPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.generalPanel.Controls.Add(this.pictureBox4);
            this.generalPanel.Controls.Add(this.pictureBox3);
            this.generalPanel.Controls.Add(this.pictureBox1);
            this.generalPanel.Controls.Add(this.panel4);
            this.generalPanel.Controls.Add(this.panel3);
            this.generalPanel.Controls.Add(this.panel2);
            this.generalPanel.Controls.Add(this.panel1);
            this.generalPanel.Controls.Add(this.pictureBox2);
            this.generalPanel.Controls.Add(this.panelHeader);
            this.generalPanel.Controls.Add(this.button1);
            this.generalPanel.Controls.Add(this.LastNameField);
            this.generalPanel.Controls.Add(this.firstNameField);
            this.generalPanel.Controls.Add(this.buttonRegister);
            this.generalPanel.Controls.Add(this.passwordField);
            this.generalPanel.Controls.Add(this.userField);
            this.generalPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.generalPanel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generalPanel.Location = new System.Drawing.Point(0, 0);
            this.generalPanel.Name = "generalPanel";
            this.generalPanel.Size = new System.Drawing.Size(374, 450);
            this.generalPanel.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SQLApp.Properties.Resources.user_5_32;
            this.pictureBox4.Location = new System.Drawing.Point(54, 208);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SQLApp.Properties.Resources.user_5_32;
            this.pictureBox3.Location = new System.Drawing.Point(54, 169);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SQLApp.Properties.Resources.lock_32;
            this.pictureBox1.Location = new System.Drawing.Point(54, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(54, 285);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 1);
            this.panel4.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(54, 241);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 1);
            this.panel3.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(54, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(54, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SQLApp.Properties.Resources.contacts_32;
            this.pictureBox2.Location = new System.Drawing.Point(54, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.singUp);
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.panelHeader.Location = new System.Drawing.Point(0, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(374, 100);
            this.panelHeader.TabIndex = 11;
            // 
            // singUp
            // 
            this.singUp.AutoSize = true;
            this.singUp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.singUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(46)))), ((int)(((byte)(85)))));
            this.singUp.Location = new System.Drawing.Point(313, 7);
            this.singUp.Name = "singUp";
            this.singUp.Size = new System.Drawing.Size(49, 17);
            this.singUp.TabIndex = 8;
            this.singUp.TabStop = true;
            this.singUp.Text = "Sing In";
            this.singUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SingUp_LinkClicked);
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(46)))), ((int)(((byte)(85)))));
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(374, 100);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Register Form";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(114, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "ProfessionalDebug";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LastNameField
            // 
            this.LastNameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.LastNameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameField.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.LastNameField.Location = new System.Drawing.Point(92, 217);
            this.LastNameField.Multiline = true;
            this.LastNameField.Name = "LastNameField";
            this.LastNameField.Size = new System.Drawing.Size(220, 25);
            this.LastNameField.TabIndex = 9;
            this.LastNameField.Text = "Last Name";
            this.LastNameField.Enter += new System.EventHandler(this.SecondNameField_Enter);
            this.LastNameField.Leave += new System.EventHandler(this.SecondNameField_Leave);
            // 
            // firstNameField
            // 
            this.firstNameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.firstNameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameField.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.firstNameField.Location = new System.Drawing.Point(92, 178);
            this.firstNameField.Multiline = true;
            this.firstNameField.Name = "firstNameField";
            this.firstNameField.Size = new System.Drawing.Size(220, 25);
            this.firstNameField.TabIndex = 7;
            this.firstNameField.Text = "First Name";
            this.firstNameField.Enter += new System.EventHandler(this.FirstNameField_Enter);
            this.firstNameField.Leave += new System.EventHandler(this.FirstNameField_Leave);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.generalPanel);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.generalPanel.ResumeLayout(false);
            this.generalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox firstNameField;
        private System.Windows.Forms.TextBox LastNameField;
        private System.Windows.Forms.Panel generalPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel singUp;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ToolTip CapsLockOntoolTip;
    }
}