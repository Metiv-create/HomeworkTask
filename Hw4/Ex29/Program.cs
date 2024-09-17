using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex29
{
    /*
     * Создайте публичный статический класс SimpleSupportClass в том же файле и namespace что и класс Program.
     * Добавьте в созданный класс 3 приватных поля и 3 свойства. Название и типы могут быть произвольными.   
     */

    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    /* Добавьте свой код ниже */
    public static class SimpleSupportClass
    {
        private static int Age;
        private static string address;
        private static string name;

        public static int a
        {
            get { return Age; }
            set { Age = value; }
        }

        public static string b
        {
            get { return address; }
            set { address = value; }
        }

        public static string c
        {
            get { return name; }
            set { name = value; }
        }
    }
}
