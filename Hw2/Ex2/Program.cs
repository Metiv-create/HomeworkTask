using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    /*
     * Внутри метода Main() объявите целочисленную переменную, имя придумайте сами.
     * Считайте с клавиатуры целое число и присвойте его своей переменной. 
     * Выведите на экран квадрат введенного числа.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int a = Convert.ToInt32(Console.ReadLine());
            a = a * a;
            Console.WriteLine(a);
        }
    }
}