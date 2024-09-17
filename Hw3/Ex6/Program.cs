﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    /*
     * 
     * Создайте класс Human в том же файле и том же namespace, что и класс Program. 
     * Внутри класса Human объявите 3 переменные (lastName, firstName, middleName), которые будут содержать в себе фамилию, имя и отчество. 
     * Тип переменных определите самостоятельно.
     * Реализуйте два метода:
        1) SetNames(), который принимает в качестве параметра 3 строки, содержащие фамилию, имя и отчество человека,
        и записывает их в соответствующие переменные класса;
        2) GetFullName(), который возвращает фамилию, имя и отчество в виде 1 строки через пробел.
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            Human human1 = new Human();
            human1.SetNames("Иванов","Иван","Иванович");
            Console.WriteLine(human1.GetFullName());
        }
    }
    /* Добавьте свой код ниже */
    class Human
    {
        private string lastName;
        private string firstName;
        private string middleName;
        public void SetNames(string lastName, string firstName, string middleName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.middleName = middleName;
        }
        public string GetFullName()
        {
            return $"{lastName}  {firstName}  {middleName}";
        }
    }
}