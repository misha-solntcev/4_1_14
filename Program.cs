using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*В ариант 14
Для заданной матрицы A(N, N) найдите хотя бы одно K, такое, что K-я строка
матрицы совпадает с K-м столбцом.*/

namespace _4_1_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,]
            {
                { 8, 0, 6, -4, 8 },
                { 4, 1, 6, 7, 8 },
                { 7, 8, 2, 0, 2 },
                { 12, 0, 3, -4, 5 },
            };
            int n = arr.GetLength(0);
            int m = arr.GetLength(1);
                        
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if ((i == j) & (j == arr[i,j]))
                        Console.WriteLine($"arr[{i}, {j}] = {arr[i, j]}");
            Console.ReadKey();
        }
    }
}
