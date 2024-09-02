using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19
{
    /*
     * Измените класс Program таким образом, чтобы вместо публичных переменных класса, класс стал использовать
     * автоматические свойства, с соответствующими именами. Ненужные переменные - удалите.
     * Остальные элементы шаблона изменять нельзя.
     */

    public class Program
    {
        public int version { get; set; }
        public string name { get; set; }
        public Human owner { get; set; }

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Program program = new Program
            {
                version = 2,
                name = "Ex19",
                owner = new Human { name = "metiv" }
            };

            Console.WriteLine($"Program Name: {program.name}, Version: {program.version}, Owner: {program.owner.name}");
        }

    }

    public class Human
    {
        public string name { get; set; }
    }
}
