using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PopovAA.Sprint3.Task6.V8.Lib
{
    public class DataService : ISprint3Task6V8
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int j = 12; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        res += j;
                    }
                }
            }
            return res;
        }
    }
}
