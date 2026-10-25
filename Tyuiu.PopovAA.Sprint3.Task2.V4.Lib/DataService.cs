using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PopovAA.Sprint3.Task2.V4.Lib
{
    public class DataService : ISprint3Task2V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double res = 1;
            do
            {
                res *= Math.Pow(startValue / Math.Pow(Math.Sin(1), -7), -2);
                startValue += 1;
            } while (startValue <= stopValue);
            return Math.Round(res, 3);
        }
    }
}
