using System;
using System.Collections.Generic;

namespace laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //for para agregar personas productos, etc
            //ademas cada uno de ellos agregarlos a una lista y crear listas de compras

            Console.WriteLine("Hola bienvenido a este supermercado");

            // ################### CREACION JEFE ####################

            Console.WriteLine("para comenzar creara al jefe");

            Console.WriteLine("diga el rut del jefe:");
            string rb = Console.ReadLine();
            Console.WriteLine("diga el nombre del jefe:");
            string nb = Console.ReadLine();
            Console.WriteLine("diga el apellido del jefe:");
            string lnb = Console.ReadLine();
            Console.WriteLine("diga la fecha de nacimiento del jefe (DDMMAÑO , ej: 07061999):");
            string dbb = Console.ReadLine();
            Console.WriteLine("diga la nacionalidad del jefe:");
            string nab = Console.ReadLine();

            Boss jefe = new Boss(rb, nb, lnb, dbb, nab);


            // ################### CREACION EMPLEADOS ####################

            List<Employee> employees_l = new List<Employee>();
            
            Console.WriteLine("diga cuantos Empleados quiere crear");
            string e = Console.ReadLine();
            int e1 = Int16.Parse(e);
           
            for (int i = 0; i < e1; i++)
            {
                Console.WriteLine("diga el rut del empleado:");
                string re = Console.ReadLine();
                Console.WriteLine("diga el nombre del empleado:");
                string ne = Console.ReadLine();
                Console.WriteLine("diga el apellido del empleado:");
                string ae = Console.ReadLine();
                Console.WriteLine("diga la fecha de nacimiento del empleado (DDMMAÑO , ej: 07061999):");
                string dbe = Console.ReadLine();
                Console.WriteLine("diga la nacionalidad del empleado:");
                string nae = Console.ReadLine();
                Console.WriteLine("diga el sueldo del empleado:");
                string se = Console.ReadLine();

                Employee empleado = new Employee(re,ne,ae,dbe,nae,se);
                employees_l.Add(empleado);
            }

            //  ################### CREACION AUXILIARES ####################

            List<Auxiliary> auxiliary_l = new List<Auxiliary>();

            Console.WriteLine("diga cuantos Auxiliares quiere crear");
            string a = Console.ReadLine();
            int a1 = Int16.Parse(a);

            for (int i = 0; i < a1; i++)
            {
                Console.WriteLine("diga el rut del auxiliar:");
                string ra = Console.ReadLine();
                Console.WriteLine("diga el nombre del auxiliar:");
                string na = Console.ReadLine();
                Console.WriteLine("diga el apellido del auxiliar:");
                string aa = Console.ReadLine();
                Console.WriteLine("diga la fecha de nacimiento del auxiliar (DDMMAÑO , ej: 07061999):");
                string dba = Console.ReadLine();
                Console.WriteLine("diga la nacionalidad del auxiliar:");
                string naa = Console.ReadLine();
                Console.WriteLine("diga el sueldo del auxiliar:");
                string sa = Console.ReadLine();

                Auxiliary auxiliar = new Auxiliary(ra, na, aa, dba, naa, sa);
                auxiliary_l.Add(auxiliar);
            }

            //  ################### CREACION CLIENTES ####################

            List<Client> client_l = new List<Client>();

            Console.WriteLine("diga cuantos Cientes quiere crear");
            string c = Console.ReadLine();
            int c1 = Int16.Parse(c);

            for (int i = 0; i < c1; i++)
            {
                Console.WriteLine("diga el rut del cliente:");
                string rc = Console.ReadLine();
                Console.WriteLine("diga el nombre del cliente:");
                string nc = Console.ReadLine();
                Console.WriteLine("diga el apellido del cliente:");
                string ac = Console.ReadLine();
                Console.WriteLine("diga la fecha de nacimiento del cliente (DDMMAÑO , ej: 07061999):");
                string dbc = Console.ReadLine();
                Console.WriteLine("diga la nacionalidad del cliente:");
                string nac = Console.ReadLine();

                Client cliente = new Client(rc, nc, ac, dbc, nac);
                client_l.Add(cliente);
            }

            //  ################### CREACION PRODUCTOS ####################

            List<Product> product_l = new List<Product>();

            Console.WriteLine("diga cuantos productos quiere crear");
            string p = Console.ReadLine();
            int p1 = Int16.Parse(p);

            for (int i = 0; i < p1; i++)
            {
                Console.WriteLine("diga el nombre del producto:");
                string np = Console.ReadLine();
                Console.WriteLine("diga el precio del producto:");
                string pp1 = Console.ReadLine();
                int pp = Int16.Parse(pp1);
                Console.WriteLine("diga la marca del producto:");
                string bp = Console.ReadLine();
                Console.WriteLine("diga el stock del producto:");
                string sp1 = Console.ReadLine();
                int sp = Int16.Parse(sp1);

                Product producto = new Product(np, pp, bp, sp);
                product_l.Add(producto);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
