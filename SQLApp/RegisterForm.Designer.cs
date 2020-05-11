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
            this.passwordField = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.userField = new System.Windows.Forms.TextBox();
            this.generalPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.secondNameField = new System.Windows.Forms.TextBox();
            this.firstNameField = new System.Windows.Forms.TextBox();
            this.singUp = new System.Windows.Forms.LinkLabel();
            this.generalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordField
            // 
            this.passwordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordField.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordField.Location = new System.Drawing.Point(77, 261);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(220, 20);
            this.passwordField.TabIndex = 4;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Gray;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRegister.Location = new System.Drawing.Point(77, 287);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(220, 30);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "REGISTER";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // userField
            // 
            this.userField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userField.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userField.Location = new System.Drawing.Point(77, 130);
            this.userField.Multiline = true;
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(220, 26);
            this.userField.TabIndex = 4;
            this.userField.Enter += new System.EventHandler(this.UserField_Enter);
            this.userField.Leave += new System.EventHandler(this.UserField_Leave);
            // 
            // generalPanel
            // 
            this.generalPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.generalPanel.Controls.Add(this.singUp);
            this.generalPanel.Controls.Add(this.button1);
            this.generalPanel.Controls.Add(this.secondNameField);
            this.generalPanel.Controls.Add(this.firstNameField);
            this.generalPanel.Controls.Add(this.buttonRegister);
            this.generalPanel.Controls.Add(this.passwordField);
            this.generalPanel.Controls.Add(this.userField);
            this.generalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalPanel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generalPanel.Location = new System.Drawing.Point(0, 0);
            this.generalPanel.Name = "generalPanel";
            this.generalPanel.Size = new System.Drawing.Size(374, 450);
            this.generalPanel.TabIndex = 1;
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
            // secondNameField
            // 
            this.secondNameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondNameField.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNameField.Location = new System.Drawing.Point(77, 208);
            this.secondNameField.Multiline = true;
            this.secondNameField.Name = "secondNameField";
            this.secondNameField.Size = new System.Drawing.Size(220, 26);
            this.secondNameField.TabIndex = 9;
            this.secondNameField.Enter += new System.EventHandler(this.SecondNameField_Enter);
            this.secondNameField.Leave += new System.EventHandler(this.SecondNameField_Leave);
            // 
            // firstNameField
            // 
            this.firstNameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameField.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameField.Location = new System.Drawing.Point(77, 169);
            this.firstNameField.Multiline = true;
            this.firstNameField.Name = "firstNameField";
            this.firstNameField.Size = new System.Drawing.Size(220, 26);
            this.firstNameField.TabIndex = 7;
            this.firstNameField.Enter += new System.EventHandler(this.FirstNameField_Enter);
            this.firstNameField.Leave += new System.EventHandler(this.FirstNameField_Leave);
            // 
            // singUp
            // 
            this.singUp.AutoSize = true;
            this.singUp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.singUp.Location = new System.Drawing.Point(158, 355);
            this.singUp.Name = "singUp";
            this.singUp.Size = new System.Drawing.Size(49, 17);
            this.singUp.TabIndex = 8;
            this.singUp.TabStop = true;
            this.singUp.Text = "Sing In";
            this.singUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SingUp_LinkClicked);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox firstNameField;
        private System.Windows.Forms.TextBox secondNameField;
        private System.Windows.Forms.Panel generalPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel singUp;
    }
}