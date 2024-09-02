using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20
{
    /*
     * Для класса Program создайте:
     *      1) 3 произвольных автоматических свойства, доступные только на чтение.
     *      2) 2 произвольных автоматических свойства, доступные только на запись.
     * Тип, модификаторы и имена свойств придумайте самостоятельно.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string breed { get; private set; }
        public string owner { private get; set; }
        public double address { private get; set; }
        }
    }
}
