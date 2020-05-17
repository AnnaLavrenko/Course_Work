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
        private Label label;
        public CatalogueControl()
        {
            InitializeComponent();
        }

        private void CatalogueControl_Load(object sender, EventArgs e)
        {
            
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            label = new Label();
            label.Text = label1.Text;
            flowLayoutPanelShoppingCart.Controls.Add(label);
        }

        private Label AddLabel(Label label)
        {
            Label l = new Label();
            l = label;
            return l;
        }
    }
}
