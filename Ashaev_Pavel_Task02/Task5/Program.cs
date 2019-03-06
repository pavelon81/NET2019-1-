using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа выводит на экран сумму всех чисел меньше 1000, кратных 3, или 5.");
            var n = 1000;
            var sum = 0;

            Console.WriteLine(" Press 'Enter' ");
            Console.ReadLine();

            for (int i = 1; i <= n; i++) 
            {
                int result3 = i % 3;
                int result5 = i % 5;

                if ( (result3 == 0) | (result5 == 0) )
                {
                    sum = i + sum;
                }
            }

            Console.WriteLine("Сумма всех чисел меньше 1000, кратных 3, или 5 = " + sum);
            Console.ReadLine();
        }
    }
}
