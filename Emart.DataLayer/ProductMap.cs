using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EMart.Entities;

namespace EMart.BusinessLayer
{
    public class ProductMap : ClassMap<Products>
    {
        public ProductMap()
        {
            Id(x => x.Id).Column("Id");

            Map(x => x.ProductName).Column("ProductName");

            Map(x => x.SubCategoryId).Column("SubCategoryId");
            Map(x => x.Price).Column("Price");
            Map(x => x.BuyerId).Column("BuyerID");
            Map(x => x.CategoryId).Column("CategoryId");
            Table("Product");

        }
    }


}
