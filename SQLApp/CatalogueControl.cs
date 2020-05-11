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
        ShoppingCartControl shoppingCart = new ShoppingCartControl();
        public CatalogueControl()
        {
            InitializeComponent();
        }

        private void CatalogueControl_Load(object sender, EventArgs e)
        {
            
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            shoppingCart.AddPanel(panel1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
