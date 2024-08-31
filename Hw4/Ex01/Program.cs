using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    /*
     * Внутри метода Main() создайте программу, которая считывает 5 чисел с клавиатуры
     * и выводит в консоль наименьшее из них.
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int a =int.Parse(Console.ReadLine());
            int b =int.Parse(Console.ReadLine());
            int c =int.Parse(Console.ReadLine());
            int d =int.Parse(Console.ReadLine());
            int e =int.Parse(Console.ReadLine());
            
            if (a < b && a < c && a < d && a <e)
            {
                Console.WriteLine(a);
            }
            else if (b < a && b < c && b < d && b <e)
            {
                Console.WriteLine(b);
            }
            else if (c < b && c < a && c < d && c <e)
            {
                Console.WriteLine(c);
            }
            else if(d < b && d < c && d < a && a <e)
            {
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine(e);
            }
        }
    }
}
