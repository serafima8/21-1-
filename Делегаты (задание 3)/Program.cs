using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Делегаты__задание_3_
{
    public class Program
    {
        public delegate double AverageDelegate(int m, int n); //Объявление типа делегата
        public static void Main(string[] args)
        {
            AverageDelegate averageDelegate = new AverageDelegate(Average); //  Объявление самого делегата
            // Примеры применения делегата
            double result1 = averageDelegate(1, 5);
            Console.WriteLine($"Среднее арифметическое: {result1}");
            double result2 = averageDelegate(10, 20);
            Console.WriteLine($"Среднее арифметическое: {result2}");
            double result3 = averageDelegate(-5, 5);
            Console.WriteLine($"Среднее арифметическое: {result3}");

            Console.ReadKey();
        }
        // Создание статического метода для вычисления среднего арифметического
        public static double Average(int m, int n)
        {
            double sum = 0;
            int count = 0;
            for (int i = m; i <= n; i++)
            {
                sum += i;
                count++;
            }
            return sum / count;
        }
    }
}
