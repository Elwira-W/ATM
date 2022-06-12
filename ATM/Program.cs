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
            //Console.WriteLine(client1.Balance + " " + client2.Balance + " " + client3.Balance);

            ATM atm = null;
            string card = ATM.EnterCard();
            int pin, loginTry = 0;


            if (card == "card1")
            {
                atm = new ATM(client1);
            }
            else if (card == "card2")
            {
                atm = new ATM(client2);
            }
            else if (card == "card3")
            {
                atm = new ATM(client3);
            }

            bool appWorks = true;
            do
            {
                pin = ATM.EnterPin();
                ++loginTry;
                if (loginTry == 3)
                {
                    Console.WriteLine("Entered wrong pin 4 times. Account blocked.");
                    appWorks = false;
                    break;
                }
            } while (!atm.LogIn(pin));

            while (appWorks == true)
            {
                ATM.ShowMenu();
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    atm.ChangePin();
                    appWorks = ATM.Return();
                }
                else if (choice == 2)
                {
                    atm.CashDeposit();
                    appWorks = ATM.Return();
                }
                else if (choice == 3)
                {
                    atm.CashWithrawal();
                    appWorks = ATM.Return();
                }
                else if (choice == 4)
                {
                    atm.DisplayBalance();
                    appWorks = ATM.Return();
                }
            }
            Console.ReadLine();
        }
    }
}
