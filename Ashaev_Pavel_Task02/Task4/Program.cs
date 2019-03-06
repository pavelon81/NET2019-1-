using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа формирования изображения из N треугольников.");
            Console.WriteLine("Enter the Number of Triange");
            int numTriange = Convert.ToInt32(Console.ReadLine());

            string star = "*";
            string space = " ";


            if (numTriange >= 0)
            {
                for (int k = 1; k <= numTriange + 1; k++)
                {
                    int numLines = k;

                    for (int i = 1; i < numLines; i++)
                    {
                        for (int j = i; j < numLines + numTriange - k; j++)
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
