using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Делегаты__задание_4_
{
    class Program
    {
        public delegate int SumDelegate(int m, int n);
        static void Main(string[] args)
        {
            SumDelegate sumDelegate = new SumDelegate(Sum);
            int result1 = sumDelegate(5, 7);
            Console.WriteLine($"Сумма целых чисел от m до n: {result1}");
            int result2 = sumDelegate(2, 8);
            Console.WriteLine($"Сумма целых чисел от m до n: {result2}");
            int result3 = sumDelegate(2, 4);
            Console.WriteLine($"Сумма целых чисел от m до n: {result3}");

            Console.ReadKey();
        }
        public static int Sum(int m, int n)
        {
            int sum = 0;

            for (int i = m; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
