using System;

namespace C0567_OO_OTS
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "", surname = "", address = "", emailaddress = "";
            var customer = new Customer();
            var menu = new MainMenu();

            customer.GetLogin();
            customer.ProfileInfo(firstName, surname, address, emailaddress);
            menu.HomeMenu();
        }
    }
}








    