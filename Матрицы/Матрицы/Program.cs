using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Матрицы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Исходная матрица: ");
            PMatrix(matrix);

            matrix = AddColumnZero(matrix);
            Console.WriteLine("Матрица после добавления столбца с нулями: ");
            PMatrix(matrix);
            Console.ReadKey();
        }
        static int[,] AddColumnZero(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            int[,]newMatrix = new int[row, col + 1];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    newMatrix[i, j] = matrix[i, j];
                }
            }
            return newMatrix;
        }
        static void PMatrix(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            for (int i = 0;i < row; i++)
            {
                for(int j = 0;j < col; j++)
                {
                    Console.WriteLine(matrix[i, j] + "");
                }
                Console.WriteLine();
            }
        }
        
    }
}
