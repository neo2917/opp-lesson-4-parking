using System;
using System.Collections.Generic;
using System.Text;

namespace opp_lesson_4_parking
{
    public class Customer
    {
        public int hoursParked { get;  set; }

        public string Registration { get; set; }

        public Customer(string registration, int hoursParked)
        {
            Console.WriteLine("I am the customer");
            Registration = registration;
            HoursParked = hoursParked;
        }

        public int HoursParked { get; }

        public override string ToString()
        {
            return "I am the customer";
        }
    }
}
