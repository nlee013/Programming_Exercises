using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0525_Exercise4
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            const int N = 1000;

            int sum = 0;

            for (int i = 0; i < N; i++)
            {
                sum += CoinFlip() ? 1 : 0;
            }
            Console.WriteLine(double)sum/N);

        }
        static bool CoinFlip()
        {

        }
    }
}
