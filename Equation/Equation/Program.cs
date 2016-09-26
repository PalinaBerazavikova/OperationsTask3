using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("Введите 1 для решения квадратного уравнения (a * x^2 + b * x + c = 0)");
            Console.WriteLine("Введите 2 для решения линейного уравнения (a * x + b = 0)");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    {
                        double a, b, c;
                        bool isAGoodA;
                        Console.WriteLine("Вы выбрали квадратное уравнение (a * x^2 + b * x + c = 0)");
                        do
                        {
                            Console.WriteLine("Введите коэффициет а (число неравное нулю):");
                            isAGoodA = double.TryParse(Console.ReadLine(), out a);

                        } while((!isAGoodA) || (a == 0));
                        do
                        {
                            Console.WriteLine("Введите коэффициет b:");

                        } while (!double.TryParse(Console.ReadLine(), out b));
                        do
                        {
                            Console.WriteLine("Введите коэффициет c:");

                        } while (!double.TryParse(Console.ReadLine(), out c));
                        Quadr quadr = new Quadr(a,b,c);
                        double[] result = quadr.ToFindResult();
                        if(quadr.D < 0)
                        {
                            Console.WriteLine("Дискриминант меньше нуля, решений нет.");
                        }else
                        {
                            if (quadr.D == 0)
                            {
                                Console.WriteLine($"Дискриминант равен нулю, решение: x1 = x2 = {result[0]}.");
                            }else
                            {
                                if(quadr.D > 0)
                                {
                                    Console.WriteLine($"Дискриминант больше нуля, решение: x1 = {result[0]} x2 = {result[1]}.");
                                }
                            }
                        }
                        break;
                    }
                case "2":
                    {
                        double a, b;
                        Console.WriteLine("Вы выбрали линейное уравнение (a * x + b = 0)");
                        do
                        {
                            Console.WriteLine("Введите коэффициет а:");

                        } while (!double.TryParse(Console.ReadLine(), out a));
                        do
                        {
                            Console.WriteLine("Введите коэффициет b:");

                        } while (!double.TryParse(Console.ReadLine(), out b));
                        Linear linear = new Linear(a, b);
                        break;
                    }
            }
        }
    }
}
