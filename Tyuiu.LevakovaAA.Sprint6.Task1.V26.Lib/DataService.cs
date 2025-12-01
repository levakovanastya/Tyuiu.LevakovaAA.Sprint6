using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.LevakovaAA.Sprint6.Task1.V26.Lib
{
    public class DataService : ISprint6Task1V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len]; 
            for (int i = 0; i < len; i++)
            {
                int x = startValue + i;
                result[i] = Math.Round((2*Math.Cos(x)+2)/(2*x-1)+Math.Cos(x) - 5*x + 3, 2);
            }
            return result;
        }
    }
}
