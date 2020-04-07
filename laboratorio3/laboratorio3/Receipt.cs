using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorio3
{
    class Receipt
    {
        private string date;
        private string hour;
        private string cashier;
        private string buyer;
        private string produ;
        private int money;

        public Receipt(string date,string hour, string cashier,string buyer,string produ,int money)
        {
            this.date = date;
            this.hour = hour;
            this.cashier = cashier;
            this.buyer = buyer;
            this.produ = produ;
            this.money = money;
        }

        public string getDate()
        {
            return date;
        }

        public string getHour()
        {
            return hour;
        }

        public string getCashier()
        {
            return cashier;
        }

        public string getBuyer()
        {
            return buyer;
        }

        public string getProduct()
        {
            return produ;
        }

        public int getMoney()
        {
            return money;
        }

        public string emitir()
        {
            return "fecha: " + date + " " + "hora: " + hour + " " + "cajero: "
               + cashier + " " + "comprador: " + buyer+" "+ "producto comrado: "+produ+" "+ "por el monto de :"+ money ;
        }
    }   

}
