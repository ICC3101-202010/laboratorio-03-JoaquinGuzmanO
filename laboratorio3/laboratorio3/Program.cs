using System;
using System.Collections.Generic;

namespace laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido al supermercado ¡De todo un poco! ");

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

                Employee empleado = new Employee(re, ne, ae, dbe, nae, se);
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
                int pp = Int32.Parse(pp1);
                Console.WriteLine("diga la marca del producto:");
                string bp = Console.ReadLine();
                Console.WriteLine("diga el stock del producto:");
                string sp1 = Console.ReadLine();
                int sp = Int32.Parse(sp1);

                Product producto = new Product(np, pp, bp, sp);
                product_l.Add(producto);
            }

            Console.WriteLine("Los datos ingreados son los siguientes");
            Console.WriteLine("################################################");
            Console.WriteLine("Jefe");
            Console.WriteLine(jefe.Informacion());

            Console.WriteLine("Los empleados son : ");
            for (int i = 0; i < e1; i++)
            {
                Console.WriteLine(employees_l[i].Informacion());
            }

            Console.WriteLine("Los auxiliares son : ");
            for (int i = 0; i < a1; i++)
            {
                Console.WriteLine(auxiliary_l[i].Informacion());
            }

            Console.WriteLine("Los clientes son : ");
            for (int i = 0; i < c1; i++)
            {
                Console.WriteLine(client_l[i].Informacion());
            }

            Console.WriteLine("Los productos son : ");
            for (int i = 0; i < p1; i++)
            {
                Console.WriteLine(product_l[i].Informacion());
            }

            //########################## ACCIONES EN EL SUPER #######################

            List<string> compras = new List<string>();



            for (int i = 1; i > 0; i++)
            {
                Console.WriteLine("Escoja entre las siguientes ospciones" +
                    "[comprar],[cambiar sueldo],[detener(en caso de que no quiera hacer nada más)]");
                string accion = Console.ReadLine();

                if (accion == "detener")
                {
                    break;
                }

                if (accion == "comprar")
                {
                    Console.WriteLine("Seleccione el rut del cliente que quiera que compre: ");
                    string comprador = Console.ReadLine();
                    for (int j = 0; j < c1; j++)
                    {
                        if (client_l[j].getRut() == comprador)
                        {
                            Console.WriteLine("indique el nombre del producto que quiera comprar");
                            string prod = Console.ReadLine();
                            for (int k = 0; k < p1; k++)
                            {
                                if(product_l[k].getPname() == prod)
                                {
                                    if (product_l[k].getPstock() > 0)
                                    {
                                        compras.Add(comprador);
                                        compras.Add(prod);
                                        Product producto = new Product(product_l[k].getPname(), product_l[k].getPprice(), product_l[k].getPbrand(), product_l[k].getPstock()-1);
                                        product_l.Add(producto);
                                        product_l.Remove(product_l[k]);
                                    }
                                }
                            }
                            
                        }
                    }
                }
                if (accion == "cambiar sueldo")
                {
                    Console.WriteLine( "");
                }
                
            }


            Console.WriteLine("La situacion final en el supermercado es: ");
            Console.WriteLine("Los empleados son : ");
            for (int i = 0; i < e1; i++)
            {
                Console.WriteLine(employees_l[i].Informacion());
            }

            Console.WriteLine("Los auxiliares son : ");
            for (int i = 0; i < a1; i++)
            {
                Console.WriteLine(auxiliary_l[i].Informacion());
            }

            Console.WriteLine("Los clientes son : ");
            for (int i = 0; i < c1; i++)
            {
                Console.WriteLine(client_l[i].Informacion());
            }

            Console.WriteLine("Los productos son : ");
            for (int i = 0; i < p1; i++)
            {
                Console.WriteLine(product_l[i].Informacion());
            }
            
        }
    }
}
