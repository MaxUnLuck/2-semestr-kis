using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3Sulemanov
{
    internal class Program
    {
        // Создание матрицы
        public static T[,] CreateMatrix<T>(int rows, int cols)
        {
            return new T[rows, cols];
        }

        // Вывод матрицы на экран
        public static void PrintMatrix<T>(T[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            Console.WriteLine("Матрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        // Подсчет произведения по каждому столбцу
        public static T[] ColumnProduct<T>(T[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            T[] products = new T[cols];
            for (int j = 0; j < cols; j++)
            {
                products[j] = (T)(object)1;
            }
            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    dynamic val = matrix[i, j];
                    products[j] *= val;
                }
            }
            return products;
        }
        // Определение номера строки с минимальным значением суммы элементов
        public static int MinRowIndex<T>(T[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            if (rows == 0)
            {
                Console.WriteLine("Матрица пуста.");
                return -1;
            }
            dynamic minSum = CalculateRowSum<T>(matrix, 0);
            int minRowIndex = 0;
            for (int i = 1; i < rows; i++)
            {
                dynamic rowSum = CalculateRowSum<T>(matrix, i);
                if (rowSum < minSum)
                {
                    minSum = rowSum;
                    minRowIndex = i;
                }
            }
            return minRowIndex;
        }
        // Вспомогательная функция для вычисления суммы элементов строки
        private static dynamic CalculateRowSum<T>(T[,] matrix, int rowIndex)
        {
            int cols = matrix.GetLength(1);
            dynamic rowSum = (dynamic)0;
            for (int j = 0; j < cols; j++)
            {
                rowSum += (dynamic)matrix[rowIndex, j];
            }
            return rowSum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, мы изучаем шаблонные функции:");
            int[,] list = CreateMatrix<int>(5, 5);
            Random random = new Random();
            for (int i = 0; i < list.GetLength(0); i++)
            {
                for (int j = 0;j < list.GetLength(1); j++)
                {
                    list[i, j] = random.Next(-10, 10);
                }
            }
            PrintMatrix(list);
            Console.WriteLine("номер строки с минимальным значением суммы элементов: " + MinRowIndex(list));
            Console.WriteLine("Произведение матрицы:");
            int[] newList = ColumnProduct(list);
            for (int i = 0; i < newList.Length; i++)
            {
                Console.WriteLine(newList[i]);
            }
        }
    }
}
