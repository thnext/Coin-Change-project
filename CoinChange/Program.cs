using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CoinChange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press: 1. for cannonical coin system");
            Console.WriteLine("press: 2. for your own change system");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    // canonical coin systems

                    int[] C = new int[] { 100, 50, 20, 10, 5, 2, 1 };

                    Console.WriteLine("enter the change:");

                    int change = int.Parse(Console.ReadLine());

                    if (change == 0)
                    {
                        Console.WriteLine("not possible");
                    }
                    else if (change < 0)
                    {
                        Console.WriteLine("wrong input (negative number)");
                    }
                    else
                    {
                        Makechange(C, change);
                    }
                    break;

                case 2:
                    // Greedy algorithm for general case

                    Console.WriteLine("Enter the numbers of coins you would like to use for the system?");
                    int numofcoins = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your coin system in descending order,1 should be the last value.");
                    int[] coins = new int[numofcoins];
                    for (int x = 0; x <= numofcoins - 1; x++)
                    {
                        coins[x] = int.Parse(Console.ReadLine());
                    }
                    if (coins[coins.Length - 1] != 1)
                    {
                        Console.WriteLine("You must have 1 at the end!");
                        _ = Console.ReadKey();// I added this FOR reading the message, the program was ending immediately
                    }
                    else if (coins.Any(p => p < 0))
                    {
                        Console.WriteLine("wrong input (negative number)");
                        _ = Console.ReadKey();
                    }
                    else if (coins.Length != coins.Distinct().Count())
                    {
                        Console.WriteLine("you have Entered same input!");
                        _ = Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("How much money do you need back?");
                        int amount = int.Parse(Console.ReadLine());
                        Makechange(coins, amount);
                    }

                    break;
                default:
                    Console.WriteLine("invalid option");
                    _ = Console.ReadKey();
                    break;
                    
            }
        }
        public static void Makechange(int[] coins, int change)
        {
            for (int x = 0; x <= coins.Length - 1; x++)
            {
                if (change >= coins[x])
                {
                    int howmany = change / coins[x];
                    change %= coins[x];
                    Console.WriteLine(howmany + "*" + coins[x] + "zlt");
                }
            }
            _ = Console.ReadLine();
        }
    }
}
