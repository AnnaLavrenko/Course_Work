using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLApp
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
            catalogueControl1.Show();
        }

        private void Shop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CatalogueControl1_Load(object sender, EventArgs e)
        {
        }

        private void ScButton_Click(object sender, EventArgs e)
        {
            catalogueControl1.Hide();
            shoppingCartControl1.Show();
        }

        private void CatalogueButton_Click(object sender, EventArgs e)
        {
            shoppingCartControl1.Hide();
            catalogueControl1.Show();
        }
    }
}
