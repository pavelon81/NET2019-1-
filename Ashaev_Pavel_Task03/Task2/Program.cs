using System;

// Программа, заменяет все положительные элементы в трёхмерном массиве на нули. 

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[,,] arr = new int[n, n, n];
            Console.WriteLine("Программа заменяет все положительные элементы в трёхмерном массиве {0}х{0}х{0} на нули. Все элементы целочисленные в диапазоне от -{1} до {1}", n, 50);
            CreadArr(n, arr);

            Console.WriteLine("Необработанный массив");
            Display(n, arr);
            ChangeArrNul(n, arr);

            Console.WriteLine("Обработанный массив");
            Display(n, arr);
        }

        public static void Display(int n, int[,,] arr)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Console.WriteLine("arr[{0},{1},{2}] = {3}", i, j, k, arr[i, j, k]); // вынести!
                    }
                }
            }
            Console.WriteLine("Press Enter.. ");
            Console.ReadLine();
        }

        public static void CreadArr(int n, int[,,] arr)
        {

            Console.WriteLine("Созданный массив случайных чисел:");
            // Создание массива
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        arr[i, j, k] = r.Next(100) - 50;
                    }
                }
            }
        }

        public static void ChangeArrNul(int n, int[,,] arr)
        {
            Console.WriteLine(" Обработанный массив случайных чисел:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        if (arr[i, j, k] < 0)
                        {
                            arr[i, j, k] = 0;
                        };

                        Console.WriteLine("arr[{0},{1},{2}] = {3}", i, j, k, arr[i, j, k]); //  вынести !!
                    }
                }
            }
        }


    }
}
