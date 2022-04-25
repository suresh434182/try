using System;
using System.Text.RegularExpressions;

namespace PhoneNumberValidator
{
    //Please do not change the signature of class methods
    public class PhoneNumberValidator
    {
        static void Main(string[] args)
        {
            // call the functions to validate phone number and display the status
            string  ar = null;
            ar = PhoneNumberValidator.GetInput();

            int result = PhoneNumberValidator.ValidatePhoneNumber(ar);
            PhoneNumberValidator.DisplayResult(result);

        }
        public static string  GetInput()
        {
            // get phonenumber as input  
            Console.WriteLine("Sample Input:");
            return Console.ReadLine();

        }
        public static void DisplayResult(int result)
        {
            // display status of phone number valid or invalid
            if (result == 1)
                Console.WriteLine("\nExpected Output:\n{0}", "Valid");
            else
                Console.WriteLine("\nExpected Output:\n{0}", "Invalid");
            Console.ReadKey();
        }
        public static int ValidatePhoneNumber(string input)
        {
            // validate phone-number
            // for null or empty value, function should return -1
            // for invalid phone-number, function should return 0
            // for valid phone-number, function should return 1
            int result;

            bool res;
            Regex r = new Regex("^[1-9]{1}[0-9]{1}-[0-9]{3}-[0-9]{5}$");
            if (String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input))
                result = -1;
            else
            {
                res = r.IsMatch(input);
                if (res)
                    result = 1;
                else
                    result = 0;
            }
            return result;


        }
    }
}