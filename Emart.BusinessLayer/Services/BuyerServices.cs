using EMart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using EMart.BusinessLayer.Ineterfaces;

namespace EMart.BusinessLayer.Services
{
    public class BuyerServices : IBuyerServices
    {
        //public IBuyerServices _Ibuyerservices;
        //public BuyerServices(IBuyerServices IbuyerServices)
        //{
        //    _Ibuyerservices = IbuyerServices;
        //}

        


        public List<Products> SearchProduct(string ProductName, string CategoryName, string SubCategoryName)
        {
            List<Products> product = new List<Products>();
            return product;
        }

        public bool AddToCart(List<Products> products)
        {
         //   var session = NHibernateHelper.OpenSession();
            return true;
        }


        public List<Products> FilterProduct(string ProductName, string CategoryName, int Price, string Manufacturer)
        {
            List<Products> product = new List<Products>();
            return product;
        }

        public List<Products> PlaceOrder(List<Products> product, Buyer buyer)
        {
            List<Products> Order = new List<Products>();
            return Order;
        }
        public bool DeleteFromCart(List<Products> products, int BuyerId)
        {
            return true;
            
        }


        public List<Products> ViewCart(List<Products> products)
        {
            List<Products> Productlist = new List<Products>();
            return Productlist;
        }

        //public List<Products> GetItemFromCart(int Id)
        //{
        //    List<Products> Pr
        //}
    }
}
