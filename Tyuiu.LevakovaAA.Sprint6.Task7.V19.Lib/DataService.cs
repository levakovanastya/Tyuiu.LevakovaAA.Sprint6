using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.LevakovaAA.Sprint6.Task7.V19.Lib
{
    public class DataService : ISprint6Task7V19
    {
        public int[,] GetMatrix(string path)
        {
            string content = File.ReadAllText(path);
            string[] rows = content.Split(new[] {"\r\n", "\n"}, StringSplitOptions.RemoveEmptyEntries);
            if (rows.Length == 0)
                return new int[0, 0];
            int row = rows.Length;
            int column = rows[0].Split(';').Length;
            int[,] matrix = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                string[] values = rows[i].Split(';');

                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = Convert.ToInt32(values[j].Trim());
                }
            }
            for (int j = 0; j < column; j++)
            {
                if (matrix[1, j] % 2 == 0)
                {
                    matrix[1, j] = 2;
                }
            }
            return matrix;
        }
    }
}
