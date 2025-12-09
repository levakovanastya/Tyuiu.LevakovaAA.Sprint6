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
            int[] secondColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                secondColumn[i] = resultMatrix[i, 1];
            }
            Array.Sort(secondColumn);
            for (int i = 0; i < rows; i++)
            {
                resultMatrix[i, 1] = secondColumn[i];
            }

            return resultMatrix;
        }
    }
}
