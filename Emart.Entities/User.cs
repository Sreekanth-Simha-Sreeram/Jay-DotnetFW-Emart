using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMart.Entities
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string PhoneNumber { get; set; }

    }
}
