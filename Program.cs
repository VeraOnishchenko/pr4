/******************************************************************************************************/
/* Практическая работа 6                                                                              */
/* Выполнила: Онищенко В.И., группа 2-ИСП                                                             */
/* Составить программу работы алгоритма усложненного ветвления с обработкой ошибок времени исполнения */
/******************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №5 \n");


            try
            {
                Console.Write("Введите цену лимонада: \n");
                Console.Write("N = ");
                int N = Convert.ToInt32(Console.ReadLine()); // N - цена лимонада
                Console.Write("Введите цену мороженного: \n");
                Console.Write("T = ");
                int T = Convert.ToInt32(Console.ReadLine()); // T - цена мороженного;
                Console.Write("Введите количество порций лимонада: \n");
                Console.Write("m = ");
                int m = Convert.ToInt32(Console.ReadLine()); // m - кол-во порций лимонада
                Console.Write("Введите количество порций мороженного: \n");
                Console.Write("k = ");
                int k = Convert.ToInt32(Console.ReadLine()); // k - кол-во порций мороженного
                Console.Write("Введите количество ваших денег: \n");
                Console.Write("D = ");
                int D = Convert.ToInt32(Console.ReadLine()); // D - количество денег
                int S = N * m + T * k; // вычисление общей суммы покупок
                int X = D - S; // вычисление разницы
                int C = S - D; // сколько нужно доплатить

                switch (X > 0) // проверка условия
                {
                    case true:
                        Console.WriteLine("Возьмите сдачу " + X);
                        break;
                }
                switch (X < 0)
                {
                    case true:
                        Console.WriteLine("Нужно доплатить: " + C);
                        break;

                }
                switch (X == 0) // сравниваем значение
                {
                    case true:
                        Console.WriteLine("Спасибо за покупку!");
                        break;
                }
            }
            catch (Exception e) // обработка исключений
            {

                Console.WriteLine("Что то пошло не так. Ошибка: " + e.Message);
            }
            Console.ReadKey();
        }
    }
}
