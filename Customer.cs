using System;
using System.Collections.Generic;
using System.Text;

namespace C0567_OO_OTS
{
    class Customer
    {
        protected string firstName;
        protected string surname;
        protected string address;
        protected string emailaddress;
        public void CustomerInfo()
        {
            firstName = "";
            surname = "";
            address = "";
            emailaddress = "";
        }
        public void GetLogin()
        {
            string username;
            string password;

            Console.WriteLine("Welcome to the Bucks Centre for the Performing Arts Online Ticketing System");
            Console.WriteLine("Please log in.");
            Console.WriteLine("Enter username: ");
            username = Console.ReadLine();

            while (username.Length > 8)
            {
                Console.WriteLine("Your username has exceeded the 8 charachter limit.");
                Console.WriteLine("Please try enetering your username again: ");
                username = Console.ReadLine();
            }

            Console.WriteLine("Enter password: ");
            password = Console.ReadLine();

            while (password.Length > 11)
            {
                Console.WriteLine("Your password should not exceed the 11 characters limit.");
                Console.WriteLine("Please re-enter your password: ");
                password = Console.ReadLine();
            }
        }

        public void ProfileInfo(string firstName, string surname, string address, string emailaddress)
        {
            Console.WriteLine("Please enter your personal details.");
            Console.WriteLine("Enter your First name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your Surname: ");
            surname = Console.ReadLine();
            Console.WriteLine("Enter your Address: ");
            address = Console.ReadLine();
            Console.WriteLine("Enter your EmailAddress: ");
            emailaddress = Console.ReadLine();
          

            this.firstName = firstName;
            this.surname = surname;
            this.address = address;
            this.emailaddress = emailaddress;
        }
    }
}