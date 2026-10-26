using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PopovAA.Sprint3.Task3.V14.Lib
{
    public class DataService : ISprint3Task3V14
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            string res = "";
            foreach (char i in value)
            {
                if (i == replaceable)
                {
                    res += replacement;
                }
                else
                {
                    res += i;
                }
            }
            return res;
        }
    }
}
