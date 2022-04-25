using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount = 100000;

            Console.WriteLine();
            Console.WriteLine("\t\tWelcome to LenaDena Bank");
            Console.WriteLine();
            Console.WriteLine("Please Enter Your Account User Id");
            int user_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Your Password");
            int password = int.Parse(Console.ReadLine());
            int dp = 123456;
            int du = 4456;


            if (user_id == du && password == dp)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome Customer");
                Console.WriteLine();
                Console.WriteLine("What you want ot perform today please select");
                Console.WriteLine();
                Console.WriteLine("Only Select the option number to perform task");


                Console.WriteLine("1. Cash Withdrawl");
                Console.WriteLine("2. Cash Deposite");
                Console.WriteLine("3. Change Your Number");
                Console.WriteLine("4. Mini Statement");
                Console.WriteLine("5. Change Password");
                Double Selection = Convert.ToDouble(Console.ReadLine());

                switch (Selection)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine($"Your current amount in your saving account is {amount}");
                        Console.WriteLine();
                        Console.WriteLine("Enter the amount you want to withdraw");
                        long wamount = long.Parse(Console.ReadLine());
                        if (wamount < amount)
                        {
                            long famount = amount - wamount;
                            DateTime ft = DateTime.Now;
                            Console.WriteLine();
                            Console.WriteLine(" Please Collect Your Cash ");
                            Console.WriteLine();
                            Console.WriteLine($" You withdrawed Rs {wamount} from your savings account on  {ft:f}");
                            Console.WriteLine();
                            Console.WriteLine($" Your remaining amount in your saving account is:- {famount}");
                            Console.WriteLine();
                            Console.WriteLine("Thank you for visiting LenaDena Bank ATM");

                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Amount you entered is greater than the amount you have in your saving account");
                            Console.WriteLine();
                            Console.WriteLine("Please enter the correct amount and agian perform the task");
                            Console.WriteLine();
                            Console.WriteLine("Thank you for visiting LenaDena Bank ATM");
                            break;
                        }
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine($"Your current amount in your saving account is {amount}");
                        Console.WriteLine();
                        Console.WriteLine("Please enter the amount you want to deposite");
                        DateTime dt = DateTime.Now;
                        long damount = long.Parse(Console.ReadLine());
                        long fdamount = amount + damount;
                        if (damount <= 40000)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Your amount has been successfully deposited");
                            Console.WriteLine();
                            Console.WriteLine($" You deposited Rs {damount} in your savings account on  {dt:f}");
                            Console.WriteLine();
                            Console.WriteLine($" Your total amount in your saving account is:- {fdamount}");
                            Console.WriteLine();
                            Console.WriteLine("Thank you for visiting LenaDena Bank ATM");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("You cannot deposite more than Rs 40000 in a day in ATM");
                            Console.WriteLine();
                            Console.WriteLine("Thank you for visiting LenaDena Bank ATM");
                        }
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Hello, Before we go we want to verify your password again for security purpose");
                        Console.WriteLine();
                        Console.WriteLine("Please enter your passowrd to process further");
                        int verify = int.Parse(Console.ReadLine());
                        DateTime mt = DateTime.Now;

                        if (verify == password)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please enter new number to add in your account");
                            long num = long.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("As per Your Request, We sucessfully updated your new number in your account ");
                            Console.WriteLine();
                            Console.WriteLine($"You Updated {num} as a new number in your account on {mt:f}");
                            Console.WriteLine();
                            Console.WriteLine("Thank you for visiting LenaDena Bank ATM");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("You entered an incorrrect credentials");
                            Console.WriteLine();
                            Console.WriteLine("Please enter the correct credentials and agian perform the task");
                            Console.WriteLine();
                            Console.WriteLine("If you getting any problem in finding your credentials please visit your home branch of LenaDena Bank");
                            Console.WriteLine();
                            Console.WriteLine("Thank you for visiting LenaDena Bank ATM");
                        }
                        break;

                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Your Last 10 transaction History");
                        Console.WriteLine();
                        Console.WriteLine(" 20000 withdraw");
                        Console.WriteLine();
                        Console.WriteLine(" 20000 withdraw");
                        Console.WriteLine();
                        Console.WriteLine(" 20000 withdraw");
                        Console.WriteLine();
                        Console.WriteLine(" 20000 withdraw");
                        Console.WriteLine();
                        Console.WriteLine(" 20000 withdraw");
                        Console.WriteLine();
                        Console.WriteLine(" 20000 withdraw");
                        Console.WriteLine();
                        Console.WriteLine(" 20000 withdraw");
                        Console.WriteLine();
                        Console.WriteLine(" 20000 withdraw");
                        Console.WriteLine();
                        Console.WriteLine(" 20000 withdraw");
                        Console.WriteLine();
                        Console.WriteLine(" 20000 withdraw");
                        Console.WriteLine();
                        Console.WriteLine("Thank you for visiting LenaDena Bank ATM");
                        break;

                    case 5:
                        Console.WriteLine();
                        Console.WriteLine("Please enter your Password for verification");
                        int np = int.Parse(Console.ReadLine());
                        if (np == password)
                        {
                            Console.WriteLine("Please enter your new password of 6 numeric digit");
                            int npp = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please re-enter your new password");
                            int npp1 = int.Parse(Console.ReadLine());
                            DateTime dt1 = DateTime.Now;


                            if (npp == npp1)
                            {
                                Console.WriteLine("As per your request your password has been sucessfully updated");
                                Console.WriteLine();
                                Console.WriteLine($"Your sucessfully changed your password on {dt1:f}");
                                Console.WriteLine();
                                Console.WriteLine("Thank you for visiting LenaDena Bank ATM");

                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Password your re-enetred is not matched with password");
                                Console.WriteLine();
                                Console.WriteLine("Please perform the task again to change your password due security reasons");
                                Console.WriteLine();
                                Console.WriteLine("If you getting any problem in finding your credentials please visit your home branch of LenaDena Bank");
                                Console.WriteLine();
                                Console.WriteLine("Thank you for visiting LenaDena Bank ATM");
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("You entered an incorrrect credentials");
                            Console.WriteLine();
                            Console.WriteLine("Please enter the correct credentials and agian perform the task");
                            Console.WriteLine();
                            Console.WriteLine("If you getting any problem in finding your credentials please visit your home branch of LenaDena Bank");
                            Console.WriteLine();
                            Console.WriteLine("Thank you for visiting LenaDena Bank ATM");
                        }


                        break;




                }

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You entered an incorrrect credentials");
                Console.WriteLine();
                Console.WriteLine("Please enter the correct credentials and agian perform the task");
                Console.WriteLine();
                Console.WriteLine("If you getting any problem in finding your credentials please visit your home branch of LenaDena Bank");
                Console.WriteLine();
                Console.WriteLine("Thank you for visiting LenaDena Bank ATM");
            }

            Console.ReadLine();
        }
    }
}