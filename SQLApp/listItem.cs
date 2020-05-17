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
    public partial class ListItem : UserControl
    {
        private string _title;
        private string _price;

        public string Price
        {
            get { return _price; }
            set { _price = value; this.labelPrice.Text = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; this.labelItem.Text = value; }
        }


        public ListItem()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
