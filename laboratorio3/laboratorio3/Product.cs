using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorio3
{
    class Product
    {
        private string Pname;
        private int Pprice;
        private string Pbrand; //marca
        private int Pstock;

        public Product(string Pname, int Pprice, string Pbrand, int Pstock)
        {
            this.Pname = Pname;
            this.Pprice = Pprice;
            this.Pbrand = Pbrand;
            this.Pstock = Pstock;
        }
        public string getPname()
        {
            return Pname;
        }
        public int getPprice()
        {
            return Pprice;
        }
        public string getPbrand()
        {
            return Pbrand;
        }
        public int getPstock()
        {
            return Pstock;
        }

        public string Informacion()
        {
            return "nombre: " + Pname + " " + "precio : " + Pprice + " " + "marca: "
                + Pbrand + " " + "stock: " + Pstock ;
        }
    }
}
