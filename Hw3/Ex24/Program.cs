using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex24
{
    /*
     Выведите в консоль таблицу умножения 10 на 10. Каждое число в строке разделите пробелом.
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int row = 1;
            while (row <= 10)
            {
                int column = 1;
                while (column <=10)
                {
                    Console.Write(row * column+ " ");
                    column++;
                }
                Console.WriteLine();
                row++;
            }
        }
    }
}
