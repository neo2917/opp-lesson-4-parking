using System;
using System.Collections.Generic;
using System.Text;

namespace opp_lesson_4_parking
{
    public class Driver
    {
        public Driver()
        {
            Console.WriteLine("I am the code driver");
        }

        public void CreateObjects()
        {
            CarPark carpark = new CarPark();

            carpark.listOfCustomers.Add(new Customer("a",2));
            carpark.listOfCustomers.Add(new Customer("b",3));
            carpark.listOfCustomers.Add(new Customer("c",4));
            carpark.listOfCustomers.Add(new Customer("d",5));

            carpark.CalculateCharges();

            Customer customer = new Customer("e",6);
            CarParkCharge carparkcharge = new CarParkCharge();

            // Call the ToSTring Method

            Console.WriteLine(carpark.ToString());
            Console.WriteLine(customer.ToString());
            Console.WriteLine(carparkcharge.ToString());
        }

        


    }
}
