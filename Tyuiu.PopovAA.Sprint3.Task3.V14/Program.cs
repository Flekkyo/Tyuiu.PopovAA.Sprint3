using Tyuiu.PopovAA.Sprint3.Task3.V14.Lib;
namespace Tyuiu.PopovAA.Sprint3.Task3.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Попов А. А. | ПИН-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Оператор цикла foreach                                                  *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Попов Артём Андреевич | ПИН-26-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить буквы d                                 *");
            Console.WriteLine("* на ’ в строке: dgt ghedd bed.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string str = "dgt ghedd bed";

            char first = 'd';

            char second = '’';

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.ReplaceCharInString(str, first, second));
        }
    }
}
