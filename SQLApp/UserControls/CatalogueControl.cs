using System;
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
        private int _summ;

        public User User
        {
            get { return _user; }
            set { _user = value; }
        }
        
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
                //записывает item в rows tag
                shoppingCartGrid.Rows[shoppingCartGrid.RowCount - 1].Tag = item;
            }
        }

        private void UpdateDataGrid()
        {
            FillShoppingCart(_shoppingCart.Items);
            labelTotalPrice.Text = _shoppingCart.CalculateSumm(_user.IsBirthDayToDay()).ToString() + "$";
        }
        
        private void BuyButton_Click(object sender, EventArgs e)
        {
            _shoppingCart.AddItem(new Item(burgerLabel.Text, labelPrice.Text));
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
            MessageBox.Show("You order " + shoppingCartGrid.Rows.Count.ToString() + " items\n"
                + "Order sum: " + _shoppingCart.Summ.ToString() + "$" + "\n" 
                + "Your discount is: " + _shoppingCart.Discount.ToString() + "$");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _shoppingCart.AddItem(new Item(label5.Text, label4.Text));
            UpdateDataGrid();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            _shoppingCart.AddItem(new Item(label8.Text, label7.Text));
            UpdateDataGrid();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            _shoppingCart.AddItem(new Item(label11.Text, label10.Text));
            UpdateDataGrid();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            _shoppingCart.AddItem(new Item(label14.Text, label13.Text));
            UpdateDataGrid();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            _shoppingCart.AddItem(new Item(label17.Text, label16.Text));
            UpdateDataGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
