using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19
{
    /*
     * Добавьте в класс Program статический метод Multiply(), который возвращает результат умножения чисел 10 17 25. 
     * Тип возвращаемого значения метода Multiply() определите самостоятельно.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            int a = Multiply();
            Console.WriteLine(a);
        }
        /* Добавьте свой код ниже */
        public static int Multiply()
        {
            return 10 * 17 * 25;
        }
    }
}