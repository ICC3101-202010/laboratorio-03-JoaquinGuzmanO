using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorio3
{
    class Auxiliary : Person
    {
        private string salary;
        public Auxiliary(string rut, string name, string last_name, string date_of_birth, string nacionality,string salary)
            : base(rut, name, last_name, date_of_birth, nacionality)
        {
            this.salary = salary;
        }
        public string getSalary()
        {
            return salary;
        }
    }
}
