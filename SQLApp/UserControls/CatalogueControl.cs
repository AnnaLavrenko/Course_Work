﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLApp
{
    public partial class CatalogueControl : UserControl
    {
        private ShoppingCart _shoppingCart;
        private User _user;
                
        public User User
        {
            get { return _user; }
            set { _user = value; }
        }

        private int _summ;
        
        public int Summ
        {
            get { return _summ; }
            set { _summ = value; }
        }

        public CatalogueControl()
        {
            InitializeComponent();
            labelTotalPrice.Text = "0 $";
            _shoppingCart = new ShoppingCart();
            CheckShopStatus();
        }

        public void CheckShopStatus()
        {
            DateTime dateTime = DateTime.Now;
            if (dateTime.Hour > 9 && dateTime.Hour < 19)
            {
                labelShopStatus.Text = "Open";
                labelShopStatus.ForeColor = Color.White;
            } else
            {
                labelShopStatus.Text = "Closed";
                labelShopStatus.ForeColor = Color.Orange;
            }
        }

        private void FillShoppingCart(List<Item> items)
        {
            shoppingCartGrid.Rows.Clear();
            foreach (Item item in items)
            {
                shoppingCartGrid.Rows.Add(new object[] {
                    item.Title,
                    item.Price,
                    "X"
                });
                shoppingCartGrid.Rows[shoppingCartGrid.RowCount - 1].Tag = item;
            }
        }

        private void UpdateDataGrid()
        {
            FillShoppingCart(_shoppingCart.Items);
            labelTotalPrice.Text = _shoppingCart.CalculateSumm().ToString() + "$";
        }
        
        private void BuyButton_Click(object sender, EventArgs e)
        {
            _shoppingCart.AddItem(new Item(label1.Text, labelPrice.Text));
            UpdateDataGrid();
        }

        private void ShoppingCartGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Item item = (Item) shoppingCartGrid.CurrentRow.Tag;
            //Remove column
            if (e.ColumnIndex == 2) 
            {
                _shoppingCart.RemoveItem(item);
                UpdateDataGrid();
            }
        }

        private void ProcessedButton_Click(object sender, EventArgs e)
        {
            // TODO: add birthday discount
            //       write order to db and show order message
            //       and calculate delivery

        }
    }
}
