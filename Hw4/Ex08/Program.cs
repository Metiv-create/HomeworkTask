using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    /*
     * Постарайтесь создать для класса Cat как можно больше конструкторов.
     * Шаблон задачи менять нельзя.
     */

    public class Cat
    {
        int age;
        int weight;
        string color;
        string name;
        /* Добавьте свой код ниже */
        public Cat()
        {
        }
        public Cat(int age)
        {
            this.age = age;
        }
        public Cat(int age, int weight)
        {
            this.age = age;
            this.weight = weight;
        }
        public Cat(int age, int weight, string color)
        {
            this.age = age;
            this.weight = weight;
            this.color = color;
        }
        public Cat(int age, int weight, string color, string name)
        {
            this.age = age;
            this.weight = weight;
            this.color = color;
            this.name = name;
        }


        public static void Main(string[] args)
        {
        }
    }
}
