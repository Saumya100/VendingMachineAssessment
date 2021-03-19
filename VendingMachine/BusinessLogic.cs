using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class BusinessLogic
    {
        public double totalCoinAmount = 0;
        public void AcceptCoin()
        {
            Console.Write("Coin Size: ");
            int coinSize = int.Parse(Console.ReadLine());
            Console.Write("Coin Weight: ");
            int coinWeight = int.Parse(Console.ReadLine());

            totalCoinAmount += CheckCoin(coinSize, coinWeight); 
        }

        public double CheckCoin(int size, int weight)
        {
            double coinAmount = Coin.GetCoinValue(size, weight);

            if (coinAmount == 0)
            {
                Console.WriteLine("INVALID COIN");
            }

            return coinAmount;
        }

        public bool SelectProduct(double amount, string product)
        {
            Product selectedProduct = Constant.Products.Where(p => p.Name == product.ToUpper()).FirstOrDefault();

            if (selectedProduct == null)
            {
                Console.WriteLine("INVALID PRODUCT");
            }
            else
            {
                if (selectedProduct.Price <= amount)
                {
                    Console.WriteLine($"This is your {product}");
                    Console.WriteLine("THANK YOU");
                    totalCoinAmount = totalCoinAmount - selectedProduct.Price;
                    return true;
                }
                else
                {
                    Console.WriteLine("INSER COIN");
                }
            }
            return false;
        }

        public double GetTotalCoinAmount()
        {
            return totalCoinAmount;
        }
    }
}
