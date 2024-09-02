using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16
{
    /*
     * Для класса Human, создайте конструктор, который бы принимал имя, возраст и профессию человека и инициализировал полученными значениями соответствующие поля класса.
     * Переопределите метод ToString для класса Human, таким образом, чтобы:
     * 1) Он возвращал строку "Привет, меня зовут ХХХ, мне ХХХ лет и по профессии я: ХХХ!".
     * 2) Если значение возраста меньше либо равно нулю, то возвращал строку "Привет, меня зовут ХХХ, я скрываю свой возраст, потому что по профессии я: ХХХ!".
     * 3) Если значение имени null или пустая строка, то возвращал строку "Привет, я скрываю своё имя, но мне ХХХ лет и я работаю по профессии: ХХХ!".
     * 4) Если значение профессии null или пустая строка, то возвращал строку "Привет, меня зовут ХХХ, мне ХХХ лет, у меня пока нет профессии, но скоро я стану .Net программистом!!!".
     * 5) Если значения возраста и профессии пустые или некорректные, то возвращал строку "Меня зовут ХХХ!"
     * 6) Если значения имени и возраста пустые или некорректные, то возвращал строку "Моя профессия ХХХ!".
     * 7) Если значения имени и профессии пустые, то возвращал строку "Мне ХХХ лет!".
     * 8) Если все значения пустые или некорректные, то возвращал строку "Я аноним!".
     * Шаблон задачи изменять нельзя.
     */

    public class Human
    {
        private string name;
        private int age;
        private string profession;
        /* Добавьте свой код ниже */
        public Human(string name, int age, string profession)
        {
            this.name = name;
            this.age = age;
            this.profession = profession;
        }

        // Переопределение метода ToString
        public override string ToString()
        {
            // Проверка на все случаи
            if (name == null && age <= 0 && (profession == null || profession == ""))
            {
                return "Я аноним!";
            }
            else if (name == null && age <= 0)
            {
                return "Моя профессия " + profession + "!";
            }
            else if (name == null && profession != null && profession != "")
            {
                return "Привет, я скрываю своё имя, но мне " + age + " лет и я работаю по профессии: " + profession + "!";
            }
            else if (age <= 0 && profession != null && profession != "")
            {
                return "Привет, меня зовут " + name + ", я скрываю свой возраст, потому что по профессии я: " + profession + "!";
            }
            else if (name != null && name != "" && profession == null)
            {
                return "Привет, меня зовут " + name + ", мне " + age + " лет, у меня пока нет профессии, но скоро я стану .Net программистом!!!";
            }
            else if (name != null && name != "" && age <= 0)
            {
                return "Привет, меня зовут " + name + ", я скрываю свой возраст, потому что по профессии я: " + profession + "!";
            }
            else if (age <= 0 && (profession == null || profession == ""))
            {
                return "Мне " + age + " лет!";
            }
            else if (name != null && name != "" && age > 0 && (profession == null || profession == ""))
            {
                return "Привет, меня зовут " + name + ", мне " + age + " лет, у меня пока нет профессии, но скоро я стану .Net программистом!!!";
            }
            else
            {
                return "Привет, меня зовут " + name + ", мне " + age + " лет и по профессии я: " + profession + "!";
            }
        }

        public static void Main(string[] args)
        {
            Human person1 = new Human("Егор", 19, "Программист");
            Human person2 = new Human("", 25, "Автомеханик");
            Human person3 = new Human("Алексей", -5, "Дизайнер");
            Human person4 = new Human("Лёша", 1, "");
            Human person5 = new Human(null, 0, null);
            
            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
            Console.WriteLine(person3.ToString());
            Console.WriteLine(person4.ToString());
            Console.WriteLine(person5.ToString());
        }
        /* Добавьте свой код ниже */
    }
}
