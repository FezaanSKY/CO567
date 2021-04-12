using System;
using System.Collections.Generic;
using System.Text;

namespace C0567_OO_OTS
{
    class ShowSeat
    {
        protected int Seats;
        public int GetNumSeats()
        {
            Console.WriteLine("Purchase Seats");
            Console.WriteLine("Please enter the number of seats you wish to Purchase");
            Seats = Convert.ToInt16(Console.ReadLine());
            return Seats;
        }
        public void PurchaseSeat()
        {
            string chs; 

            int seatPrice = 7;
            int totalPrice = Seats * seatPrice;
            Console.WriteLine("The total price for the number of seats selected is £ " + totalPrice + ".");
           
            Console.WriteLine("1.) Continue to Payment?");
            Console.WriteLine("2.) Cancel Purchase?");
            chs = Console.ReadLine();

            while (chs != "1" && chs != "2" && chs != "3")
            {
                Console.WriteLine("Please select your option again: ");
                chs = Console.ReadLine();
            }

            switch (chs)
            {
                case "1":
                    Console.WriteLine("Thank you! You have successfully purchased tickets for your show!");
                    break;
                case "2":
                    Console.WriteLine("Your tickets have been cancelled and you have not been charged");
                    break;
            }
        }
    }
}
