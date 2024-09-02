using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    /*
     * В классе Cat объявите 3 переменные: name,age,address, тип переменных и модификатор доступа определите самостоятельно.
     * Создайте 3 конструктора для класса Cat, которые включают:
     *      1) Имя.
     *      2) Имя и возраст.
     *      3) Имя и возраст и адрес.
     * Внутри метода Main() создайте последовательно 3 экземпляра класса Cat используя созданные конструкторы с разными значениями
     * и присвойте их соответствующим переменным. Шаблон задачи менять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Cat catWithName = new Cat("барсик");
            Cat catWithNameAndAge = new Cat("бурсик",6);
            Cat catWithNameAgeAndAddress = new Cat("борсик",7,"иваново");

            Console.WriteLine(catWithName);
            Console.WriteLine(catWithNameAndAge);
            Console.WriteLine(catWithNameAgeAndAddress);
        }
    }

    public class Cat
    {
        /* Добавьте свой код ниже */
        private string name;
        private int age;
        private string address;
        public Cat(string name)
        {
            this.name = name;
        }
        public Cat(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public Cat(string name,int age,string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
        public override string ToString()
        {
            return $"{this.name}:{this.age}:{this.address}";
        }
    }
}
