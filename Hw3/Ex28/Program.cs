using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28
{
    /*
     * Внутри метода Main() считайте с клавиатуры строку, а затем выведите её в консоль в нижнем регистре 5 раз,
     * каждый раз с новой строки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
             string a = Console.ReadLine();

             string word = a.ToLower();
            for (int i = 0 ; i<5;i++)
            {
                Console.WriteLine(word);
            }
        }
    }
}
