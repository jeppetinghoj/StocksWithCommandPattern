using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class StockBroker
    {
        private List<StockOrder> ordersQueue = new List<StockOrder>();

        public void TakeOrder(StockOrder order)
        {
            ordersQueue.Add(order);
        }

        public void PlaceOrders()
        {
            foreach(var o in ordersQueue)
            {
                o.ExecuteCommand();
            }
            ordersQueue.Clear();
        }


    }
}
