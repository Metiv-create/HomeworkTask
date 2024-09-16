using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20
{
    /*
     * Добавьте в класс Program статический метод Square(), который принимает один целочисленный параметр, а возвращает квадрат переданного параметра. 
     * Тип возвращаемого значения метода Square() определите самостоятельно. 
     * Внутри метода Main() вызовите метод Square() и передайте ему введенное с клавиатуры число. 
     * Выведите на экран результат работы метода Square().
     */

    public class Program
    {

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine("Введите число - ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Square(a);
            Console.WriteLine("Квадрат числа - " + b);
        }
        /* Добавьте свой код ниже */
        public static int Square(int num)
        {
            return num * num;
        }
    }
}