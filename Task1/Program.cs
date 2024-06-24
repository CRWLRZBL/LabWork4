using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк массива");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов массива");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты y");
            int y = int.Parse(Console.ReadLine());
            int[,] array = new int[n, m];

            for (int i = 0; i < n; i++)

                for (int j = 0; j < m; j++)
                {
                    array[i, j] = -1;
                }
            Console.Write("Введите количество препятствий: ");
            int.Parse(Console.ReadLine());
            Random random = new Random();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int row = random.Next(n);
                    int col = random.Next(m);
                    array[row, col] = -2;
                }
            }
            int finishRow = random.Next(n);
            int finishCol = random.Next(m);
            array[finishRow, finishCol] = 99;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{array[i, j]}\t");

                }
            }
            Console.WriteLine("\nВведите количество строк массива");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов массива");
            int M = int.Parse(Console.ReadLine());
            int[,] h = new int[N, m];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    h[i, j] = -1;
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write($"{array[i, j]}");
                }
                Console.WriteLine();
            }
                for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    h[i, j] = Math.Abs(i - finishRow) + Math.Abs(j - finishCol);
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write($"{h[i, j]}");
                }
                Console.WriteLine();
            }

        }
    }
}

