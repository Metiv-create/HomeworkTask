using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23
{
    /*
     * Добавьте в класс Program статический метод MinutesToSeconds(), который принимает количество минут, а возвращает количество секунд. 
     * Внутри метода Main() вызовите метод MinutesToSeconds(), передав ему число 152 в качестве аргумента, результат вызова выведите в консоль.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int min = 152;
            int sec = MinutesToSeconds(min);
            Console.WriteLine(sec);

        }
        /* Добавьте свой код ниже */
        public static int MinutesToSeconds(int min)
        {
            return min * 60;
        }
    }
}