using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t2
{
    /*
     * Представим ситуацию, когда у каждого котика есть имя и кошка-мама.
     * Реализуйте класс Cat, который бы описывал эту ситуацию.
     * Класс Cat должен содержать две переменные: имя и кошку-маму (motherCat).
     * Переопределите метод ToString() класса Cat, так чтобы в консоль выводилось:
     *  "Меня зовут ХХХ, а мою маму ХХХ", где XXX значения соответствующих полей класса Cat, если экземпляр - котёнок.
     *  "Меня зовут ХХХ и я мама!", где XXX значения соответствующих полей класса Cat, если экземпляр - кошка-мама.
     * Создайте для класса Cat конструктор, который принимает значение имени и ссылку на родительский объект.
     * Внутри метода Main() создайте и выведите в консоль информацию по котёнку и кошке-маме.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Cat motherCat = new Cat("Муся");
            Cat kitty = new Cat("Жора",motherCat);
            Console.WriteLine(motherCat.ToString());
            Console.WriteLine(kitty.ToString());

        }
    }
    /* Добавьте свой код ниже */
    public class Cat
    {
        public string Name{get;private set;}
        public Cat MotherCat{get;private set;}
        public Cat(string name,Cat motherCat = null)
        {
            Name = name;
            MotherCat = motherCat;
        }
        public override string ToString()
        {
            if(MotherCat == null)
            {
                return $"Меня зовут {Name} и я мама!";
            }
            else
            {
                return $"Меня зовут {Name}, а мою маму {MotherCat.Name}";
            }
        }
    }
}
