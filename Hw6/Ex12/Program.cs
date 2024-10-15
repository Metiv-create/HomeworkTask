using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t12
{
    /*
     * Внутри метода Main() создайте программу, которая бы реализовывала следующую логику работы:
     *      1) Создавала и инициализировала список строк.
     *      2) Считывала строки с клавиатуры и помещала бы их в список до тех пор, пока не будет введена
     *      строка "конец".
     *      3) После завершения ввода, выводила бы все строки списка в консоль (каждую с новой строки).
     * Строку "конец", добавлять в список не нужно.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            List<string> stringList = new List<string>();
            string input;
            while (true)
            {
                Console.WriteLine("Введите строку (или 'конец' для завершения):");
                input = Console.ReadLine();

                if (input.ToLower() == "конец") 
                {
                    break; 
                }

                stringList.Add(input); 
            }
            Console.WriteLine("Введенные строки:");
            foreach (var a in stringList)
            {
                Console.WriteLine(a); 
            }
        }
    }
}

