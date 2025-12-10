using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.LevakovaAA.Sprint6.Task4.V19.Lib
{
    public class DataService : ISprint6Task4V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                result[count] = Math.Round((5*x + 2.5)/(Math.Sin(x)-2) +2, 2);
                count++;
            }
            return result;
        }
    }
}