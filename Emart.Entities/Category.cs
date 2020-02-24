using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMart.Entities
{
    public class Category
    {
        public virtual int CategoryId { get; set; }
        public virtual string CategoryName { get; set; }
        public virtual string CategoryDetails { get; set; }
    }
}
