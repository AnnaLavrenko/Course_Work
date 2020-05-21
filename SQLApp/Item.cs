using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLApp
{
    class Item
    {

        public Item(string title, string price)
        {
            _title = title;
            _price = price;
        }
        private string _title;
        private string _price;

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
