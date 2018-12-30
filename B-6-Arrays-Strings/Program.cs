using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Ex3ByBubbleSort();
            //Exercise5();
            //Exercise6();
            var numbers = GetInitialValues();
            PrintValues(numbers);
            Play(numbers);

            Console.ReadKey();
        }

        private static void Exercise1()
        {
            int[] mass = new int[6];
            var rand = new Random();

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rand.Next(100);
                Console.WriteLine($" mass{i} = {mass[i]}");
            }

        }

        private static void Exercise2()
        {
            int[,] mass = new int[3, 3];
            var rand = new Random();
            int maxValue = 0;

            for (int i = 0; i < mass.GetLength(0); i++)
            {

                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = rand.Next(100);

                    if (maxValue < mass[i, j])
                        maxValue = mass[i, j];

                }
                Console.WriteLine(maxValue);

                maxValue = 0;
            }

        }

        private static void Exercise3()
        {
            int[] mass = new int[5];
            var rand = new Random();

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rand.Next(100);
                Console.Write(mass[i] + " ");
            }

            Array.Sort(mass);
            Console.WriteLine();

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + " ");
            }
        }

        public static void Ex3ByBubbleSort()
        {
            {
                Console.WriteLine("Сколько чисел будем сортировать?");
                int N = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите числа для сортировки:");
                int[] mas = new int[N];
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = Convert.ToInt32(Console.ReadLine());
                }
                BubbleSort(mas);
                Console.WriteLine("После сортировки:");
                for (int i = 0; i < mas.Length; i++)
                {
                    Console.WriteLine(mas[i]);
                }
                Console.ReadLine();
            }
        }



        static int[] BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }



        private static int[,] GetInitialValues()
        {
            int[,] arr = new int[4, 4];
            int number = 1;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = number++;
                }
            }

            arr[3, 3] = 0;
            return arr;
        }

        private static void PrintValues(int[,] arr)
        {
            Console.Clear();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(String.Format("{0,4}", arr[i, j]));
                }

                Console.WriteLine();
            }
        }

        private static void Play(int[,] arr)
        {
            var zeroI = 3;
            var zeroJ = 3;

            while (true)
            {
                char movement = Convert.ToChar(Console.ReadLine());
                var i = zeroI;
                var j = zeroJ;

                switch (movement)
                {
                    case 'a':
                        j--;
                        break;
                    case 's':
                        i++;
                        break;
                    case 'd':
                        j++;
                        break;
                    case 'w':
                        i--;
                        break;
                    default:
                        break;
                }

                var swap = arr[i, j];
                arr[i, j] = arr[zeroI, zeroJ];
                arr[zeroI, zeroJ] = swap;

                zeroI = i;
                zeroJ = j;

                PrintValues(arr);
            }
        }



        private static void Exercise5()
        {
            Console.WriteLine("Введите предложение");
            string sentence = Console.ReadLine();

            if (sentence.Length < 13)
                Console.WriteLine(sentence);
            else
            {
                sentence = sentence.Substring(0, 13);
                Console.WriteLine($"{sentence}...");
            }

        }

        private static void Exercise6()
        {
            Console.WriteLine("Введите стихотворние");
            string poem = Console.ReadLine();
            poem = poem.Replace("о", "а")
                       .Replace("л", "ль")
                       .Replace("ть", "т")
                       .Replace(';', '\n');
            Console.WriteLine(poem);
        }
    }
}