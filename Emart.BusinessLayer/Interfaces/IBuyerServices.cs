
using EMart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMart.BusinessLayer.Ineterfaces
{
    public interface IBuyerServices
    {
        List<Products> SearchProduct(string ProductName, string CategoryName, string SubCategoryName);
        bool AddToCart(List<Products> products);
        List<Products> FilterProduct(string ProductName, string CategoryName, int Price, string Manufacturer);
        bool DeleteFromCart(List<Products> products, int BuyerId);
        List<Products> ViewCart(List<Products> products);
        List<Products> PlaceOrder(List<Products> product, Buyer buyer);
    }
}

