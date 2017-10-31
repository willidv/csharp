using System;
using System.Collections.Generic;
namespace basic_13
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static void Print()
        {
            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintOdds()
        {
            for (int i = 0; i < 255; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void Sum()
        {
            int Sum = 0;
            for (int i = 0; i < 255; i++)
            {
                Sum += i;
                Console.WriteLine("New Number:" + i + " " + "Sum:" + Sum);
            }
        }
        public static void Iterate(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
        public static void FindMax(int[] arr)
        {
            int Max = 0;
            foreach (int i in arr)
            {
                if (i > Max)
                {
                    Max = i;
                }
            }
            Console.WriteLine(Max);
        }
        public static void FindAvg(int[] arr)
        {
            int Avg = 0;
            foreach (int i in arr)
            {
                Avg += i;
            }
            Avg = Avg / arr.Length;
            Console.WriteLine(Avg);
        }
        public static void ArrWithOdds()
        {
            List<int> y = new List<int>();
            for (int i = 0; i <= 255; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    y.Add(i);
                }
            }
        }
        public static void Greater(int[] arr, int y)
        {
            int num = 0;
            foreach (int i in arr)
            {
                if (i > y)
                {
                    num += 1;
                }
            }
            Console.WriteLine(num);
        }
        public static void Squares(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * arr[i];
                Console.WriteLine(arr[i]);
            }
        }
        public static void Negatives(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = 0;
                }
            }
        }
        public static void MinMaxAvg(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            int avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                avg += arr[i] / arr.Length;
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(avg);
        }
        public static void Shift(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i + 1];
                arr[arr.Length - 1] = 0;
                Console.WriteLine(arr);
            }
        }
        public static void NumberToString(List<object> NumberToString)
        {
            for (int i = 0; i < NumberToString.Count; i++)
            {
                if ((int)NumberToString[i] < 0)
                {
                    NumberToString[i] = "Dojo";
                }
            }

        }
    }
}