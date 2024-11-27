using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp_2._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.9. Известны количество жителей в государстве и площадь его территории. Определить плотность населения в этом государстве.
            Console.WriteLine("Программа для вычисления плотности населения.");
        imputPeople:
            Console.Write("Введите количество жителей (млн): ");
            double people = Convert.ToDouble(Console.ReadLine());
            double peopleInMil = people * 1000000;
            if (peopleInMil > 0)
            {
            imputSquare:
                Console.Write("Введите площадь территории (млн.км^2): ");
                double square = Convert.ToDouble(Console.ReadLine());
                double squareInMil = square * 1000000;
                if (square > 0)
                {
                    double P = peopleInMil / squareInMil;
                    Console.WriteLine("Плотность населения равна: " + P.ToString("#.##"));
                    return;
                }
                else
                    Console.WriteLine("Введено неверное значение");
                goto imputSquare;
            }
            else
            {
                Console.WriteLine("Введено неверное значение");
                goto imputPeople;
            }
        }
    }
}
