using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex25
{
    /*
     * Внутри класса Cat:
     *      1) Создайте два поля: name и age, доступные из любой точки программы.
     *      2) Создайте два поля: count и speed, доступные в пределах класса.
     *      3) Создайте два статических поля: magicPower и profession, доступные только для производных классов.
     * Типы созданных полей класса должны быть определены самостоятельно.
     */

    public class Cat
    {
        /* Добавьте свой код ниже */
        public int age = (5);
        public string name = ("жора");
        private int count = (5);
        private int speed =(8);
        protected static int magicPower =(10000);
        protected static string profession = ("маг"); 


        public static void Main(string[] args)
        {
        }
    }
}