using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex22
{
    /*
     * Добавьте в класс Program статический метод Add(), который принимает один строковый параметр, 
     * выводит в консоль 1 раз переданный параметр, а возвращает переданный параметр трижды, склеенный с самим собой. 
     * Тип возвращаемого значения определите сами. 
     * Внутри метода Main() вызовите метод Add и передайте ему введённую с клавиатуры строку, сохраните результат 
     * этого вызова в отдельную переменную и выведите её на экран.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine("Введите строку");
            string a = Console.ReadLine();
            Add(a);
        }
        /* Добавьте свой код ниже */
        public static void Add(string a)
        {
            Console.Write(a);
            Console.Write(a);
            Console.Write(a);
        }
    }
}