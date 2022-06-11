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
                Console.Clear();
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

        public static int EnterPin()
        {
            Console.WriteLine("Enter pin:");
            int pin = Convert.ToInt32(Console.ReadLine());
            return pin;
        }

        public void ChangePin()
        {
            Console.Clear();
            Console.WriteLine("Type new pin: ");
            int newPin = Convert.ToInt32(Console.ReadLine());
            c.Pin = newPin;
            Console.WriteLine("Pin changed succesfully.\nNew pin: " + c.Pin);

        }
        public void CashDeposit()
        {
            Console.WriteLine("Enter amount you wish to deposit: ");
            string amount; 
            bool check = true;
            do
            {
                amount = Console.ReadLine();
                if (!Int32.TryParse(amount, out int result))
                {
                    Console.WriteLine("Enter correct amount.");
                    check = false;
                }
                else
                {
                    check = true;
                }

            } while (check == false);
            c.Balance += Convert.ToDouble(amount);
            Console.WriteLine("Cash deposited successfully.");
        }

        public void CashWithrawal()
        {
            Console.WriteLine("Enter amount you wish to withdraw");
            string amount;
            bool check = true;
            do
            {
                amount = Console.ReadLine();
                if (!Int32.TryParse(amount, out int result))
                {
                    Console.WriteLine("Enter correct amount.");
                    check = false;
                }
                else
                {
                    if (Convert.ToDouble(amount) <= c.Balance)
                    {
                        check = true;
                        Console.WriteLine("Cash wihdrawal complete.");
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough money on your bank account." +
                            "\nEnter correct value.");
                        check = false;
                    }
                }

            } while (check == false);
            c.Balance -= Convert.ToDouble(amount);
            
        }

        public void DisplayBalance()
        {
            Console.Clear();
            Console.WriteLine("Current account balance: " + c.Balance);
        }

        public static void ShowMenu()
        {
            Console.WriteLine("\n What do you want to do?\n 1 - Change pin\n " +
                "2 - Cash deposit\n 3 - Cash withdrawal\n 4 - Display balance");
        }
        public static bool Return()
        {
            Console.WriteLine("Return to main menu? (y/n)");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                Console.Clear();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
