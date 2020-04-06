using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorio3
{
    class Boss : Person
    {
        public Boss(string rut, string name, string last_name, string date_of_birth, string nacionality) 
            : base(rut, name, last_name, date_of_birth, nacionality)
        {
        }

        public string Informacion()
        {
            return "rut: " + rut +" "+ "nombre: " + name + " " + "apellido : " + last_name+" "+ "fecha de nacimiento: "
                + date_of_birth + " " + "nacionalidad: " + nacionality;
        }
    }

}
