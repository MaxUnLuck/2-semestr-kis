using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppSulemanov4
{
    internal class MyMatrix<T>
    {
        uint size;
        T A;
        T B;
        public T[,] matrix;
        public MyMatrix(uint size, T A, T B)
        {
            this.size = size;
            this.A = A;
            this.B = B;
            matrix = new T[size, size];
        }
        public void SetCell(T element, uint x, uint y)
        {
            matrix[x, y] = element;
        }
        void DiagonalMinFill(T[,] matrix)
        {
            T minnum = matrix[0, 0];
            for (int i = 0; i < size; i++) // нахождение минимального числа модуля элемента главной диоганали матрицы
            {
                if (Convert.ToInt32(minnum) < Convert.ToInt32(matrix[i, i]))
                {
                    minnum = matrix[i, i];
                }
            }
            for (int i = 0; i < size; i++) // заполнение диоганали минимальным элементом
            {
                matrix[i, i] = minnum;
            }
        }
        void TopFillA(T[,] matrix, T element)
        {
            for (int i = 0; i < size; i++) // длина диоганали // замена всех элементов матрицы выше главной диоганали на A
            {
                for (int j = 0; j < size; j++) // строка
                {
                    for (int k = 0; k < size; k++) // столбец
                    {
                        if (j < k)
                        {
                            matrix[j, k] = element;
                        }
                    }
                }
            }
        }
        void BottomFillB(T[,] matrix, T element)
        {
            for (int i = 0; i < size; i++) // длина диоганали // замена всех элементов матрицы ниже главной диоганали на B
            {
                for (int j = 0; j < size; j++) // строка
                {
                    for (int k = 0; k < size; k++) // столбец
                    {
                        if (j > k)
                        {
                            matrix[j, k] = element;
                        }
                    }
                }
            }
        }
        public void EnabelFunction()
        {
            DiagonalMinFill(matrix);
            TopFillA(matrix, A);
            BottomFillB(matrix, B);
        }
    }
}
