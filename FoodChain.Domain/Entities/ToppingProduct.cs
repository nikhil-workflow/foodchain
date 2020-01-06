using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodChain.Domain.Entities
{
    public class ToppingProduct
    {
        public int ToppingProductId { get; set; }
        public int Topping_ToppingId { get; set; }
        public int Product_ProductId { get; set; }
    }
}
