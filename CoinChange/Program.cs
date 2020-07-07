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
            Console.WriteLine("enter change");
            string x = Console.ReadLine();
            int[] C = new int[] { 100, 50, 20, 10, 5, 2, 1 };
            do
            {
               
                try
                {
                    int change = int.Parse(x);
                    Makechange(C, change);
                }
                catch
                {
                    Console.WriteLine("wrong input! (please enter a positive intreger value)");
                }
                finally
                {
                    Console.WriteLine("Continue? (type Y/N)");
                }

            } while (Console.ReadLine() == "y");
           
        }
        public static void Makechange(int[] coins, int value)
        {
            int howmany;
            foreach (int item in coins)
            {
                 if (value >= item)
                 {
                    howmany = value / item;
                    value %= item;
                    Console.WriteLine(howmany + "*" + item + "zlt");

                 }

            }
        }
    }
}
