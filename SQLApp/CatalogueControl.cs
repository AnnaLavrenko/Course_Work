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
        private ListItem label;
        public CatalogueControl()
        {
            InitializeComponent();
        }

        private void CatalogueControl_Load(object sender, EventArgs e)
        {
            
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            int summ = 0;
            label = new ListItem();
            label.Title = label1.Text;
            label.Price = price.Text;
            flowLayoutPanelShoppingCart.Controls.Add(label);
            List<Control> controls = new List<Control>();
            foreach (Control item in flowLayoutPanelShoppingCart.Controls)
            {
                controls.Add(item);
            }
            foreach (Control item in controls)
            {
                summ += Int16.Parse(this.price.Text);
            }
            this.labelTotalPrice.Text = "Total price: " + summ.ToString() + "$";
        }

    }
}
