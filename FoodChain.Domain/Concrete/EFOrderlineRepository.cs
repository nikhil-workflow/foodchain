using FoodChain.Domain.Abstract;
using FoodChain.Domain.Concrete;
using FoodChain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodChain.Domain.Concrete
{
    public class EFOrderlineRepository : IOrderlineRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<Orderline> Orderlines
        {
           get { return context.Orderlines; }      
        }

        public void SaveOrderline(Orderline orderline)
        {
            if (orderline.OrderlineId == 0)
            {
                context.Orderlines.Add(orderline);
            }
            else
            {
                context.Entry(orderline).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public void ClearOrderline(Orderline orderline)
        {
            if (orderline.OrderId == 0)
            {
                context.Orderlines.Remove(orderline);
                context.SaveChanges();
            }
        }


    }
}
