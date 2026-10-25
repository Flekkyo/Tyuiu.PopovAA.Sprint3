using Tyuiu.PopovAA.Sprint3.Task0.V9.Lib;
namespace Tyuiu.PopovAA.Sprint3.Task0.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Попов А. А. | ПИН-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Оператор цикла for                                                      *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Попов Артём Андреевич | ПИН-26-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая                          *");
            Console.WriteLine("* вычисляет сумму ряда по формуле, при x = 0,5.                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("X = 0.5");
            double x = 0.5;

            Console.WriteLine("Начальное значение = 1");
            int s = 1;

            Console.WriteLine("Конечное значение = 15");
            int f = 15;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumSeries(x, s, f));
        }
    }
}
