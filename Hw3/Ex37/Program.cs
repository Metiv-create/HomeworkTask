using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex37
{
    /*
     *  В классе Program создайте 4 публичных статических метода:
     *      1) Метод Sum() должен принимать два целочисленных параметра и возвращать их сумму.
     *      2) Метод Dif() должен принимать два целочисленных параметра и возвращать их разность.
     *      3) Метод Mul() должен принимать два целочисленных параметра и возвращать их произведение.
     *      4) Метод OperationSwitcher() должен:
     *          - принимать  1 строку (операцию) и 2 числа (операнда);
     *          - возвращать результат выполнения полученной операции, используя обращение к другим созданным методам.
     *  Внутри метода Main() необходимо:
     *      1) Вывести в консоль 3 строки:
     *          Привет! Я твой первый калькулятор!
     *          Я умею складывать (команда - Sum) вычитать (команда - Dif) умножать (команда - Mul)!
     *          Введите сначала операцию, а затем два числа:
     *      2) Последовательно считать с клавиатуры операцию, а затем два числа и передать их методу OperationSwitcher().
     *      3) Вывести на экран результат операции в формате: «Результат операции равен: ХХХ», где ХХХ - результат работы метода OperationSwitcher().
     *  Если пользователь введет операцию, которой не существует – необходимо вывести на экран фразу «Такой операции нет! Попробуйте еще раз:»
     *  и повторно считать строку с клавиатуры до тех пор, пока не будет введено корректное значение.
     *  В случае если введена неправильная операция – считывать числа не нужно.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Привет! Я твой первый калькулятор!");
            Console.WriteLine("Я умею складывать (команда - Sum) вычитать (команда - Dif) умножать (команда - Mul)!");
            Console.WriteLine("Введите сначала операцию, а затем два числа:");

            while (true)
            {
                string operation = Console.ReadLine();
                if (operation.ToLower() != "sum" && operation.ToLower() != "dif" && operation.ToLower() != "mul")
                {
                    Console.WriteLine("Такой операции нет! Попробуйте еще раз:");
                    continue;
                }

                Console.WriteLine("Введите первое число:");
                int firstNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                int secondNumber = int.Parse(Console.ReadLine());

                int result = OperationSwitcher(operation.ToLower(), firstNumber, secondNumber);
                    Console.WriteLine($"Результат операции равен: {result}");
            }
        }
         public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Dif(int a, int b)
        {
            return a - b;
        }

        public static int Mul(int a, int b)
        {
            return a * b;
        }

        public static int OperationSwitcher(string operation, int a, int b)
        {
            switch (operation.ToLower())
            {
                case "sum":
                    return Sum(a, b);
                case "dif":
                    return Dif(a, b);
                case "mul":
                    return Mul(a, b);
                default:
                    return 0;
            }
        }
    }
}