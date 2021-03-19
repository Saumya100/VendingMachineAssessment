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
            BusinessLogic businessLogic = new BusinessLogic();
            double totalAmount = 0;
            while (true)
            {
                // Ask the user to choose an option.  
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\t1 - Add Coin");
                Console.WriteLine("\t2 - Select Product");
                Console.WriteLine("\t3 - Exit");
                Console.Write("Your option? ");                               

                switch (Console.ReadLine())
                {
                    case "1":
                        businessLogic.AcceptCoin();
                        break;
                    case "2":
                        Console.Write("Select Product: Cola - $1.00 /Chips - $0.5 /Candy - $0.65  ");
                        string product = Console.ReadLine();
                        bool success = businessLogic.SelectProduct(totalAmount, product);
                        break;
                    case "3":
                        Environment.Exit(0); ;
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        break;
                }

                totalAmount = businessLogic.GetTotalCoinAmount();
                Console.WriteLine($"Total Coin Amount: {totalAmount}");
            }
        }

        
    }
}
