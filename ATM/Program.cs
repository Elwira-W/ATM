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

            ATM atm = null;
            string card = ATM.EnterCard();
            int pin = ATM.EnterPin();

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

            if (atm.LogIn(pin))
            {
                ATM.ShowMenu();
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    atm.ChangePin();
                    ATM.Return();
                }
            }

            Console.ReadLine();
        }
    }
}
