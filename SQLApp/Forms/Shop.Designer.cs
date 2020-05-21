﻿namespace SQLApp
{
    partial class Shop
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.welcomeMessageLabel = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.aboutButton = new System.Windows.Forms.Button();
            this.catalogueButton = new System.Windows.Forms.Button();
            this.catalogueControl1 = new SQLApp.CatalogueControl();
            this.about1 = new SQLApp.About();
            this.headerPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.headerPanel.Controls.Add(this.welcomeMessageLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(918, 41);
            this.headerPanel.TabIndex = 4;
            // 
            // welcomeMessageLabel
            // 
            this.welcomeMessageLabel.AutoSize = true;
            this.welcomeMessageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.welcomeMessageLabel.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.welcomeMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.welcomeMessageLabel.Location = new System.Drawing.Point(126, 4);
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Size = new System.Drawing.Size(373, 30);
            this.welcomeMessageLabel.TabIndex = 0;
            this.welcomeMessageLabel.Text = "Welcome to the Custom Shop";
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.sidePanel.Controls.Add(this.aboutButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 41);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(120, 488);
            this.sidePanel.TabIndex = 5;
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.aboutButton.Image = global::SQLApp.Properties.Resources.info_2_16;
            this.aboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.Location = new System.Drawing.Point(0, 38);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.aboutButton.Size = new System.Drawing.Size(120, 30);
            this.aboutButton.TabIndex = 7;
            this.aboutButton.Text = " About";
            this.aboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // catalogueButton
            // 
            this.catalogueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.catalogueButton.FlatAppearance.BorderSize = 0;
            this.catalogueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catalogueButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.catalogueButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.catalogueButton.Image = global::SQLApp.Properties.Resources.shopping_cart_16;
            this.catalogueButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.catalogueButton.Location = new System.Drawing.Point(0, 47);
            this.catalogueButton.Name = "catalogueButton";
            this.catalogueButton.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.catalogueButton.Size = new System.Drawing.Size(120, 30);
            this.catalogueButton.TabIndex = 0;
            this.catalogueButton.Text = " Catalogue";
            this.catalogueButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.catalogueButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.catalogueButton.UseVisualStyleBackColor = false;
            this.catalogueButton.Click += new System.EventHandler(this.CatalogueButton_Click);
            // 
            // catalogueControl1
            // 
            this.catalogueControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.catalogueControl1.Location = new System.Drawing.Point(123, 47);
            this.catalogueControl1.Name = "catalogueControl1";
            this.catalogueControl1.Size = new System.Drawing.Size(790, 415);
            this.catalogueControl1.Summ = 0;
            this.catalogueControl1.TabIndex = 6;
            this.catalogueControl1.Load += new System.EventHandler(this.CatalogueControl1_Load);
            // 
            // about1
            // 
            this.about1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.about1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.about1.Location = new System.Drawing.Point(123, 47);
            this.about1.Name = "about1";
            this.about1.Size = new System.Drawing.Size(790, 415);
            this.about1.TabIndex = 7;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(918, 529);
            this.Controls.Add(this.catalogueControl1);
            this.Controls.Add(this.about1);
            this.Controls.Add(this.catalogueButton);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "Shop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Shop_FormClosed);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button catalogueButton;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label welcomeMessageLabel;
        private System.Windows.Forms.Panel sidePanel;
        private CatalogueControl catalogueControl1;
        private System.Windows.Forms.Button aboutButton;
        private About about1;
    }
}