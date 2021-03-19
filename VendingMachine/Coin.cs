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
            Coin currentCoin = Constant.CoinItems.Where(c => c.Size == size && c.Weight == weight).FirstOrDefault();             
            return currentCoin == null ? 0 : currentCoin.Value;
        }
    }    
    
}
