using System;

namespace laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //for para agregar personas productos, etc
            //ademas cada uno de ellos agregarlos a una lista y crear listas de compras

            for (int i = 0; i < 0; i++)
            {
                //string nb = Console.ReadLine();
                //Console.WriteLine(nb);
                break;


            }

            Boss jefe = new Boss(222, "robertita", "prada", 2310, "chilena");
            Employee nel = new Employee(222, "robertita", "prada", 2310, "chilena",23);
            Auxiliary d = new Auxiliary(222, "robertita", "prada", 2310, "chilena",989);
            Product ngel = new Product("gg", 455, "prada", 2310);
            Client nsdel = new Client(222, "robertita", "prada", 2310, "chilena");



            string nb = Console.ReadLine();
            Console.WriteLine(nb);
            Console.WriteLine("Hello World!");
        }
    }
}
