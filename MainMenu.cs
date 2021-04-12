using System;
using System.Collections.Generic;
using System.Text;

namespace C0567_OO_OTS
{
    class MainMenu
    {
        public void HomeMenu()
        {
            string showName = "", showDate = "", showTime = "";
            var show = new Show();
            var showSeat = new ShowSeat();

            string choice;

            Console.WriteLine("You have succesfully logged in");
            Console.WriteLine("1. Buy tickets for a show");
            Console.WriteLine("2. Log Out");
            Console.WriteLine("Please enter your desired option to proceed.");
            choice = Console.ReadLine();

            while (choice != "1" && choice != "2")
            {
                Console.WriteLine("Please select a valid option.");
                choice = Console.ReadLine();
            }

            switch (choice)
            {
                case "1":
                    show.SelectShow(showName, showDate);
                    show.SelectTime(showTime);
                    showSeat.GetNumSeats();
                    showSeat.PurchaseSeat();
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
            };
        }
    }
}
    
