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
        private Panel panel;

        private int _summ;

        public int Summ
        {
            get { return _summ; }
            set { _summ = value; }
        }

        private ListItem _listItem;
        
        public ListItem ListItem
        {
            get { return _listItem; }
            set { _listItem = value; }
        }

        private List<Control> controls;
        public CatalogueControl()
        {
            InitializeComponent();
            listItem1.Hide();
        }

        private void CatalogueControl_Load(object sender, EventArgs e)
        {
            
        }

        private void itemEntered(object sender, EventArgs e)
        {

        }
        public void DrawPanel(string price, string title)
        {
            Label labelPrice = new Label();
            Label labelTitle = new Label();
            Button remove = new Button();
            panel = new Panel();
            remove.Click += Remove_Click;
            panel.Width = 180;
            panel.Height = 25;
            labelPrice.Text = price;
            labelTitle.Text = title;
            panel.Controls.Add(labelPrice);
            panel.Controls.Add(labelTitle);
            panel.MouseEnter += labelEntered;
        }
        public void Remove_Click(object sender, EventArgs e)
        {
            if (lastLabel != null)
            {
                flowLayoutPanelShoppingCart.Controls.Remove(lastLabel);
                lastLabel = null;
            }
        }
        private void BuyButton_Click(object sender, EventArgs e)
        {
            
            DrawPanel(label1.Text, labelPrice.Text);
            _listItem = new ListItem();
            _listItem.Text = label1.Text;

            flowLayoutPanelShoppingCart.Controls.Add(panel);
            controls = new List<Control>();
            
            foreach (Control item in flowLayoutPanelShoppingCart.Controls)
            {
                controls.Add(item);
            }
            foreach (Control item in controls)
            {
                _summ += Int16.Parse(this.labelPrice.Text);
            }
            this.labelTotalPrice.Text = "Total price: " + _summ.ToString() + "$";
        }

        private Panel lastLabel;
        private void labelEntered(object sender, EventArgs e)
        {
            lastLabel = (Panel)sender;
        }

        private void ListItem1_Close(object sender, EventArgs e)
        {
            foreach (Control item in controls)
            {
                _summ -= Int16.Parse(this.labelPrice.Text);
            }
            this.labelTotalPrice.Text = "Total price: " + _summ.ToString() + "$";
        }
    }
}
