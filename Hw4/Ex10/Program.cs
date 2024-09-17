using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{

    /*
     * Создайте новый публичный класс Dog в том же файле и том же namespace, что и класс Program. 
     * Объявите в классе Dog три переменные: name,age,breed, тип и модификатор доступа переменных определите самостоятельно. 
     * Переопределите метод ToString() для класса Dog так, чтобы он выводил информацию об экземпляре класса в следующем формате: 
     * "Привет!!! Я собачка и меня зовут ХХХ!!! Мне ХХХ лет и я отношусь к породе: ХХХ!". 
     * ХХХ - значения соответствующих переменных класса Dog. 
     * Внутри метода Main() создайте 4 экземпляра класса Dog используя статическую инициализацию и выведите в консоль информацию 
     * по созданным экземплярам, каждый экземпляр с новой строки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            {
                Dog dog1 = new Dog { Name = "пёс", Age = 3, Breed = "Лабрадор" };
                Dog dog2 = new Dog { Name = "Шарик", Age = 1, Breed = "Немецкая овчарка" };
                Dog dog3 = new Dog { Name = "Бобик", Age = 2, Breed = "Такса" };
                Dog dog4 = new Dog { Name = "Шар", Age = 4, Breed = "Хаски" };

                Console.WriteLine(dog1);
                Console.WriteLine(dog2);
                Console.WriteLine(dog3);
                Console.WriteLine(dog4);
            }
        }
    }
    /* Добавьте свой код ниже */
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public override string ToString()
        {
            return $"Привет!!! Я собачка и меня зовут {Name}!!! Мне {Age} лет и я отношусь к породе: {Breed}!";
        }
    }
}