using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t4
{
    /*
     * Создайте класс Human, который должен содержать свойства: имя(name), пол(sex), возраст(age). Свойство пол сделайте
     * логического типа, на основе следующей формальной логики: true - мужской пол, false - женский. Типы остальных
     * свойств класса определите самостоятельно.Все элементы класса Human должны быть публичными.
     * Переопределите метод ToString() класса Human, так чтобы он выводил информацию об экземпляре класса в следующем формате:
     * "Меня зовут ХХХ, я мужчина\женщина, мне ХХХ лет.", где ХХХ - соответствующие значения свойств класса Human,
     * а выбор значения мужчина\женщина зависел от значения свойства, отвечающего за пол.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Human human1 = new Human("Егор",true,19);
            Human human2 = new Human("Маша",false,23);
            Console.WriteLine(human1.ToString());
            Console.WriteLine(human2.ToString());
        }
    }
    /* Добавьте свой код ниже */
    public class Human
    {
        public string Name { get; set; }
        public bool Sex { get; set; }
        public int Age { get; set; }
        public Human(string name, bool sex, int age)
        {
            Name = name;
            Sex = sex;
            Age = age;
        }
        public override string ToString()
        {
            string gender = Sex ? "Мучжина":"Женщина";
            return $"Меня зовут {Name}, я {gender}, мне {Age} лет.";
        }
    }
}
