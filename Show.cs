using System;
using System.Collections.Generic;
using System.Text;

namespace C0567_OO_OTS
{
    class Show
    {
        protected string showName;
        protected string showDate;
        protected string showTime;
        public void ShowDetails()
        {
            showName = "";
            showDate = "";
            showTime = "";
        }

        public void SelectShow(string showName, string showDate)
        {
            string ChooseShow;
            Console.WriteLine("1. Fast and Furious 9 (RunTime2hr:05mins)");
            Console.WriteLine("2. The Joker (Runtime 1hr45mins)");
            Console.WriteLine("3. Avengers Infinity war (RunTime 3hr30mins) ");
            Console.WriteLine("4. Load Wedding (Runtime 1hr 22mins)");
            Console.WriteLine("Look out for future upcoming promotions at the BCPA!");
            ChooseShow = Console.ReadLine();

            while (ChooseShow != "1" && ChooseShow != "2" && ChooseShow != "3" && ChooseShow != "4")
            {
                Console.WriteLine("Please select your event listing: ");
                ChooseShow = Console.ReadLine();
            }

            switch (ChooseShow)
            {
                case "1":
                    showName = "Fast and Furious 9 ";
                    showDate = "15/05/2021";
                    break;
                case "2":
                    showName = "The Joker";
                    showDate = "16/05/2021";
                    break;
                case "3":
                    showName = "Load Wedding";
                    showDate = "17/05/2021";
                    break;
            }
            this.showName = showName;
            this.showDate = showDate;
        }

        public void SelectTime(string showTime)
        {
            var showSeat = new ShowSeat();
            string time;

            Console.WriteLine(" Available Screening times");
            Console.WriteLine("A. Saturday 15th May 11:00");
            Console.WriteLine("B. Saturday 15th May 13:00");
            Console.WriteLine("C. Saturday 15th May 15:00");
            Console.WriteLine("D. Saturday 15th May 17:00");
            Console.WriteLine("Please select a showing time.");
            time = Console.ReadLine();

            while (time != "A" && time != "B" && time != "C" && time != "D")
            {
                Console.WriteLine("Please try again.");
                time = Console.ReadLine();
            }
            switch (time)
            {
                case "1":
                    break;
                case "2":
                    break;
            }
            this.showTime = showTime;
        }
    }
}

   