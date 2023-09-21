// *************************************************
//* Практическая работа 5                          *
//* Выполнила: Онищенко В.И., группа 2-ИСП         *
//* Составить программу работы алгоритма ветвления *
//**************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int S, D, X, C, N, T, m, k; // объявление переменных N,T - цены лимонда и мороженного, X - разница,
                                     // m,k - кол-во порций лимонада и мороженного, S - общая сумма, D - кол-во денег
            Console.WriteLine("Практическая работа №5");
            Console.Write("Введите цену лимонада: ");
            Console.Write("N = "); // ввод исходных данных
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цену мороженного: ");
            Console.Write("T = ");
            T = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество порций лимонада: ");
            Console.Write("m = ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество порций мороженного: ");
            Console.Write("k = ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество ваших денег: ");
            Console.Write("D = ");
            D = Convert.ToInt32(Console.ReadLine());

            S = N * m + T * k; // вычисление общей суммы покупок
            X = D - S; // вычисление разницы
            C = S - D; // сколько нужно доплатить
           



            // проверка условия
            if (X > 0) // если X>0, то
                Console.WriteLine("Возьмите сдачу " + X);
            else if (X == 0) // иначе
                Console.WriteLine("Спасибо за покупку!");
            else 
                Console.WriteLine("Нужно доплатить: " + C);
            Console.ReadKey();








        }
    }
}
