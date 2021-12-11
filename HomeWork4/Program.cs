using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork4 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static int Task1(int[] mas)
        {
            int min = mas[0];

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < min)
                {
                    min = mas[i];
                }
            }

            return min;
        }

        static int Task2(int[] mas)
        {
            int max = mas[0];

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > max)
                {
                    max = mas[i];
                }
            }

            return max;
        }

        static int Task3(int[] mas)
        {
            int min = mas[0];
            int indexMin = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < min)
                {
                    min = mas[i];
                    indexMin = i;
                }
            }

            return indexMin + 1;
        }

        static int Task4(int[] mas)
        {
            int max = mas[0];
            int indexMax = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < max)
                {
                    max = mas[i];
                    indexMax = i;
                }
            }

            return indexMax + 1;
        }

        static int Task5(int[] mas)
        {
            int sum = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += mas[i];
                }
            }

            return sum;
        }

        static void Task6(int[] mas)
        {
            int i = 0;
            int j = mas.Length - 1;
            while (i < j)
            {
                int tmp = mas[i];
                mas[i] = mas[j];
                mas[j] = tmp;
                i++;
                j--;
            }
        }

        static int Task7(int[] mas)
        {
            int count = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }

        static void Task8(int[] mas)
        {
            int i = 0;
            int j = mas.Length / 2;

            while (i < mas.Length / 2)
            {
                int tmp = mas[i];
                mas[i] = mas[j];
                mas[j] = tmp;
                i++;
                j++;
            }
        }

        static void Swap(ref int i, ref int j)
        {
            int t = i;
            i = j;
            i = t;
        }

        static void Task9(int[] mas)
        {
            int current = 0;
            int min = Task1(mas);
            if (min != current)
            {
                Swap(ref mas[min], ref mas[current]);
            }
        }


        public static void Main(string[] args)
        {
            int N = 10;
            int[] array = new int[N];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-20, 20);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();


            //Console.WriteLine(Task1(array));
            //Console.WriteLine(Task2(array));
            //Console.WriteLine(Task3(array));
            //Console.WriteLine(Task4(array));
            //Console.WriteLine(Task5(array));
            //Task6(array);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"{array[i]} ");
            //}
            //Console.WriteLine(Task7(array));
            //Task8(array);
            Task9(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}