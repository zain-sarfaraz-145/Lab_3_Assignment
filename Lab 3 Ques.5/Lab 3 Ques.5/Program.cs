//5. Write a class to simulate a bank account allowing for initialization, deposits, withdrawals, setting the interest rate, adding interest and giving the c
//urrent balance. Provide some code to demonstrate the object in action
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;     //creating Delegate
namespace Lab_3_Ques._5
{
    class bank
    {
        float interest;
        long a = 12344, current_acc, acc_no;
        string human;
        long account_number;
        bool company_student;
        long amount;
        public void Createaccount()
        {
            again: Console.Write("\n \t\t\t\tCreating New Account");
            Console.WriteLine("\n Name: ");
            human = Console.ReadLine();
            Console.WriteLine("\nAmount to be deposit in PKR: ");
            amount = int.Parse(Console.ReadLine());
            if (amount < 500)
            {
                Console.WriteLine("\n --- Error ---");
                Console.WriteLine("\n Deposited amount must be greater than 500 ");
                Console.ReadKey();
                goto again;
            }
            Console.WriteLine("\n\n\n Congratulation.. Account Created: ");
            Console.WriteLine("----------------------");
            Console.WriteLine("\n your account number is: " + (a * 122));
            acc_no = (a * 122);
            Console.WriteLine("\n Press Enter to Continue: ");
            Console.ReadKey();
        }
        public void Checkbalance()
        {
            Console.WriteLine("\n Enter current Account no: ");
            current_acc = int.Parse(Console.ReadLine());
            if (current_acc == acc_no)
            {
                Console.WriteLine("\n Your total balance is PKR" + amount);
            }
            else
            {
                Console.WriteLine("\n Invalid acount number: ");
            }
            Console.WriteLine("\n\n Press Enter to continue: ");
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i == 0)
            {
                bank b = new bank();
                Console.WriteLine("1 = create new account ");
                Console.WriteLine("2 = Check Balance ");
                Console.Write("3 = Exit ");
                int deci = Convert.ToInt32(Console.ReadLine());
                switch (deci)
                {
                    case 1:
                        b.Createaccount();
                        break;
                    case 2:
                        b.Checkbalance();
                        break;
                    case 3:
                        i = 1;
                        break;
                    default:
                        Console.WriteLine("Error Invalid Input");
                        break;
                }
            }
            Console.WriteLine("Thank you");
            Console.WriteLine("\n\n\nPress Enter to exit");
            Console.ReadKey();
        }
    }
}