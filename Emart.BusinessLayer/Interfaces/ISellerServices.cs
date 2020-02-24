using EMart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMart.BusinessLayer.Ineterfaces
{
    public interface ISellerServices
    {
        void AddStock(Products product, Seller seller, int Stock);

        List<IStock> ViewSalesInventory(int SellerId);
    }
}
