using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23
{
    /*
     * Выведите в консоль квадрат 10 на 10, который состоит только из букв Ъ.
     * Для решения используйте цикл while.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int row = 0;
            while (row < 10)
            {
                int column = 0;
                while (column < 10)
                {
                    Console.Write("Ъ");
                    column++;
                }
                Console.WriteLine();
                row++;
            }
        }
    }
}
