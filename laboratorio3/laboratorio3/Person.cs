using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorio3
{
    class Person
    {
        protected string rut;
        protected string name;
        protected string last_name;
        protected string date_of_birth;
        protected string nacionality;

        public Person(string rut, string name, string last_name, string date_of_birth, string nacionality)
        {
            this.rut = rut;
            this.name = name;
            this.last_name = last_name;
            this.date_of_birth = date_of_birth;
            this.nacionality = nacionality;
        }
        public string getRut()
        {
            return rut;
        }

        public string getName()
        {
            return name;
        }

        public string getLast_name()
        {
            return last_name;
        }

        public string getDate_of_birth()
        {
            return date_of_birth;
        }

        public string getNacionality()
        {
            return nacionality;
        }
    }
}
