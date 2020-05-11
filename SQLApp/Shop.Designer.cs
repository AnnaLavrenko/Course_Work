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
            this.catalogueButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.welcomeMessageLabel = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.scButton = new System.Windows.Forms.Button();
            this.catalogueControl1 = new SQLApp.CatalogueControl();
            this.shoppingCartControl1 = new SQLApp.ShoppingCartControl();
            this.headerPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // catalogueButton
            // 
            this.catalogueButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.catalogueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catalogueButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.catalogueButton.Location = new System.Drawing.Point(0, 47);
            this.catalogueButton.Name = "catalogueButton";
            this.catalogueButton.Size = new System.Drawing.Size(120, 30);
            this.catalogueButton.TabIndex = 0;
            this.catalogueButton.Text = "Catalogue";
            this.catalogueButton.UseVisualStyleBackColor = false;
            this.catalogueButton.Click += new System.EventHandler(this.CatalogueButton_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.welcomeMessageLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.welcomeMessageLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeMessageLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.welcomeMessageLabel.Location = new System.Drawing.Point(126, 4);
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Size = new System.Drawing.Size(159, 17);
            this.welcomeMessageLabel.TabIndex = 0;
            this.welcomeMessageLabel.Text = "Welcome to the Jungle";
            // 
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.scButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 41);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(120, 488);
            this.sidePanel.TabIndex = 5;
            // 
            // scButton
            // 
            this.scButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.scButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scButton.Location = new System.Drawing.Point(0, 42);
            this.scButton.Name = "scButton";
            this.scButton.Size = new System.Drawing.Size(120, 30);
            this.scButton.TabIndex = 7;
            this.scButton.Text = "Shopping Cart";
            this.scButton.UseVisualStyleBackColor = false;
            this.scButton.Click += new System.EventHandler(this.ScButton_Click);
            // 
            // catalogueControl1
            // 
            this.catalogueControl1.Location = new System.Drawing.Point(123, 47);
            this.catalogueControl1.Name = "catalogueControl1";
            this.catalogueControl1.Size = new System.Drawing.Size(790, 415);
            this.catalogueControl1.TabIndex = 6;
            this.catalogueControl1.Load += new System.EventHandler(this.CatalogueControl1_Load);
            // 
            // shoppingCartControl1
            // 
            this.shoppingCartControl1.Location = new System.Drawing.Point(123, 47);
            this.shoppingCartControl1.Name = "shoppingCartControl1";
            this.shoppingCartControl1.Size = new System.Drawing.Size(790, 415);
            this.shoppingCartControl1.TabIndex = 7;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 529);
            this.Controls.Add(this.shoppingCartControl1);
            this.Controls.Add(this.catalogueControl1);
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label welcomeMessageLabel;
        private System.Windows.Forms.Panel sidePanel;
        private CatalogueControl catalogueControl1;
        private System.Windows.Forms.Button scButton;
        private ShoppingCartControl shoppingCartControl1;
    }
}