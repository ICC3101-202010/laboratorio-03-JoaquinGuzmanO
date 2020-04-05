using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorio3
{
    class Auxiliary : Person
    {
        private int salary;
        public Auxiliary(int rut, string name, string last_name, int date_of_birth, string nacionality,int salary)
            : base(rut, name, last_name, date_of_birth, nacionality)
        {
            this.salary = salary;
        }
        public int getSalary()
        {
            return salary;
        }
    }
}
