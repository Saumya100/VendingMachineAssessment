using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Program
    {
        static void Main(string[] args)
        {

            double totalAmount = AcceptCoin(0);


            // Selecting Products
            while (true)
            {                
                Console.Write("Select Product: Cola - $1.00 /Chips - $0.5 /Candy - $0.65");
                string product = Console.ReadLine();
                bool success = SelectProduct(totalAmount, product);

                if (success)
                {
                    break;
                }

                totalAmount = AcceptCoin(totalAmount);                
            }
                

            Console.ReadLine();
        }

        public static double AcceptCoin(double totalAmount)
        {
            // double totalAmount = 0;

            Console.Write("Insert Coin to machine Nickel/Dime/Quater. To stop type 'N' ");
            while (true)
            {
                Console.Write("Insert Coin: Y/N");
                var input = Console.ReadLine();
                if (input.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                Console.Write("Coin Size: ");
                int coinSize = int.Parse(Console.ReadLine());
                Console.Write("Coin Weight: ");
                int coinWeight = int.Parse(Console.ReadLine());

                totalAmount += CheckCoin(coinSize, coinWeight);

                Console.WriteLine($"Total Amount: {totalAmount}");
            }

            return totalAmount;
        }

        public static double CheckCoin(int size, int weight)
        {
            double coinAmount = Coin.GetCoinValue(size, weight);

            if (coinAmount == 0)
            {
                Console.WriteLine("INVALID COIN");
            }

            return coinAmount;
        }

        public static bool SelectProduct(double amount, string product)
        {
            bool success = false;
            switch (product.ToUpper())
            {
                case "COLA":
                    if (amount >= 1)
                        success = true;                    
                    break;
                case "CHIPS":
                    if (amount >= .5)
                        success = true;
                    break;
                case "CANDY":
                    if (amount >= .65)
                        success = true;
                    break;
                default:
                    Console.WriteLine("INVALID PRODUCT");
                    break;

            }

            if (success)
            {
                Console.WriteLine($"This is your {product}");
                Console.WriteLine("THANK YOU");
            }
            else
            {
                Console.WriteLine("INSER COIN");
            }

            return success;
        }
    }
}
