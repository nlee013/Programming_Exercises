using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0520_Exercises1
{
    class Program
    {
        //static void Main(string[] args) //SWAP
        //{
        //    int a = 25;
        //    int b = 27;

        //    Console.WriteLine($"Swap before : a = {a}, b = {b}");

        //    Swap(ref a, ref b);
        //    Console.WriteLine($"Swap after :  a = {a}, b = {b}");
        //}
        //static void Swap(ref int a, ref int b)
        //{
        //    int temp = b;
        //    b = a;
        //    a = temp;
        //}

        //static void Main() //MIN
        //{
        //    int[] data = { 25, 18, 23, 27, 7, 9 };
        //    int min = data[0];

        //    //최소값 구하는 알고리즘
        //    for (int i = 0; i < data.Length; i++)
        //    {
        //        if(min > data[i])
        //        {
        //            min = data[i];
        //        }
        //    }
        //    Console.WriteLine("Value : {0}", min); ;
        //}

        static void Main(string[] args)
        {
            int[] MinV = { 3, 7, 5, 9, 1 };
           
            //Console.WriteLine(Add(2, 4));
            //Console.WriteLine(Addd());

            // Console.WriteLine(Add(5, 9));
            // Console.WriteLine(Addd());

            Console.WriteLine(Min (new int[] { 45, 5, 7, 3, 9 }));

        }
        static int Min(int[] a)//Min 2
        {
            int result = int.MaxValue;
            foreach (var v in a)
            {
                if(v < result)
                {
                    result = v;
                }
            }
            return result;
        }








        //static int Add(int a, int b)
        //{
        //    int sum = a + b;

        //    return sum;
        //}

        //static int Addd()
        //{
        //    int a = 3, b = 7;
        //    int sum = a + b;

        //    return sum;
        //}


        //static void Main() //SUM
        //{
        //    int[] scores = { 25, 100, 49, 27, 90, 88 };
        //    int sum = 0;

        //    //sum값 구하는 알고리즘
        //    for (int i = 0; i < scores.Length; i++)
        //    {
        //        if (scores[i] >= 77)
        //        {
        //            sum += scores[i];
        //        }
        //    }
        //    Console.WriteLine($"scores.Length의 점수 중 77점 이상 총점 : {sum}");
        //}

        //static void Main()
        //{
        //    int[] evenSum = { 25, 100, 42, 27, 90, 88 };
        //    int evenSum = 0;

        //    //sum값 구하는 알고리즘
        //    for (int i = 0; i < evenSum.Length; i++)
        //    {
        //        if (evenSum[i] >= 77)
        //        {
        //            evenSum += evenSum[i];
        //        }
        //    }
        //    Console.WriteLine($"scores.Length의 점수 중 77점 이상 총점 : {sum}");
        //}


        //static void Main(string[] args) //Roots
        //{
        //    int a = 1, b = 2;
        //    (a, b) = (b, a);

        //    Console.WriteLine(Roots(1, -6, -10));
        //}
        //static (float, float) Roots(int a, int b, int c)
        //{
        //    var temp = Math.Sqrt(b * b - 4 * a * c);
        //    return ((float)(-b + temp) / (2 * a), (float)(-b - temp) / (2 * a));
        //}
    }
}
