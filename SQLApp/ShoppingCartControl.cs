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
    public partial class ShoppingCartControl : UserControl
    {
        private List<Panel> list = new List<Panel>();

        public void AddPanel(Panel panel)
        {
            list.Add(panel);
        }
        public void RemovePanel(Panel panel)
        {
            list.Remove(panel);
        }
        public ShoppingCartControl()
        {
            InitializeComponent();
        }

        private void ShoppingCartControl_Load(object sender, EventArgs e)
        {
            
        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Panel item in list)
            {
                flowLayoutPanel1.Controls.Add(item);
            }
        }
    }
}
