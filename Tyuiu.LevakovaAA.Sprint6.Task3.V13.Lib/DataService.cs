using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.LevakovaAA.Sprint6.Task3.V13.Lib
{
    public class DataService : ISprint6Task3V13
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] resultMatrix = (int[,])matrix.Clone();

            SortByColumn(resultMatrix, 1);

            return resultMatrix;
        }
         

        private void SortByColumn(int[,] matrix, int columnIndex)
        {
            int rows = matrix.GetLength(0);
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    if (matrix[j, columnIndex] > matrix[j + 1, columnIndex])
                    {
                        SwapRows(matrix, j, j + 1);
                    }
                }
            }
        }

        private void SwapRows(int[,] matrix, int row1, int row2)
        {
            int cols = matrix.GetLength(1);

            for (int col = 0; col < cols; col++)
            {
                int temp = matrix[row1, col];
                matrix[row1, col] = matrix[row2, col];
                matrix[row2, col] = temp;
            }
        }
    }
}
