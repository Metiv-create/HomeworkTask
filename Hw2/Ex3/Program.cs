using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    /*
     * Внутри метода Main() последовательно считайте 3 числа и присвойте их
     * трем целочисленным переменным с произвольными именами. 
     * Выведите на экран сумму этих трех чисел.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            int d = a + b + c;
            Console.WriteLine(d);
        }
    }
}