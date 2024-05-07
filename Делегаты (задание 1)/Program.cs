using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Делегаты__задание_1_
{
    class Program
    {
        delegate void GetMessage(); //объявление делегата
        static void Main(string[] args)
        {
            GetMessage del; //создание делегата
            if (DateTime.Now.Hour < 12)
            {
                del = GoodMorning; //присваивание этой переменной адрес метода
            }
            else
            {
                del = GoodEvening; //присваивание этой переменной адрес метода
            }
            del.Invoke(); //вызываем метод

            Console.ReadKey();
        }
        private static void GoodMorning()
        {
            Console.WriteLine("Доброе утро");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Добрый вечер");
        }
    }
}
