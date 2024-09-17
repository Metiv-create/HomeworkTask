using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    /*
     * Внутри класса Program создайте две публичных целочисленных переменных: id и count. Переменная id должна отвечать за уникальный
     * идентификатор экземпляра класса, а переменная count должна подсчитывать совокупное количество экземпляров класса.
     * Создайте конструктор для класса Program по умолчанию, который должен:
     *      1) Присваивать созданному экземпляру уникальное значение переменной id.
     *      2) Увеличивать счетчик количества экземпляров класса.
     */

    public class Program
    {
        /* Добавьте свой код ниже */
        public int id;
        public static int count=0;
        public Program()
        {
            id = count++;
        }
        public static void Main(string[] args) 
        { 
            Program prog1 = new Program();
            Console.WriteLine($"{prog1.id}, {Program.count}");
            Program prog2 = new Program();
            Console.WriteLine($"{prog2.id}, {Program.count}");
            Program prog3 = new Program();
            Console.WriteLine($"{prog3.id}, {Program.count}");
        }
    }
}
