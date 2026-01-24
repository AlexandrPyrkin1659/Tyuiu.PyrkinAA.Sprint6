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

          
            int[,] result = (int[,])matrix.Clone();

         
            List<int> fourthColumn = new List<int>();
            for (int i = 0; i < rows; i++)
            {
                fourthColumn.Add(matrix[i, 3]);
            }

        
            fourthColumn.Sort();

           
            for (int i = 0; i < rows; i++)
            {
                result[i, 3] = fourthColumn[i];
            }

            return result;
        }
    }
}