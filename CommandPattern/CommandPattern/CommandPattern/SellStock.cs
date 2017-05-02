using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class SellStock : StockOrder
    {
        private Stock _stock;
        public SellStock(Stock stock)
        {
            _stock = stock;
        }
        public void ExecuteCommand()
        {
            _stock.Sell();
        }
    }
}
