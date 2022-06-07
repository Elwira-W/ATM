using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class ATM
    {
        private Client c;

        public ATM(Client client)
        {
            c = client;
        }

        public bool LogIn (int pin)
        {
            if (c.Pin == pin)
            {
                Console.WriteLine("Succesfully logged in!");
                return true;
            }
            else
            {
                Console.WriteLine("Error!");
                return false;
            }
        }
        public static string EnterCard()
        {
            Console.WriteLine("Enter your card into terminal (type name)");
            string card = Console.ReadLine();
            return card;
        }

        public void EnterPin()
        {

        }

        public void ChangePin()
        {
            Console.WriteLine("Type new pin: ");
            int newPin = Convert.ToInt32(Console.ReadLine());
            c.Pin = newPin;
            Console.WriteLine(c.Pin);

        }
        public void CashDeposit()
        {

        }

        public void CashWithrawal()
        {

        }

        public void DisplayBalance()
        {

        }

        public static void ShowMenu()
        {
            Console.WriteLine("\n What do you want to do?\n 1 - Change pin\n " +
                "2 - Cash deposit\n 3 - Cash withdrawal\n 4 - Display balance");
        }
    }
}
