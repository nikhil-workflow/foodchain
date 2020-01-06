using FoodChain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodChain.Domain.Abstract
{
    public interface IOrderlineRepository
    {
        IQueryable<Orderline> Orderlines { get; }

        void SaveOrderline(Orderline orderline);
        void ClearOrderline(Orderline orderline);
    }
}
