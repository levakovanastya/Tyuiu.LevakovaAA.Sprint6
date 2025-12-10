using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.LevakovaAA.Sprint6.Task6.V10.Lib
{
    public class DataService : ISprint6Task6V10
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("w"))
                    {
                        string[] words = line.Split(' ');

                        foreach (string w in words)
                        {
                            if (w.Contains("w"))
                            {
                                resStr = resStr + " " + w;
                            }
                        }
                    }                  
                }
            }
            return resStr.TrimStart();
        }
    }
}
