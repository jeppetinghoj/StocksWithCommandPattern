using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class BuyStock : StockOrder
    {
        private Stock _stock;

        public BuyStock(Stock stock)
        {
            _stock = stock;
        }

        public void ExecuteCommand()
        {
            _stock.Buy();
        }
    }
}
