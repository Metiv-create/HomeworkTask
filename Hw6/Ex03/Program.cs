using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t3
{
    /*
     * На вход в метод Main() будет подан массив строк args, каждая из строк будет содержать число типа double в строковом представлении, с различным количеством знаков после точки.
     * Создайте статический метод SmartCutter() который принимает массив строк и возвращает динамический массив, содержащий только те числа double из принятого массива, 
     * в которых количество знаков после точки меньше либо равно 3. 
     * Внутри метода Main() выведите результат работы метода SmartCutter() в консоль, каждый элемент с новой строки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }
        public static List<double> SmartCutter(string[] input)
        {

            List<double> result = new List<double>();

            foreach (var str in input)
            {
                if (double.TryParse(str, out double number))
                {
                    string[] parts = str.Split('.');
                    if (parts.Length == 2 && parts[1].Length <= 3)
                    {
                        result.Add(number);
                    }
                    else if (parts.Length == 1)
                    {
                        result.Add(number);
                    }
                }
            }

            return result;
        }
    }
}
