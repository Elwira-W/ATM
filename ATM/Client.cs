using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Client
    {
        private string card;
        private int pin;
        private double balance;

        public Client(string card, int pin, double balance)
        {
            this.card = card;
            this.pin = pin;
            this.balance = balance;
        }

        public string Card
        {
            get { return card; }
            set { }
        }

        public int Pin
        {
            get { return pin; }
            set { pin = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}
