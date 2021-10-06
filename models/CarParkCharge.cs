using System;
using System.Collections.Generic;
using System.Text;

namespace opp_lesson_4_parking
{
    public class CarParkCharge
    {
        public int minimumFee { get; set; }
        public int minimumHours { get; set; }
        public CarParkCharge(int minimumFee = 2, int minimumHours = 3)
        {
            Console.WriteLine("I am the car park charge");
            this.minimumFee = minimumFee;
            this.minimumHours = minimumHours;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public int CalculateCharge(int hoursParked)
        {
            int calculatedFee = hoursParked < minimumHours ? minimumFee : hoursParked * minimumFee;
            return hoursParked + minimumFee; ;
        }
    }
}
