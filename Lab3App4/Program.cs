using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 100-999");
            int q = Convert.ToInt32(Console.ReadLine());
            while (q < 100 || q > 999)
            {
                Console.WriteLine("Ошибка,повторите ввод от 100-999");
                q = int.Parse(Console.ReadLine());
            }
            Console.Write("Число=");
            int g = q / 100;
            int d1 = (q % 100);
            int d = (q % 100) / 10;
            int s = q % 10;
            switch (g)
            {
                case 1:
                    {
                        Console.Write("сто");
                        break;
                    }
                case 2:
                    {
                        Console.Write("двести");
                        break;
                    }
                case 3:
                    {
                        Console.Write("триста");
                        break;
                    }
                case 4:
                    {
                        Console.Write("четыреста");
                        break;
                    }
                case 5:
                    {
                        Console.Write("пятьсот");
                        break;
                    }
                case 6:
                    {
                        Console.Write("шестьсот");
                        break;
                    }
                case 7:
                    {
                        Console.Write("семьсот");
                        break;
                    }
                case 8:
                    {
                        Console.Write("восемьсот");
                        break;
                    }
                case 9:
                    {
                        Console.Write("девятьсот");
                        break;
                    }

                default:
                break;
            }
            if (d1 >= 10 && d1 <= 19)
            {
                switch (d1)
                {
                    case 10:
                        {
                            Console.Write("десять");
                            break;
                        }
                    case 11:
                        {
                            Console.Write("одинадцать");
                            break;
                        }
                    case 12:
                        {
                            Console.Write("двенадцать");
                            break;
                        }
                    case 13:
                        {
                            Console.Write("тринадцать");
                            break;
                        }
                    case 14:
                        {
                            Console.Write("четырнадцать");
                            break;
                        }
                    case 15:
                        {
                            Console.Write("пятнадцать");
                            break;
                        }
                    case 16:
                        {
                            Console.Write("шестнадцать");
                            break;
                        }
                    case 17:
                        {
                            Console.Write("семнадцать");
                            break;
                        }
                    case 18:
                        {
                            Console.Write("восемнадцать");
                            break;
                        }
                    case 19:
                        {
                            Console.Write("девятнадцать");
                            break;
                        }
                    default:
                        break;
                }
            }
            else
            {
                switch (d)
                {
                    case 2:
                        {
                            Console.Write("двадцать");
                            break;
                        }
                    case 3:
                        {
                            Console.Write("тридцать");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("сорок");
                            break;
                        }
                    case 5:
                        {
                            Console.Write("пятьдесят");
                            break;
                        }
                    case 6:
                        {
                            Console.Write("шестьдесят");
                            break;
                        }
                    case 7:
                        {
                            Console.Write("семьдесят");
                            break;
                        }
                    case 8:
                        {
                            Console.Write("восемдесят");
                            break;
                        }
                    case 9:
                        {
                            Console.Write("девяносто");
                            break;
                        }

                    default:
                        break;
                }
                switch (s)
                {
                    case 1:
                        {
                            Console.Write("один");
                            break;
                        }
                    case 2:
                        {
                            Console.Write("два");
                            break;
                        }
                    case 3:
                        {
                            Console.Write("три");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("четыри");
                            break;
                        }
                    case 5:
                        {
                            Console.Write("пять");
                            break;
                        }
                    case 6:
                        {
                            Console.Write("шесть");
                            break;
                        }
                    case 7:
                        {
                            Console.Write("семь");
                            break;
                        }
                    case 8:
                        {
                            Console.Write("восемь");
                            break;
                        }
                    case 9:
                        {
                            Console.Write("девять");
                            break;
                        }
                    default:
                        break;

                }

            }
            Console.ReadKey();

        }

    }
}