using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0520_Exercises_1
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

        //static void Main(string[] args) //MIN + ARRAY
        //{
        //    int[] MinV = { 3, 7, 5, 9, 1 };

        //    //Console.WriteLine(Add(2, 4));
        //    //Console.WriteLine(Addd());

        //    // Console.WriteLine(Add(5, 9));
        //    // Console.WriteLine(Addd());

        //    Console.WriteLine(Min (new int[] { 45, 5, 7, 3, 9 }));

        //}
        //static int Min(int[] a)//Min 2
        //{
        //    int result = int.MaxValue;0
        //    foreach (var v in a)
        //    {
        //        if(v < result)
        //        {
        //            result = v;
        //        }
        //    }
        //    return result;
        //}

        //void Main(string[] args) //ARRAY
        //{
        //    int[] PrintArray = (new int[] { 1, 4, 5, 6, 9 });
        //}


        //static void Main(string[] args) //SORT
        //{

        //    // Array.Sort(values);


        //    //foreach (int value in values)
        //    //{
        //    //    Console.WriteLine(value);
        //    //    Console.WriteLine("");
        //    //}
        //    //Console.WriteLine();
        //}

        //static int Min(int[] values)
        //{
        //    int temp = int.MaxValue;

        //    for (int i = 0; i < values.Length; i++)
        //    {
        //        if (values[i] < temp)

        //            temp = values[i];
        //    }
        //    return temp;
        //}


        //static void Main(string[] args) //MEDIAN
        //{
        //    int[]
        //}

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

        //Mean and Median of an array

        // static void  Main()
        // {
        //     int[] mean = { 1, 4, 7, 3, 5, 8 };


        //    Console.WriteLine("Mean = " + Mean(mean));
        // }
        //public static float Mean(int[] a)
        // {
        //     int sum = 0;

        //     for (int i = 0; i < a.Length; i++)
        //         sum += a[i];

        //     return (float)(sum / a.Length);
        // }

        //static void Main()  //Median
        //{
        //    int[] median = { 3, 5, 8, 2, 9 };
        //    Console.WriteLine("Median" + Median(median));

        //}

        //public static int Median(int[] a)
        //{
        //    int sum = 0;

        //    for (int i = 0; i < a.Length; i++)
        //        sum += a[i];

        //    return (int)(sum / 2);
        //}

        //Selection Sort

        //static void Main(string[] args)
        //{
        //    int[] a = { 3, 2, 1 };
        //    var sorted = SelectionSort(a);

        //    foreach(var v in sorted)
        //    {
        //        Console.WriteLine(v);
        //    }
        //}


        //static T[] SelectionSort<T>(T[] a) //T라는 타입 파라미터
        //{
        //    bool[] used = new bool[a.Length];

        //    for(int i = 0; i < used.Length; i++)
        //    {
        //        used[i] = false;
        //    }
        //    int[] result = new int[a.Length];

        //    //for(int i =0; i < a.Length; i++)
        //    //{
        //    //    int min = int.MaxValue;
        //    //    int minIndex = -1;

        //    //    if (a[i] < min && used[i] == false)
        //    //    {
        //    //        min = a[i];
        //    //        minIndex = i;
        //    //    }
        //    //}
        //    //used[minIndex] = true;
        //    //result[j] = min;
        //}
        //return result;

        static void Main(string[] args)
        {
            Console.WriteLine($"My Sqrt : {Sqrt(2)}");
            Console.WriteLine($"Math Sqrt: {Math.Sqrt(2)}");
        }
        static double Sqrt(double t)
        {
            double Xn = 1;
            //for(int i =0; i < 10; i ++)
            while(Math.Abs()< 0.0000001)
            {
                Xn = Xn - (Xn + Xn - 1) / (2 * Xn);
            }
            return Xn;
        }
    }
}
