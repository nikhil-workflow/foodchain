using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodChain.Domain.Entities
{
    public class ProductToppingOrder
    {
        public int ProductToppingOrderId { get; set; }
        public int OrderlineId { get; set; }
        public int ToppingId { get; set; }
    }
}
