using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t20
{
    /*
     * Внутри метода Main() создайте список строк. Добавьте в созданный список 5 строк, считанных с клавиатуры.
     * Используя цикл foreach найдите самую длинную строку в списке. Выведите самую длинную строку на экран.
     * Если несколько строк имеют одинаковую максимальную длину, выведите каждую с новой строки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            List<string> lines = new List<string>();
            Console.WriteLine("Введите 5 строк:");
            for (int i = 0; i < 5; i++)
            {
                string input = Console.ReadLine();
                lines.Add(input);
            }
            int maxLength = lines.Max(line => line.Length);
            var longestLines = lines.Where(line => line.Length == maxLength);
            Console.WriteLine("Самые длинные строки:");
            foreach (var line in longestLines)
            {
                Console.WriteLine(line);
            }
        }
    }
}

