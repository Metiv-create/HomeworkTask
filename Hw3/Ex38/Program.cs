using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex38
{
    /*
     * В классе Program создайте публичный статический метод GetIntAsString(), который принимает 1 целое число и возвращает строку:
     * 1) Если число от 1 до 9999 включительно – словесную форму полученного числа (Например: один (1), пятнадцать(15), одна тысяча девятьсот девяносто девять (1999))
     * 2) Если меньше 1 - "Слишком маленькое число".
     * 3) Если больше 9999 - "Слишком большое число".
     */

    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine(GetIntAsString(1));     
            Console.WriteLine(GetIntAsString(15));     
            Console.WriteLine(GetIntAsString(1999));   
            Console.WriteLine(GetIntAsString(0));      
            Console.WriteLine(GetIntAsString(10000));  
        }
        /* Добавьте свой код ниже */

        public static string GetIntAsString(int number)
        {
            if (number < 1)
            {
                return "Слишком маленькое число";
            }
            else if (number > 9999)
            {
                return "Слишком большое число";
            }

            string[] nums = { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            string[] tenNine = { "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
            string[] tens = { "", "", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
            string[] hundreds = { "", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
            string[] num = {"", "одна", "две", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять"};
            string result = "";

            if (number >= 1000)
            {
                result += num[number / 1000] + " тысяча ";
                number %= 1000;
            }

            if (number >= 100)
            {
                result += hundreds[number / 100] + " ";
                number %= 100;
            }

            if (number >= 20)
            {
                result += tens[number / 10] + " ";
                number %= 10;
            }
            else if (number >= 10)
            {
                result += tenNine[number - 10] + " ";
                number = 0;
            }

            result += nums[number];

            return result;
        }
    }
}
