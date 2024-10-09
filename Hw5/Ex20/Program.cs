using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t20
{
    /*
     * Измените шаблон таким образом, чтобы при выводе переменных в консоль количество цифр после запятой совпадало с числом в названии переменной, содержащей это число.
     * Остальные элементы шаблона изменять нельзя, округление при выводе допустимо.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            double d0 = 89 / 7d;
            double d1 = 89 / 17d;
            double d7 = 300 / 3d;
            double d5 = 54d / d0;

            Console.WriteLine($"{d0:F0}");
            Console.WriteLine($"{d1:F1}");
            Console.WriteLine($"{d7:F7}");
            Console.WriteLine($"{d5:F5}");

        }
    }
}
