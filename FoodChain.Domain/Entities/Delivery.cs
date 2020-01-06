using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodChain.Domain.Entities
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public string DeliveryType { get; set; }
        public decimal Cost { get; set; }
    }
}
