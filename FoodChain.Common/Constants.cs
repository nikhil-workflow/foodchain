using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodChain.Common
{
    public class Constants
    {
        public const string Available = "Available";
        public const string Processed = "Processed";
        public const string CreateOwned = "Create Your Own";

        public class RObjects
        {
            public const string ProductToppings = "ProductToppings";
        }        
    }

    public class SessionKeys
    {
        public const string ToppingList = "ToppingList";
    }

    public class ControllerName
    {
        public const string Product = "Product";
    }

    public class ActionName
    {
        public const string List = "List";
        public const string Manage = "Manage";
        public const string Index = "Index";
        public const string VoucherArea = "VoucherArea";
    }
}
