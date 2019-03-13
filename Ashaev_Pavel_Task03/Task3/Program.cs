using System;

// Программа, заменяет все положительные элементы в трёхмерном массиве на нули

namespace Task3
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = 0;
            int maxRandom = 0;
            int summ = 0;

            InputArraySize(out n, out maxRandom); //  Ввод размера массива и дисперсии

            int[] arr = new int[n];

            RandomGetArr(arr, maxRandom);
            ShowArray(arr);
            GetSummPositiveElement(arr, out summ);
            Console.WriteLine("Сумма неотрицательных элементов = " + summ);
            Console.ReadLine();

        }

        public static void InputArraySize(out int n, out int maxRandom) // Ввод размера массива
        {
            Console.Write("Введите число элементов массива: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Введите Максимальное значение дисперсии: ");
            maxRandom = int.Parse(Console.ReadLine());
        }

        public static void RandomGetArr(int[] arr, int maxRandom)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(maxRandom);
            }
        }

        public static void ShowArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            }
            Console.WriteLine("Press Enter..");
            Console.ReadLine();

        }

        public static void GetSummPositiveElement(int[] arr, out int summ)
        {
            summ = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    summ = arr[i]++;
                }
            }
        }


    }
}
