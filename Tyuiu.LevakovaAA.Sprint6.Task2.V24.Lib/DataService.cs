using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.LevakovaAA.Sprint6.Task2.V24.Lib
{
    public class DataService : ISprint6Task2V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];
            for (int i = 0; i < len; i++)
            {
                int x = startValue + i;
                if (x == 2)
                    result[i] = 0;
                if (x != 2)
                    result[i] = Math.Round(Math.Sin(x) + (Math.Cos(x) + 1)/(2 - x) + 2 * x, 2);
            }
            return result;
        }
    }
}

