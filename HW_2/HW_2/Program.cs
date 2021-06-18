using System;

namespace HW_2
{
    class Program
    {
        static double segment1(double x)
        {
            double y;
            y = x + 3;
            return y;
        }

        static double segment2(double x)
        {
            double y;
            y = -x/2;
            return y;
        }

        static double segment3(double x)
        {
            double y;
            y = 1 - x / 2;
            return -2;
        }

        static double segment4(double x, double r = 2)
        {
            //центр окружности
            double xCenter = 8;
            double yCenter = -2;
            double y;
            //по уравнению окружности
            y = Math.Sqrt(r * r - (x - xCenter) * (x - xCenter)) + yCenter;

            return y;
        }


        static void Main(string[] args)
        {
            for (double xm = -4; xm <= 10; xm += 0.2)
            {

                if (xm < -4 || xm > 10)
                {
                    Console.WriteLine("Функция не определена");
                }
                else if (xm < -2)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", xm, segment1(xm));
                }
                else if (xm < 4)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", xm, segment2(xm));
                }
                else if (xm < 6)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", xm, segment3(xm));
                }
                else if (xm < 10)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", xm, segment4(xm));
                }
            }
            Console.WriteLine("Введите значения аргумента x и радиуса окружности R");
            string input = Console.ReadLine();
            double x = input[0];
            double r = input[1];
            if (x < -4 || x > 10)
            {
                Console.WriteLine("Функция не определена");
            }
            else if (x < -2)
            {
                Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment1(x));
            }
            else if (x < 4)
            {
                Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment2(x));
            }
            else if (x < 6)
            {
                Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment3(x));
            }
            else if ((x > 6 && x < 8 - r) || ((x > 8 + r)))
            {
                Console.WriteLine("Функция не определена");
            }
            else if (x < 10)
            {
                Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment4(x, r));
            }

        }
    }
}
