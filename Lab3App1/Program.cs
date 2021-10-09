using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Координаты;
            int x1, y1, x2, y2, x3, y3, x4, y4;
            x4=y4 = 0;
            Console.WriteLine("Введите координаты первой точки");
            Console.WriteLine("Введите x1");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y1");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки");
            Console.WriteLine("Введите x2");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y2");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты третьей точки");
            Console.WriteLine("Введите x3");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y3");
            y3 = Convert.ToInt32(Console.ReadLine());
            #endregion;

            if (x1 == x2)
            {
                if (y3 == y2)
                {
                    x4 = x3;
                    y4 = y1;
                    Console.WriteLine($"x1:{x1}\ty1:{y1}");
                    Console.WriteLine($"x2:{x2}\ty1:{y2}");
                    Console.WriteLine($"x3:{x3}\ty1:{y3}");
                    Console.WriteLine($"x4:{x4}\ty1:{y4}");
                }
                else if (y3 == y1)
                {
                    x4 = x3;
                    y4 = y2;
                    Console.WriteLine($"x1:{x1}\ty1:{y1}");
                    Console.WriteLine($"x2:{x2}\ty1:{y2}");
                    Console.WriteLine($"x3:{x3}\ty1:{y3}");
                    Console.WriteLine($"x4:{x4}\ty1:{y4}");
                }
                else if (y2 == y1)
                {
                    x4 = x3;
                    y4 = y1;
                    Console.WriteLine($"x1:{x1}\ty1:{y1}");
                    Console.WriteLine($"x2:{x2}\ty1:{y2}");
                    Console.WriteLine($"x3:{x3}\ty1:{y3}");
                    Console.WriteLine($"x4:{x4}\ty1:{y4}");
                }
                else
                {
                    Console.WriteLine("Нельзя получить прямоугольник со сторонами, параллельными координатным осям,");
                }
                
            }
            else if (x2 == x3)
            {
                if (y3 == y2)
                {
                    x4 = x1;
                    y4 = y1;
                    Console.WriteLine($"x1:{x1}\ty1:{y1}");
                    Console.WriteLine($"x2:{x2}\ty1:{y2}");
                    Console.WriteLine($"x3:{x3}\ty1:{y3}");
                    Console.WriteLine($"x4:{x4}\ty1:{y4}");
                }
                else if (y3 == y1)
                {
                    x4 = x1;
                    y4 = y2;
                    Console.WriteLine($"x1:{x1}\ty1:{y1}");
                    Console.WriteLine($"x2:{x2}\ty1:{y2}");
                    Console.WriteLine($"x3:{x3}\ty1:{y3}");
                    Console.WriteLine($"x4:{x4}\ty1:{y4}");
                }
                else if (y2 == y1)
                {
                    x4 = x1;
                    y4 = y3;
                    Console.WriteLine($"x1:{x1}\ty1:{y1}");
                    Console.WriteLine($"x2:{x2}\ty1:{y2}");
                    Console.WriteLine($"x3:{x3}\ty1:{y3}");
                    Console.WriteLine($"x4:{x4}\ty1:{y4}");
                }
                else
                {
                    Console.WriteLine("Нельзя получить прямоугольник со сторонами, параллельными координатным осям,");
                }

            }
            else if (x1 == x3)
            {
                if (y3 == y2)
                {
                    x4 = x2;
                    y4 = y1;
                    Console.WriteLine($"x1:{x1}\ty1:{y1}");
                    Console.WriteLine($"x2:{x2}\ty1:{y2}");
                    Console.WriteLine($"x3:{x3}\ty1:{y3}");
                    Console.WriteLine($"x4:{x4}\ty1:{y4}");
                }
                else if (y3 == y1)
                {
                    x4 = x2;
                    y4 = y2;
                    Console.WriteLine($"x1:{x1}\ty1:{y1}");
                    Console.WriteLine($"x2:{x2}\ty1:{y2}");
                    Console.WriteLine($"x3:{x3}\ty1:{y3}");
                    Console.WriteLine($"x4:{x4}\ty1:{y4}");
                }
                else if (y2 == y1)
                {
                    x4 = x2;
                    y4 = y3;
                    Console.WriteLine($"x1:{x1}\ty1:{y1}");
                    Console.WriteLine($"x2:{x2}\ty1:{y2}");
                    Console.WriteLine($"x3:{x3}\ty1:{y3}");
                    Console.WriteLine($"x4:{x4}\ty1:{y4}");
                }
                else
                {
                    Console.WriteLine("Нельзя получить прямоугольник со сторонами, параллельными координатным осям");
                }
            }
            Console.ReadKey();
        }
    }
}
