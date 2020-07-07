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
                Console.WriteLine("input should be a positive integer");
            }
            else
            {
                Makechange(C, change);
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
