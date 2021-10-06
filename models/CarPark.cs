using System;
using System.Collections.Generic;
using System.Text;

namespace opp_lesson_4_parking
{
    public class CarPark
    {
        public List<Customer> listOfCustomers = new List<Customer>();

        public CarParkCharge carParkCharge = new CarParkCharge();
        public CarPark()
        {
            Console.WriteLine("I am the Carpark()");
        }
        public override string ToString()
        {
            return "I am the Carpark()";
        }

        public void CalculateCharges()
        {
            foreach (Customer customer in listOfCustomers)
            {
                int calculatedCharge = carParkCharge.CalculateCharge(customer.hoursParked);
                Console.WriteLine($"Calculating charge for customer : cost is {calculatedCharge} euro for registration {Registration}");
            }
        }
    }
}
