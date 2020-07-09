using System;
using System.Text.RegularExpressions;
namespace Validating_input
{
    class Program
    {
        static void Main()
        {
            Phone();
            BirthDate();
            Email();
        }
        static void Phone()
        {
            Console.WriteLine("Please enter your phone number.");
            string phone = Console.ReadLine();
            Regex reg = new Regex(@"^[0-9]{3}-[0-9]{3}-[0-9]{4}$");
            bool isValid = reg.IsMatch(phone);
            
            if (!isValid)
            {
                Console.WriteLine("Invalid Phone Number.");
                Phone();
            }

        }
        static void BirthDate()
        {
            Console.WriteLine("Please enter your birth date.");
            string birthdate = Console.ReadLine();
            Regex reg = new Regex(@"((0[0-1]|1[\d])\/(0[0-3]|1[\d])\/((19|20)\d\d))$");
            bool isValid = reg.IsMatch(birthdate);

            if (!isValid)
            {
                Console.WriteLine("Invalid Date.");
                BirthDate();
            }
        }
        static void Email()
        {
            Console.WriteLine("Please enter your email address.");
            string email = Console.ReadLine();
            Regex reg = new Regex(@"^([A-z]|[a-z]|[0-9]){5,30}\@([A-z]|[a-z]|[0-9]){5,10}\.([A-z]|[a-z]|[0-9]){2,5}$");
            bool isValid = reg.IsMatch(email);
            
            if (!isValid)
            {
                Console.WriteLine("Invalid Email Address.");
                Email();
            }
        }
    }
}
