using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30
{
    /*
     * Создайте публичный статический класс SupportPrinterClass в том же файле и namespace что и класс Program.
     * Добавьте в созданный класс 4 публичных метода:
     *      1) Printer, который должен принимать в качестве входящего параметра строку и выводить её на экран 1 раз.
     *      2) DoublePrinter, который должен принимать в качестве входящего параметра строку и выводить её на экран 2 раза.
     *      3) TriplePrinter, который должен принимать в качестве входящего параметра строку и выводить её на экран 3 раз.
     *      4) MultiPrinter, который должен принимать в качестве входящего параметра строку и число раз, которое её надо вывести на экран.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            MorePrinte.MultiPrinter("wvgwegvew",9);
        }
    }
    /* Добавьте свой код ниже */
    public static class MorePrinte
    {
        public static void Printer(string text)
        {
            Console.WriteLine(text);
        }
        public static void DoublePrinter(string text)
        {
            Console.WriteLine(text);
            Console.WriteLine(text);
        }
        public static void TriplePrinter(string text)
        {
            Console.WriteLine(text);
            Console.WriteLine(text);
            Console.WriteLine(text);
        }
        public static void MultiPrinter(string text, int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(text);
            }
        }
    }
}