using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PopovAA.Sprint3.Task7.V30.Lib
{
    public class DataService : ISprint3Task7V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (Math.Sin(i) + 2 != 0)
                {
                    res[count] = Math.Round((5 * i + 2.5) / (Math.Sin(i) + 2) + 2 * i + 2, 2);
                }
                else
                {
                    res[count] = 0;
                }
                count++;
                
            }
            return res;
        }
    }
}
