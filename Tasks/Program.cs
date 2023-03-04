using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tasks
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            int[,] arr = new int[5, 5];
            Random rand = new Random();
            IEnumerable<int> ConvertedArray = arr.Cast<int>();
            int min = ConvertedArray.Min();
            int max = ConvertedArray.Max();
            int Ind_min_i = 0, Ind_max_i = 0, Ind_min_j = 0, Ind_max_j = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        Ind_min_i = i;
                        Ind_min_j = j;
                    }
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        Ind_max_i = i;
                        Ind_max_j = j;
                    }
                    Write($"{arr[i, j]}\t");
                }
                WriteLine();
            }
            WriteLine("Минимальный элемент в массиве: " + min);
            WriteLine("Максимальный элемент в массиве: " + max);

            int sum = 0;
            bool count = false;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i == Ind_min_i && j == Ind_min_j) || (i == Ind_max_i && j == Ind_max_j))
                    {
                        if (count)
                        {
                            count = false;w
                            continue;
                        }
                        else
                        {
                            count = true;
                            continue;
                        }
                    }
                    if (count)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            WriteLine($"Сумма элементов массива между минимальным и максимальным элементами: {sum}");
        }*/

        static void Main(string[] args)
        {
            int[,] arr = new int[4, 4];
            int[,] brr = new int[4, 4];
            int[,] сrr = new int[4, 4];
            Random rand = new Random(0);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                    Write($"{arr[i, j]}\t");
                    brr[i, j] = arr[i, j];
                }
                WriteLine(); WriteLine();
            }
            Write("Число на которые умножится матрица: ");
            int n =Convert.ToInt32(ReadLine());
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    brr[i, j] *= n;
                    Write($"{brr[i, j]}\t");
                }
                WriteLine(); WriteLine();
            }
            WriteLine("Сложение первых двух матриц:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    сrr[i, j] = brr[i, j] + arr[i, j];
                    Write($"{сrr[i, j]}\t");
                }
                WriteLine(); WriteLine();
            }
            WriteLine("Умножение первой и третей матрицы:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    сrr[i, j] *= arr[i, j];
                    Write($"{сrr[i, j]}\t");
                }
                WriteLine(); WriteLine();
            }
        }
    }
}