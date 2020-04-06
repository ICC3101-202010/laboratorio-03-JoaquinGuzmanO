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

        public string Informacion()
        {
            return "rut: " + rut + " " + "nombre: " + name + " " + "apellido : " + last_name + " " + "fecha de nacimiento: "
                + date_of_birth + " " + "nacionalidad: " + nacionality + " " + "sueldo: " + salary;
        }
    }
}
