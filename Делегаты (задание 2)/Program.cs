using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Делегаты__задание_2_
{
    class Program
    {
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            // присваивание адреса метода через конструктор
            Operation del = new Operation(Add); // делегат указывает на метод Add
            int result = del.Invoke(4, 5);
            Console.WriteLine($"Сложение: {result}");
            del = Multiply; // делегат указывает на метод Multiply
            result = del(4, 5);
            Console.WriteLine($"Умножение: {result}");
            del = Division; //делегат указывает на метод Division
            result = del(10, 5);
            Console.WriteLine($"Деление: {result}");
            del = Subtraction; //делегат указывает на метод Subtraction
            result = del(4, 5);
            Console.WriteLine($"Вычитание: {result}");

            Console.ReadKey();
        }
        private static int Add(int x, int y)
        {
            return x + y;
        }
        private static int Multiply(int x, int y)
        {
            return x * y;
        }
        private static int Division(int x, int y)
        {
            return x / y;
        }
        private static int Subtraction(int x, int y)
        {
            return x - y;
        }
    }
}
