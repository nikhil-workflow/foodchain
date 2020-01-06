using FoodChain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodChain.Domain.Abstract
{
    public interface IProductToppingOrderRepository
    {
        IQueryable<ProductToppingOrder> ProductToppingOrders { get; }
        void SaveProductToppingOrder(ProductToppingOrder ProductToppingOrder);

    }
}
