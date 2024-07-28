using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Entities
{
    class Product
    {
        public string reference { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int amount { get; set; }

        public Product(string _reference, string _name, int _amount, int _price)
        {
            this.reference = _reference;
            this.name = _name;
            this.price = _price;
            this.amount= _amount;
        }
    }
}
