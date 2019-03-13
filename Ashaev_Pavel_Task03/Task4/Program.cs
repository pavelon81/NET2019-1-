using System;

// Определить сумму элементов массива, стоящих на чётных позициях.
// Элемент двумерного массива считается стоящим на чётной позиции, если сумма номеров его позиций по обеим размерностям является чётным числом
// (например, [1,1] – чётная позиция, а [1,2] - нет).   

namespace Task4
{
    class Program
    {

        public static void InputArraySize(out int n, out int maxRandom) // Ввод размера массива
        {
            Console.Write("Введите число элементов массива: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Введите Максимальное значение дисперсии: ");
            maxRandom = int.Parse(Console.ReadLine());
        }



        public static void RandomGetArr2(int[,] arr, int n, int maxRandom)
        {
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = r.Next(maxRandom);
                }
            }
        }

        public static void ShowArray2(int[,] arr, int n)
        {
            Console.WriteLine("Массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("arr[{0},{1}] = {2}", i, j, arr[i, j]);
                }
            }
            Console.WriteLine("Press Enter..");
            Console.ReadLine();
        }

        public static void GetSummEvenPosition(int[,] arr, int n)
        {
            int summ = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    int result = (i + j) % 2;

                    if (result == 0)
                    {
                        summ = arr[i, j] + summ;
                    }
                }
            }
            Console.WriteLine("Cумма элементов массива, стоящих на чётных позициях = " + summ);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int n = 0;
            int maxRandom = 0;
            Console.WriteLine("Определение суммы элементов массива, стоящих на чётных позициях");

            InputArraySize(out n, out maxRandom); //  Ввод размера массива и дисперсии

            int[,] arr = new int[n, n];

            RandomGetArr2(arr, n, maxRandom);
            ShowArray2(arr, n);
            GetSummEvenPosition(arr, n);
        }
    }
}
