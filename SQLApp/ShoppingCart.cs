using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLApp
{
    class ShoppingCart
    {
        private List<Item> _items;
        private double _summ;
        private double _discount;

        public double Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        public double Summ
        {
            get { return _summ; }
            set { _summ = value; }
        }

        public ShoppingCart()
        {
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }
        public double CalculateSumm(bool isBirthDayToday)
        {
            _summ = 0;
            _discount = 0;

            foreach (Item item in _items)
            {
                _summ += Int16.Parse(item.Price);
            }
            if (_summ > 1000)
            {
                _discount = _summ * 0.05;
                _summ -= _discount;
            } else if(isBirthDayToday)
            {
                _discount = _summ * 0.1;
                _summ -= _discount;
            }
            return _summ;
        }

        public void RemoveItem(Item item)
        {
            _items.Remove(item);
        }

        internal List<Item> Items { get => _items; set => _items = value; }

        public override string ToString()
        {
            return "Your sum:" + this._summ;
        }
    }
}
