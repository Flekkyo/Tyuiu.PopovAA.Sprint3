using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PopovAA.Sprint3.Task4.V29.Lib
{
    public class DataService : ISprint3Task4V29
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                else
                {
                    res += (Math.Cos(i) / i);
                }
            }
            return Math.Round(res, 1);
        } 
    }
}
