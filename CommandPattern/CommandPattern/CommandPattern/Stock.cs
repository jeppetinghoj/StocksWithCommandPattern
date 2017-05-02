using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Stock
    {
        public Stock(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public void Buy()
        {
            Console.WriteLine("You've bought: " + Name + ", Quantity: " + Quantity);
        }

        public void Sell()
        {
            Console.WriteLine("You've sold: " + Name + ", Quantity: " + Quantity);
        }
    }
}
