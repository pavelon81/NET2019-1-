using System;

// Программа, генерирует случайным образом элементы массива (число элементов в массиве и их тип определяются разработчиком), 
// определяет для него максимальное и минимальное значения, сортирует массив и выводит полученный результат на экран.

namespace Task1
{

    public class ProgramSortArray
    {
        static void Main(string[] args)
        {
            var n = 10; // Число элементов массива!
            var maxRandom = 100; // Дисперсия случайной величины

            Console.WriteLine("Программа выводит " + n + "- целочисленных элементов массива c дисперсией = " + maxRandom);
            InputArraySize(out n, out maxRandom);
            int[] arr = new int[n];
            RandomGetArr(arr, n, maxRandom);
            Console.WriteLine("Сгенерированный массива:");
            ShowArr(arr, n);

            SortArrUp(arr);
            Console.WriteLine("Минимальный элемент массива = " + arr[0]);
            Console.WriteLine("Максимальный элемент массива = " + arr[arr.Length - 1]);

            Console.WriteLine("Отсортированный массив:");
            ShowArr(arr, n);
        }


        public static void InputArraySize(out int n, out int maxRandom)
        {
            Console.Write("Введите число элементов массива: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Введите Максимальное значение дисперсии: ");
            maxRandom = int.Parse(Console.ReadLine());
        }


        public static void ShowArr(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            }
            Console.WriteLine("Press Enter..");
            Console.ReadLine();
        }

        public static void RandomGetArr(int[] arr, int n, int maxRandom)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(maxRandom);
            }
        }

        public static void SortArrUp(int[] arr)
        {
            int tempBuf;
            int[] arr1 = new int[arr.Length];

            // Метод пузырьковой сортировки
            int arrMin = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        tempBuf = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tempBuf;
                    }
                }
            }
        }
    }
}

