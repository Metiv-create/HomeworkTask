using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    /*
     * Создайте новый класс Cat в том же файле и том же namespace, что и класс Program. 
     * В классе Cat создайте 6 переменных, имена, типы переменных и модификатор доступа переменных придумайте самостоятельно. 
     * Создайте 7 различных конструкторов для класса Cat.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }
        public class Cat
        {
            private int age;
            private int tail;
            private int paws;
            private string name;
            private string breed;
            private int nose;

            public Cat(string name)
            {
                this.name = name;
            }
            public Cat(string name,int age)
            {
                this.name = name;
                this.age = age;
            }
            public Cat(string name,int age,string breed)
            {
                this.name = name;
                this.age = age;
                this.breed = breed;
            }
            public Cat(string name,int age,string breed,int tail)
            {
                this.name = name;
                this.age = age;
                this.breed = breed;
                this.tail = 1;
            }
            public Cat(string name,int age,string breed,int tail,int nose)
            {
                this.name = name;
                this.age = age;
                this.breed = breed;
                this.tail = 1;
                this.nose = 1;
            }
            public Cat(string name,int age,string breed,int tail,int nose,int paws)
            {
                this.name = name;
                this.age = age;
                this.breed = breed;
                this.tail = 1;
                this.nose = 1;
                this.paws = 4;
            }
            public Cat(int paws,int tail,int nose)
            {
                this.tail = 1;
                this.nose = 1;
                this.paws = 4;
            }
        }
    }
}
