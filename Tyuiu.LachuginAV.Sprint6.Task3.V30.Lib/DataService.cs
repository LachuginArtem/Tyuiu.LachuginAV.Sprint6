using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.LachuginAV.Sprint6.Task3.V30.Lib
{
    public class DataService : ISprint6Task3V30
    {
        public int[,] Calculate(int[,] matrix)
        {

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (matrix[4, i] % 2 == 0)
                    matrix[4, i] = 0;
            }
            return matrix;
            int rows = matrix.GetUpperBound(0) + 1; // количество строк
            int colums = matrix.Length / rows; //количестов столбцов



            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if ((matrix[i, j] <= 100) && (matrix[i, j] >= -100))
                    {
                        if ((matrix[4, i] % 2) == 0)
                        {
                            matrix[4, i] = 0;
                        }
                    }
                }

            }
            return matrix;
        }
    }
}
