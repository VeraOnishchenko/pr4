using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_4._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа №4";

            double a, b, c, x; // объявление переменных
            double v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16;

            Console.WriteLine("Здравствуйте!");
            
            
            Console.Write("Введите a = "); // ввод исходных данных
            a = Convert.ToDouble(Console.ReadLine()); // явное приведение к типу double
            Console.Write("Введите b = "); // ввод исходных данных
            b = Convert.ToDouble(Console.ReadLine()); // явное приведение к типу double
            Console.Write("Введите c = "); // ввод исходных данных
            c = Convert.ToDouble(Console.ReadLine()); // явное приведение к типу double


            // расчет значения выражения
            v1 = 1 / a;
            v2 = 1 / b + c;
            v3 = v1 - v2;
            v4 = v1 + v2;
            v5 = v3 / v4;
            v6 = Math.Pow(b, 2);
            v7 = Math.Pow(c, 2);
            v8 = Math.Pow(a, 2);
            v9 = v6 + v7 - v8;
            v10 = 2 * b * c;
            v11 = v9 / v10;
            v11 += 1;
            v12 = v5 * v11;
            v13 = a - b - c;
            v14 = a * b * c;
            v15 = v13 / v14;

            x = v12 / v15;

            // вывод результата на экран
            Console.WriteLine("Результат: x = {0: #.#####}", x);
            Console.ReadKey(); // задержка экрана консоли
        }
    }
}
