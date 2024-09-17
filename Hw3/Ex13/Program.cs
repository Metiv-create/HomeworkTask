using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    /*
     * Внутри метода Main() реализуйте следующую логику работы программы:
     *      1) Объявите 3 переменные и присвойте им значения, считанные с клавиатуры.
     *      2) Если среди введенных значений есть одинаковые, то необходимо вывести их на экран через пробел.
     *      3) Выведите в консоль фразу "Все разные", если все 3 переменные содержат различные значения.
     *      4) Если все 3 переменные одинаковые, то выведите их все в консоль через запятую.
     * Тип и имена переменных определите самостоятельно.
     */
    
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
            if (a == b && b == c && a == c)
            {
                Console.WriteLine($"{a},{b},{c}");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine($"{a} {b} {c}");
            }
            else
            {
                Console.WriteLine("все разные");
            }
        }
    }
}
