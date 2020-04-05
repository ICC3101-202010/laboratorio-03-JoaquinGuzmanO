using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorio3
{
    class Client : Person
    {
        public Client(int rut, string name, string last_name, int date_of_birth, string nacionality) 
            : base(rut, name, last_name, date_of_birth, nacionality)
        {
        }
    }
}
