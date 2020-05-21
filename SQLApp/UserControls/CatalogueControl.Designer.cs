namespace SQLApp
{
    partial class CatalogueControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogueControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelShoppingCart = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.shoppingCartGrid = new System.Windows.Forms.DataGridView();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.itemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelShoppingCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buyButton);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(35, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 178);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(132, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "$";
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.Color.Black;
            this.buyButton.FlatAppearance.BorderSize = 0;
            this.buyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buyButton.Location = new System.Drawing.Point(3, 143);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(62, 25);
            this.buyButton.TabIndex = 3;
            this.buyButton.Text = "Add";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrice.AutoSize = true;
            this.labelPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelPrice.Location = new System.Drawing.Point(100, 143);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(36, 25);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "15";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item 1";
            // 
            // panelShoppingCart
            // 
            this.panelShoppingCart.Controls.Add(this.button3);
            this.panelShoppingCart.Controls.Add(this.shoppingCartGrid);
            this.panelShoppingCart.Controls.Add(this.labelTotalPrice);
            this.panelShoppingCart.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelShoppingCart.Location = new System.Drawing.Point(568, 0);
            this.panelShoppingCart.Name = "panelShoppingCart";
            this.panelShoppingCart.Size = new System.Drawing.Size(222, 415);
            this.panelShoppingCart.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSize = true;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(126, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "PROCESSED";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // shoppingCartGrid
            // 
            this.shoppingCartGrid.AllowUserToAddRows = false;
            this.shoppingCartGrid.AllowUserToDeleteRows = false;
            this.shoppingCartGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shoppingCartGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shoppingCartGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shoppingCartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shoppingCartGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemColumn,
            this.Price,
            this.RemoveColumn});
            this.shoppingCartGrid.Location = new System.Drawing.Point(3, 0);
            this.shoppingCartGrid.Name = "shoppingCartGrid";
            this.shoppingCartGrid.ReadOnly = true;
            this.shoppingCartGrid.RowHeadersVisible = false;
            this.shoppingCartGrid.Size = new System.Drawing.Size(208, 380);
            this.shoppingCartGrid.TabIndex = 0;
            this.shoppingCartGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShoppingCartGrid_CellClick);
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalPrice.Location = new System.Drawing.Point(3, 384);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(58, 19);
            this.labelTotalPrice.TabIndex = 1;
            this.labelTotalPrice.Text = "label6";
            // 
            // itemColumn
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.itemColumn.HeaderText = "Item";
            this.itemColumn.Name = "itemColumn";
            this.itemColumn.ReadOnly = true;
            // 
            // Price
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.DefaultCellStyle = dataGridViewCellStyle2;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // RemoveColumn
            // 
            this.RemoveColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.RemoveColumn.HeaderText = "";
            this.RemoveColumn.Name = "RemoveColumn";
            this.RemoveColumn.ReadOnly = true;
            this.RemoveColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RemoveColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CatalogueControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelShoppingCart);
            this.Controls.Add(this.panel1);
            this.Name = "CatalogueControl";
            this.Size = new System.Drawing.Size(790, 415);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelShoppingCart.ResumeLayout(false);
            this.panelShoppingCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Panel panelShoppingCart;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.DataGridView shoppingCartGrid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveColumn;
    }
}
