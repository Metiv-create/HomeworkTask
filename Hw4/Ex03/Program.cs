using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    /*
     * Внутри метода Main() реализуйте программу, которая:
     *      1) Считывает целое число N, введенное с клавиатуры.
     *      2) Считывает N раз целые числа, введенные с клавиатуры.
     *      3) Выводит на экран сумму всех введённых чисел (число N не должно учитываться).
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int n = int.Parse(Console.ReadLine());

            List<int> b = new List<int>();

            for(int i = 0; i< n;i++)
            {
                int a = int.Parse(Console.ReadLine());
                b.Add(a);
            }
            int sumNum = b.Sum();
            Console.WriteLine(sumNum);
        }
    }
}
