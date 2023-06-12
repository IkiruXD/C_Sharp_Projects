using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGZ
{
    class ComparisonTime
    {
        private string cityOne;
        private string cityTwo;

        private double hourOne;
        private double hourTwo;

        private DateTime dateCurrent;

        public ComparisonTime()
        {
        }

        public ComparisonTime(string cityOne, string cityTwo, int hourOne, int hourTwo, DateTime dateCurrent)
        {
            this.cityOne = cityOne;
            this.cityTwo = cityTwo;
            this.hourOne = hourOne;
            this.hourTwo = hourTwo;
            this.dateCurrent = dateCurrent;
        }

        public string CityTwo
        {
            get { return cityTwo; }
            set { cityTwo = value; }
        }

        public double HourOne
        {
            get { return hourOne; }
            set { hourOne = value; }
        }


        public double HourTwo
        {
            get { return hourTwo; }
            set { hourTwo = value; }
        }

        public string CityOne
        {
            get { return cityOne; }
            set { cityOne = value; }
        }


        public string calculateTimeTwoCity() {
            DateTime PresentDateOne = new DateTime();
            PresentDateOne = DateTime.UtcNow.ToLocalTime();
            PresentDateOne = PresentDateOne.AddHours(hourOne).ToLocalTime();

            DateTime PresentDateTwo = new DateTime();
            PresentDateTwo = DateTime.UtcNow.ToLocalTime();
            PresentDateTwo = PresentDateTwo.AddHours(hourTwo).ToLocalTime();

            Console.WriteLine(PresentDateOne.Hour);
            Console.WriteLine(PresentDateTwo.Hour);


            string rezult = "Разница во времени: "+ Math.Abs(PresentDateOne.Hour - PresentDateTwo.Hour) + " час(а/ов), "  + Math.Abs(PresentDateOne.Minute - PresentDateTwo.Minute)+" минут.";

            return rezult;
        } 
    }
}
