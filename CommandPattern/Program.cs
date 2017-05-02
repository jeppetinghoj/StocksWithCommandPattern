using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock myStock = new Stock("Carlsberg", 20);
            BuyStock buyStockOrder = new BuyStock(myStock);
            SellStock sellStockOrder = new SellStock(myStock);
            StockBroker stockBroker = new StockBroker();

            stockBroker.TakeOrder(buyStockOrder);
            stockBroker.TakeOrder(buyStockOrder);
            stockBroker.TakeOrder(sellStockOrder);

            stockBroker.PlaceOrders();
        }
    }
}
