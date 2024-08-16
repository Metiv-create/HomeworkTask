using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14
{
    /*
     * В классе Program реализуйте статический метод GetRandomInt() так, чтобы он возвращал случайное
     * положительное трехзначное число, оканчивающееся на ноль.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            int a = GetRandomInt();
            Console.WriteLine(a);
        }

        public static int GetRandomInt()
        {
            /* Добавьте свой код ниже */
            Random random = new Random();
            int rndNum = random.Next(10,100);
            return rndNum * 10;
            
        }
    }
}
