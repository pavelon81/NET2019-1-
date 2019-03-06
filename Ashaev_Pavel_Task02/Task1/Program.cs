using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine( "Программа определения площади прямоугольника со сторонами a и b. Допускается ввод только целочисленных значений." );
            Console.WriteLine( "Enter side 'a' ");
            int sideA = Convert.ToInt32( Console.ReadLine() );

            if (sideA <= 0)
            {
                Console.WriteLine( "Error! 'a' will be > 0 " );
            } 

            Console.WriteLine( "Enter side 'b'" );
            int sideB = Convert.ToInt32( Console.ReadLine() );
            if (sideB <= 0)
            {
                Console.WriteLine( "Error! 'b' will be > 0 " );
            }
            int areaOfRectangle = sideA * sideB;
            Console.WriteLine( "The Area Of a Rectanglee = " + areaOfRectangle );
            Console.ReadLine();
        }
    }
}
