using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t13
{
    /*
     * Добавьте в класс Program статический метод MirrorTriplePrinter(), который 3 раза выводит 
     * в консоль фразу, введенную с клавиатуры, каждую с новой строки. 
     * Тип возвращаемого значения метода MirrorTriplePrinter() сделайте пустым.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            MirrorTriplePrinter();
        }
        /* Добавьте свой код ниже */
        public static void MirrorTriplePrinter()
        {
            Console.WriteLine();
            string a = Console.ReadLine();

            Console.WriteLine(a);
            Console.WriteLine(a);
            Console.WriteLine(a);
        }
    }
}