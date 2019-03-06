using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа формирования изображения прямоугольного треугольника.");
            Console.WriteLine("Enter the Number of Lines");
            int numLines = Convert.ToInt32(Console.ReadLine());

            string star = "*";
            if (numLines >= 0)
            {
                for (int i = 0; i < numLines; i++)
                {
                    Console.WriteLine(star);
                    star = "*" + star;

                }
            }
            else
            {
                Console.WriteLine(" Error! the Number will be > 0 ");
            }
            Console.ReadLine();
        }
    }
}
