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
        public double CalculateSumm()
        {
            _summ = 0;
            foreach(Item item in _items)
            {
                _summ += Int16.Parse(item.Price);
            }
            return _summ;
        }

        public void RemoveItem(Item item)
        {
            _items.Remove(item);
        }

        internal List<Item> Items { get => _items; set => _items = value; }
    }
}
