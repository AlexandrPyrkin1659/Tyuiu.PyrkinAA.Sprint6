using System;
using System.Collections.Generic;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PyrkinAA.Sprint6.Task3.V27.Lib
{
    public class DataService : ISprint6Task3V27
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Преобразуем матрицу в список строк для сортировки
            var rowsList = new List<int[]>();

            for (int i = 0; i < rows; i++)
            {
                var row = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    row[j] = matrix[i, j];
                }
                rowsList.Add(row);
            }

            // Сортируем по 4-му столбцу (индекс 3)
            rowsList.Sort((row1, row2) => row1[3].CompareTo(row2[3]));

            // Создаем новую матрицу с отсортированными строками
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = rowsList[i][j];
                }
            }

            return result;
        }
    }
}