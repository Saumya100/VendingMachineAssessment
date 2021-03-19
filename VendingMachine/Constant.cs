using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    static class Constant
    {
        public static readonly Coin Nickel = new Coin { Size = 5, Weight = 5, Value = 0.05 };
        public static readonly Coin Dime = new Coin { Size = 10, Weight = 10, Value = 0.1 };
        public static readonly Coin Quater = new Coin { Size = 25, Weight = 25, Value = 0.25 };

        public static readonly List<Coin> CoinItems = new List<Coin>() { Nickel, Dime, Quater };

        public static readonly List<Product> Products = new List<Product>()
        {
            new Product {Name = "COLA" , Price = 1},
             new Product {Name = "CHIPS" , Price = 0.5},
              new Product {Name = "CANDY" , Price = 0.65}
        };

    }
}
