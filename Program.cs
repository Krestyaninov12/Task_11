using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение линейного уравнения 0=kx+b:");
            Equations reshenie = new Equations();
            Console.WriteLine("Значение b:");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Значение k:");
            double k = Convert.ToInt32(Console.ReadLine());
            reshenie.Condition(b, k);
        }
        struct Equations
        {
            private double b;
            private double k;
            private double x;

            internal void Condition(double meaningB, double meaningK)
            {
                b = meaningB;
                k = meaningK;
                Root();
            }
            public void Root()
            {
                if (k != 0)
                {
                    x = -b / k;
                    Console.WriteLine("Решение линейного уравнения 0=kx+b:");
                    Console.WriteLine("(После каждого действия нажмите любую клавишу)");
                    Console.WriteLine("Действие 1: приводим уровнение к виду 0=b+kx;");
                    Console.ReadKey();
                    Console.WriteLine("Действие 2: приводим уровнение к виду -b=kx;");
                    Console.ReadKey();
                    Console.WriteLine("Действие 3: определеяем неихвестную: делим обе части уравнения на x=k*x/(-b/x);");
                    Console.ReadKey();
                    Console.WriteLine("Действие 4: получаем формулу для неизвестной: х=-b/k");
                    Console.ReadKey();
                    Console.WriteLine("Действие 5: подстановка заданных значений: решение: x={0,2:f2}", x);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Ошибка деления на 0!!");
                    Console.ReadKey();
                }
            }

        }

    }
}
