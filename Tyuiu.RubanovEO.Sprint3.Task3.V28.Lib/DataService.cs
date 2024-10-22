
using System.Runtime.InteropServices.Marshalling;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RubanovEO.Sprint3.Task3.V28.Lib
{
    public class DataService : ISprint3Task3V28
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string ans = "";
            foreach ( char c  in value)
            {
                if (Char.IsDigit(c))
                {
                    ans = value.Replace(c, item);
                }
            }
            return ans;
        }
    }
}
