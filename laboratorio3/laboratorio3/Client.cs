﻿using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorio3
{
    class Client : Person
    {
        public Client(string rut, string name, string last_name, string date_of_birth, string nacionality) 
            : base(rut, name, last_name, date_of_birth, nacionality)
        {
        }
    }
}
