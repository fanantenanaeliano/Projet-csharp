using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Entities
{
    class Operation
    {
        public DateTime date { get; set; }
        public string name { get; set; }
        public string productName { get; set; }
        public int price { get; set; }
        public int amount { get; set; }

        public Operation(DateTime _date, string _name, string _productName, int _amount, int _price)
        {
            this.date = _date;
            this.name = _name;
            this.productName = _productName;
            this.price = _price;
            this.amount= _amount;
        }
    }
}
