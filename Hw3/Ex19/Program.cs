using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19
{
    /*
     * Создайте статический метод SortedTrio(), который принимает три целочисленных параметра и выводит их в консоль в порядке убывания.
     * Вывод чисел должен осуществляться в одной строке через пробел с последующим переносом указателя на новую строку.
     * Внутри метода Main() вызовите метод SortedTrio() со следующими значениями аргументов:
     *    1) 11,0,16.
     *    2) 12,-156,5.
     *    3) 33, 33,12.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            SortedTrio(11,0,16);
            SortedTrio(12,-156,5);
            SortedTrio(33,33,12);

        }

        /* Добавьте свой код ниже */
        public static void SortedTrio(int a, int b, int c)
        {
            int[] num = {a,b,c};
            Array.Sort(num);
            Array.Reverse(num);
            Console.WriteLine(string.Join(" ",num));
        }
    }
}
