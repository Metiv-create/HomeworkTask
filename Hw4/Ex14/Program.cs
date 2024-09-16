using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14
{
    /*    
     * Реализуйте класс Cat и класс Human. Для класса Cat объявите два поля класса:
     *      1) Имя.
     *      2) Владелец.
     * Создайте конструктор для класса Cat, который принимает имя в качестве параметра, кроме того
     * внутри конструктора создайте и присвойте соответствующему полю класса Cat новый экземпляр
     * класса Human.
     * Для класса Human объявите три поля класса:
     *      1) Имя.
     *      2) Адрес.
     *      3) Питомец.
     * Для класса Human добавьте такой конструктор, чтобы при создании нового экземпляра класса Human его имя
     * совпадало с вашим, адрес был произвольным, а в качестве входящего параметра конструктор бы принимал
     * и присваивал соответствующему полю новый экземпляр класса Cat.
     * Для класса Cat переопределите метод ToString(), так чтобы он возвращал информацию в следующем формате:
     * "Меня зовут: XXX, а моего хозяина зовут: ХХХ. Мы с ним вместе живем по адресу: ХХХ!"
     * ХХХ - значения соответствующих полей класса. Все элементы классов Cat и Human сделайте открытыми.
     * Шаблон задачи менять нельзя.
     */

    public class Program
    {        
        public static void Main(string[] args)
        {
            Console.WriteLine(new Cat("Котяра"));
            Console.WriteLine(new Cat("Мурзик"));
            Console.WriteLine(new Cat("Том"));
        }
    }

    public class Cat
    {
        /* Добавьте свой код ниже */
         public string Name { get; set; }
        public Human Owner { get; set; }

        public Cat(string name)
        {
            Name = name;
            Owner = new Human("Имя", "Адрес", this);
        }

        public override string ToString()
        {
            return $"Меня зовут: {Name}, а моего хозяина зовут: {Owner.Name}. Мы с ним вместе живем по адресу: {Owner.Address}!";
        }
    }

    public class Human
    {
        /* Добавьте свой код ниже */
        public string Name { get; set; }
        public string Address { get; set; }
        public Cat Pet { get; set; }

        public Human(string name, string address, Cat pet)
        {
            Name = name;
            Address = address;
            Pet = pet;
        }
    }
}
