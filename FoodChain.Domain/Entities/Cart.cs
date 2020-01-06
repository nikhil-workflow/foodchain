using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodChain.Domain.Concrete;
using FoodChain.Domain.Abstract;

namespace FoodChain.Domain.Entities
{
    public class Cart
    {
        private List<CartLine> cartLine = new List<CartLine>();
        public int DeliveryId { get; set; }

        public void AddItem(Product Product, int quantity)
        {
            CartLine line = cartLine
               .Where(p => p.Product.ProductId == Product.ProductId)
               .FirstOrDefault();

            if (line == null)
            {
                cartLine.Add(new CartLine { Product = Product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Product Product)
        {
            cartLine.RemoveAll(line => line.Product.ProductId == Product.ProductId);
        }

        public decimal GetTotalValue()
        {
            return cartLine.Sum(e => e.Product.Price * e.Quantity);
        }

        public void Clear()
        {
            cartLine.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return cartLine; }
        }

        

    }

    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
