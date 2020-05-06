namespace SQLApp
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
            this.authPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.shopLabel = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.LinkLabel();
            this.authPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // authPanel
            // 
            this.authPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.authPanel.Controls.Add(this.headerPanel);
            this.authPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authPanel.Location = new System.Drawing.Point(0, 0);
            this.authPanel.Name = "authPanel";
            this.authPanel.Size = new System.Drawing.Size(800, 450);
            this.authPanel.TabIndex = 1;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.headerPanel.Controls.Add(this.logOut);
            this.headerPanel.Controls.Add(this.shopLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 100);
            this.headerPanel.TabIndex = 0;
            // 
            // shopLabel
            // 
            this.shopLabel.BackColor = System.Drawing.Color.Aquamarine;
            this.shopLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shopLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopLabel.Location = new System.Drawing.Point(0, 0);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(800, 100);
            this.shopLabel.TabIndex = 0;
            this.shopLabel.Text = "Welcome to Candy Shop";
            this.shopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logOut
            // 
            this.logOut.AutoSize = true;
            this.logOut.BackColor = System.Drawing.Color.White;
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logOut.Location = new System.Drawing.Point(733, 9);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(61, 16);
            this.logOut.TabIndex = 9;
            this.logOut.TabStop = true;
            this.logOut.Text = "Log Out";
            this.logOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOut_LinkClicked);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.authPanel);
            this.Name = "Shop";
            this.Text = "Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Shop_FormClosed);
            this.authPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel authPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label shopLabel;
        private System.Windows.Forms.LinkLabel logOut;
    }
}