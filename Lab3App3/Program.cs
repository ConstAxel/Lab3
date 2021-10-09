using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст от 20-69");
            int v = Convert.ToInt32(Console.ReadLine());
            while (v < 20 || v > 69)
            {
                Console.WriteLine("Возраст введен неправильно. Введите возраст от 20 до 69");
                v = int.Parse(Console.ReadLine());
            }
            if (v >= 20 || v <= 69)
            {
                Console.Write("Возраст=");
            }
            int m = v / 10;
            int d = v % 10;
            {
                switch (m)
                {
                    case 2:
                        {
                            Console.Write("двадцать ");
                            break;
                        }
                    case 3:
                        {
                            Console.Write("тридцать ");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("сорок ");
                            break;
                        }
                    case 5:
                        {
                            Console.Write("пятьдесят ");
                            break;
                        }
                    case 6:
                        {
                            Console.Write("шестьдесят ");
                            break;
                        }
                }
                switch (d)
                {
                    case 1:
                        {
                            Console.Write("один ");
                            break;
                        }
                    case 2:
                        {
                            Console.Write("два ");
                            break;
                        }
                    case 3:
                        {
                            Console.Write("три ");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("четыре ");
                            break;
                        }
                    case 5:
                        {
                            Console.Write("пять ");
                            break;
                        }
                    case 6:
                        {
                            Console.Write("шесть ");
                            break;
                        }
                    case 7:
                        {
                            Console.Write("семь ");
                            break;
                        }
                    case 8:
                        {
                            Console.Write("восемь ");
                            break;
                        }
                    case 9:
                        {
                            Console.Write("девять ");
                            break;
                        }
                }
                if ((d) == 1)
                    Console.Write("год");
                if (((d) >= 2) && (d) <= 4)
                    Console.Write("года");
                if (((d) == 0) || ((d) >= 5) && ((d) <= 9))
                    Console.Write("лет");
                Console.Read();
            }
        }
    }
}
