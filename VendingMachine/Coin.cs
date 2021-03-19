using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Coin
    {
        public int Size { get; set; }
        public int Weight { get; set; }
        public double Value { get; set; }


        public static double GetCoinValue(int size, int weight)
        {
            // double coinValue = 0;

            Coin currentCoin = Constant.CoinItems.Where(c => c.Size == size && c.Weight == weight).FirstOrDefault(); 

            //if(size == 5 && weight ==5)
            //{
            //    coinValue = .05;
            //}
            //else if (size == 10 && weight == 10)
            //{
            //    coinValue = 0.1;
            //}
            //else if (size == 25 && weight == 25)
            //{
            //    coinValue = .25;
            //}




            return currentCoin == null ? 0 : currentCoin.Value;
        }
    }
    
    static class Constant
    {
        public static readonly Coin Nickel = new Coin { Size = 5, Weight = 5, Value = 0.05 };
        public static readonly Coin Dime = new Coin { Size = 10, Weight = 10, Value = 0.1 };
        public static readonly Coin Quater = new Coin { Size = 25, Weight = 25, Value = 0.25 };
        
        public static readonly List<Coin> CoinItems = new List<Coin>() { Nickel,Dime, Quater };
        
    }
}
