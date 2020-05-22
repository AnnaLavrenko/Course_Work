using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLApp
{
    class Item
    {
        private string _title;
        private string _price;

        public Item(string title, string price)
        {
            _title = title;
            _price = price;
        }
        
        public string Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
    }
}
