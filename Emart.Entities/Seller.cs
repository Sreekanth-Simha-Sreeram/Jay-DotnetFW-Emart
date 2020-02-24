using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMart.Entities
{
    public class Seller
    {

        public virtual int SellerId { get; set; }
        public virtual string SellerName { get; set; }
    }
}
