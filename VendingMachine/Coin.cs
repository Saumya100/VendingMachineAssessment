using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Coin
    {
        public double Size { get; set; }
        public double Weight { get; set; }        

        public static double GetCoinValue(int size, int weight)
        {
            double coinValue = 0;
            if(size == 5 && weight ==5)
            {
                coinValue = .05;
            }
            else if (size == 10 && weight == 10)
            {
                coinValue = 0.1;
            }
            else if (size == 25 && weight == 25)
            {
                coinValue = .25;
            }

            return coinValue;
        }
    }


    public enum CoinWeight
    {
        nickel = 5,
        dime = 10,
        quater = 25
    }

    public enum CoinSize
    {
        nickel = 5,
        dime = 10,
        quater = 25
    }
   
}
