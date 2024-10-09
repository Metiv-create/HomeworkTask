using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace l6t8
{
    /*
     * Внутри класса Program создайте статический метод Dif, который:
     *      1) Ничего не возвращает.
     *      2) Имеет два входящих целочисленных параметра и один исходящий.
     *      3) Исходящему параметру должен присваиваться результат разности первого и второго входящего параметра.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int result;
            Dif(5,2,out result);
            Console.WriteLine($"Разность: {result}"); 
        }
        public static void Dif(int a, int b, out int diff)
        {
            diff = a - b;
        }
    }
}
