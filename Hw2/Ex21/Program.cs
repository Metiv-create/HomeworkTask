using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t16
{
    /*
     * Добавьте в класс Program статический метод Twice(), который принимает один 
     * строковый параметр, а выводит на экран переданный параметр дважды, каждый раз 
     * с новой строки. Тип возвращаемого значения метода Twice() определите самостоятельно. 
     * Внутри метода Main() вызовите метод Twice() и передайте ему введённую с клавиатуры строку.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine("Введите строку ");
            string a = Console.ReadLine();
            Twice(a);
        }
        /* Добавьте свой код ниже */
        public static void Twice(string a)
        {
            Console.WriteLine(a);
            Console.WriteLine(a);
        }

    }
}