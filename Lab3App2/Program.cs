using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App2
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Координаты;
            Console.WriteLine("Значение точки А");
            Console.WriteLine("Введите A");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Значение точки В");
            Console.WriteLine("Введите B");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Значение точки С");
            Console.WriteLine("Введите C");
            double c = Convert.ToDouble(Console.ReadLine());
            #endregion;
            double ab = Math.Abs(b - a);
            double ac = Math.Abs(c - a);
            if (a == c && b == c)
            {
                Console.WriteLine($"Точки А и B совпадают с C:\nА ={a}:B ={b}:C ={c}");
            }
            else if (a == b)
            {
                Console.WriteLine($"Точка В совпадает с А\nА ={a}:B ={b}");
            }
            else if (a == c)
            {
                Console.WriteLine($"Точка С совпадает с А\nА ={a}:C ={c}");
            }
            else if (b == c)
            {
                Console.WriteLine("Точка B совпадает с C");
                Console.Write($"Точка B и С равноудаленны\n Расстояние АB={ab}\tАC={ac}");
            }
            else
                {
                    if (ab > ac)
                    {
                        Console.WriteLine($"Точка С ближе к точке А\n Расстояние АС={ac}");
                    }
                    else if (ab < ac)
                    {
                        Console.Write($"Точка B ближе к точке А\n Расстояние АB={ab}");
                    }
                    else
                    {
                        Console.Write($"Точка B и С равноудаленны\n Расстояние АB={ab}\tАC={ac}");

                    }
            }
                Console.ReadKey();

        }
 
    }
}   
