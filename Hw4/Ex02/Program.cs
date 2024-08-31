using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    /*
     * Внутри метода Main() реализуйте программу, которая:
     *      1) Считывает целое число N, введенное с клавиатуры.
     *      2) Считывает N раз целые числа, введенные с клавиатуры.
     *      3) Выводит на экран наименьшее из введенных чисел (число N не должно учитываться).
     */

    public class Program
    {
        private static object a;

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int n = int.Parse(Console.ReadLine());

            List<int> nums = new List<int>();

            for(int i = 0; i< n;i++)
            {
                int a = int.Parse(Console.ReadLine());
                nums.Add(a);
            }
            int minNum = nums.Min();
            Console.WriteLine(minNum);
        }
    }
}
