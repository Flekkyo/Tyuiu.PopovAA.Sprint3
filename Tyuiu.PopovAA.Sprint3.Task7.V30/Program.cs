using Tyuiu.PopovAA.Sprint3.Task7.V30.Lib;
namespace Tyuiu.PopovAA.Sprint3.Task7.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Попов А. А. | ПИН-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Попов Артём Андреевич | ПИН-26-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Начальное значение = -5");
            int s = -5;

            Console.WriteLine("Конечное значение = 5");
            int f = 5;

            double[] res = ds.GetMassFunction(s, f);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+-----------------+-----------------+");
            Console.WriteLine("|        X        |       f(x)      |");
            Console.WriteLine("+-----------------+-----------------+");

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine("| {0, 15} | {1, 15:F2} |", s, res[i]);
                s++;
            }

            Console.WriteLine("+-----------------+-----------------+");
        }
    }
}
