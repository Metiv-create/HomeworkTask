using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ex17
{
    /*
     * Добавьте в класс Program статический метод TriplePrinter(), который 3 раза выводит 
     * в консоль фразу "Просто не значит не правильно", каждую с новой строки. 
     * Тип возвращаемого значения метода TriplePrinter() сделайте пустым.
     */

    public class Program
    {
        static string a ="Просто не значит не правильно";
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            TriplePrinter();
        }
        public static void TriplePrinter()
        {
            Console.WriteLine(a);
            Console.WriteLine(a);
            Console.WriteLine(a);
        }
    }
}