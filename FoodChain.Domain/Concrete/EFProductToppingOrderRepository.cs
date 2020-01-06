using FoodChain.Domain.Abstract;
using FoodChain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodChain.Domain.Concrete
{
    public class EFProductToppingOrderRepository : IProductToppingOrderRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<ProductToppingOrder> ProductToppingOrders
        {
            get { return context.ProductToppingOrders; }
        }

        public void SaveProductToppingOrder(ProductToppingOrder ProductToppingOrder)
        {
            if (ProductToppingOrder.ProductToppingOrderId == 0)
            {
                context.ProductToppingOrders.Add(ProductToppingOrder);
            }
            else
            {
                context.Entry(ProductToppingOrder).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
    }
}
