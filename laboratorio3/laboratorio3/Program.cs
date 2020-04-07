using System;
using System.Collections.Generic;

namespace laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido al supermercado ¡De todo un poco! ");
            Console.WriteLine("################################################");

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
            Console.WriteLine("################################################");
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
                Console.WriteLine("################################################");

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
                Console.WriteLine("################################################");

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
                Console.WriteLine("################################################");

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
                Console.WriteLine("################################################");
            }

            Console.WriteLine("Los datos ingreados son los siguientes");
            Console.WriteLine("################################################");
            Console.WriteLine("Jefe: ");
            Console.WriteLine(jefe.Informacion());
            Console.WriteLine("################################################");

            Console.WriteLine("Los empleados son : ");
            for (int i = 0; i < e1; i++)
            {
                Console.WriteLine(employees_l[i].Informacion());
            }
            Console.WriteLine("################################################");

            Console.WriteLine("Los auxiliares son : ");
            for (int i = 0; i < a1; i++)
            {
                Console.WriteLine(auxiliary_l[i].Informacion());
            }
            Console.WriteLine("################################################");

            Console.WriteLine("Los clientes son : ");
            for (int i = 0; i < c1; i++)
            {
                Console.WriteLine(client_l[i].Informacion());
            }
            Console.WriteLine("################################################");

            Console.WriteLine("Los productos son : ");
            for (int i = 0; i < p1; i++)
            {
                Console.WriteLine(product_l[i].Informacion());
            }

            //########################## ACCIONES EN EL SUPER #######################
            Console.WriteLine("################################################");
            List<Receipt> boleta = new List<Receipt>();


            Console.WriteLine("solo podra hacer compras de un elemento a la vez, tambien" +
                "cuando ingrese un rut no valido, un  producto no valido o un producto sin stock regresara al menu" +
                "para aclarar cajero = empleado ");
            for (int i = 1; i > 0; i++)
            {
                Console.WriteLine("Escoja entre las siguientes opciones" +
                    "[comprar],[cambiar sueldo],[cambiar precio producto],[detener](en caso de que no quiera hacer nada más)");
                string accion = Console.ReadLine();

                if (accion == "detener")
                {
                    Console.WriteLine("################################################");
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
                                        Console.WriteLine("diga el rut del cajero que quiera: ");
                                        string cajero = Console.ReadLine();
                                        for (int t = 0; t < e1; t++)
                                        {
                                            if (employees_l[t].getRut() == cajero)
                                            {
                                                Receipt boletas = new Receipt("6 Abril 2020", "18:57", employees_l[t].getName(), client_l[j].getName(), prod, product_l[k].getPprice());
                                                boleta.Add(boletas);
                                                Product producto = new Product(product_l[k].getPname(), product_l[k].getPprice(), product_l[k].getPbrand(), product_l[k].getPstock() - 1);
                                                product_l.Add(producto);
                                                product_l.Remove(product_l[k]);
                                                Console.WriteLine("################################################");
                                            }
                                        }
                                    }
                                }
                            }
                            
                        }
                    }
                }
                if (accion == "cambiar sueldo")
                {
                    Console.WriteLine("Escriba si quiere cambiar el sueldo a [cajero] o [auxiliar] :");
                    string elegido = Console.ReadLine();
                    if(elegido == "cajero")
                    {
                        Console.WriteLine("ingrese el rut del cajero que le quiere cambiar el sueldo: ");
                        string rutaso = Console.ReadLine();
                        for (int m = 0; m < e1; m++)
                        {
                            if (employees_l[m].getRut() == rutaso)
                            {
                                Console.WriteLine("diga cual va a ser el nuevo sueldo: ");
                                string sueldo = Console.ReadLine();
                                Employee empleado = new Employee(employees_l[m].getRut(),employees_l[m].getName(),
                                    employees_l[m].getLast_name(), employees_l[m].getDate_of_birth(), employees_l[m].getNacionality(),sueldo);
                                employees_l.Add(empleado);
                                employees_l.Remove(employees_l[m]);
                                Console.WriteLine("################################################");
                            }
                        }
                    }
                    if(elegido == "auxiliar")
                    {
                        Console.WriteLine("ingrese el rut del auxiliar que le quiere cambiar el sueldo: ");
                        string rutaso1 = Console.ReadLine();
                        for (int n = 0; n < a1; n++)
                        {
                            if (auxiliary_l[n].getRut() == rutaso1)
                            {
                                Console.WriteLine("diga cual va a ser el nuevo sueldo: ");
                                string sueldo1 = Console.ReadLine();
                                Auxiliary auxiliar = new Auxiliary(auxiliary_l[n].getRut(), auxiliary_l[n].getName(),
                                    auxiliary_l[n].getLast_name(), auxiliary_l[n].getDate_of_birth(), auxiliary_l[n].getNacionality(), sueldo1);
                                auxiliary_l.Add(auxiliar);
                                auxiliary_l.Remove(auxiliary_l[n]);
                                Console.WriteLine("################################################");
                            }
                        }

                    }            
                }
                if (accion == "cambiar precio producto")
                {
                    Console.WriteLine("ingrese el nombre del producto que le va a cambiar el precio: ");
                    string producto1 = Console.ReadLine();
                    for (int n = 0; n < p1; n++)
                    {
                        if (product_l[n].getPname() == producto1)
                        {
                            Console.WriteLine("diga cual va a ser el nuevo precio: ");
                            string precio1 = Console.ReadLine();
                            int prec = Int32.Parse(precio1);
                            Product producto = new Product(product_l[n].getPname(), prec, product_l[n].getPbrand(), product_l[n].getPstock());
                            product_l.Add(producto);
                            product_l.Remove(product_l[n]);
                            Console.WriteLine("################################################");

                        }
                    }
                }

            }

            Console.WriteLine("Las compras realizadas fueron");
            System.Collections.IList list = boleta;
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(boleta[i].emitir());
            }
            Console.WriteLine("################################################");
            Console.WriteLine("La situacion final en el supermercado es: ");
            Console.WriteLine("Los empleados son : ");
            for (int i = 0; i < e1; i++)
            {
                Console.WriteLine(employees_l[i].Informacion());
            }
            Console.WriteLine("################################################");

            Console.WriteLine("Los auxiliares son : ");
            for (int i = 0; i < a1; i++)
            {
                Console.WriteLine(auxiliary_l[i].Informacion());
            }
            Console.WriteLine("################################################");

            Console.WriteLine("Los clientes son : ");
            for (int i = 0; i < c1; i++)
            {
                Console.WriteLine(client_l[i].Informacion());
            }
            Console.WriteLine("################################################");

            Console.WriteLine("Los productos son : ");
            for (int i = 0; i < p1; i++)
            {
                Console.WriteLine(product_l[i].Informacion());
            }
            Console.WriteLine("################################################");

        }
    }
}
