using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMart.Entities
{
    public class Stock
    {
        public virtual int StockId { get; set; }
        public virtual int StockQuantity { get; set; }
    }
}
