using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа формирования изображения равностороннего треугольника.");
            Console.WriteLine("Enter the Number of Lines");
            int numLines = Convert.ToInt32(Console.ReadLine());

            string star = "*";
            string space = " ";


            if (numLines >= 0)
            {
                for (int i = 1; i < numLines; i++)
                {
                    for (int j = i; j < numLines; j++)
                    {
                        Console.Write(space);
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(star);
                    }
                    for (int j = 1; j < i; j++)
                    {
                        Console.Write(star);
                    }

                    Console.WriteLine();
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
