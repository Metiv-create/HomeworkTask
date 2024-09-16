using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex27
{
    /*
     * Внутри метода Main() считайте с клавиатуры строку, а затем выведите её в консоль в верхнем регистре 7 раз,
     * каждый раз с новой строки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            string a = Console.ReadLine();

             string word = a.ToUpper();
            for (int i = 0 ; i<7;i++)
            {
                Console.WriteLine(word);
            }
        }
    }
}
