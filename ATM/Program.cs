using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("card1", 1111, 1111.1);
            Client client2 = new Client("card2", 2222, 2222.2);
            Client client3 = new Client("card3", 3333, 3333.3);



            //string card = Console.ReadLine();


            //if (card == "card1")
            //{
            //    ATM atm = new ATM(client1);
            //    if (atm.LogIn(pin))
            //    {
            //        ATM.ShowMenu();
            //    }
            //}
            //else if (card == "card2")
            //{
            //    new ATM(client2).LogIn(pin);
            //}
            //else if (card == "card3")
            //{
            //    new ATM(client3).LogIn(pin);
            //}

            ATM atm = null;
            string card = ATM.EnterCard();

            if (card == "card1")
            {
                atm = new ATM(client1);
            } else if (card == "card2")
            {
                atm = new ATM(client2);
            } else if (card == "card3")
            {
                atm = new ATM(client3);
            }
            int pin = Convert.ToInt32(Console.ReadLine());
            //ATM atm = new ATM(client1);
            if (atm.LogIn(pin))
            {
               ATM.ShowMenu();
            }


            Console.ReadLine();
        }
    }
}
