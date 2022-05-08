using System.Collections;

namespace CabInvoice
{
    public class InvoiceGenerator
    {
        public static int COST_PER_KM = 10, COST_PER_MIN = 1, MIN_FARE = 5;
        public int distance, travelTime, fare, num_of_rides;
        public List<int> multipleRideFareList = new List<int>();
        public void calculateFare()
        {
            Console.Write("Enter Number of Rides: ");
            num_of_rides = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num_of_rides; i++)
            {
                Console.Write("Please Enter Travelled Distance : ");
                distance = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please Enter Travelling Time in Minuts: ");
                travelTime = Convert.ToInt32(Console.ReadLine());
                distance = COST_PER_KM * distance;
                travelTime = COST_PER_MIN * travelTime;

                try
                {
                    fare = distance + travelTime;
                    Console.WriteLine($"Total Fare {fare} \n");
                    if (fare < MIN_FARE)
                    {
                        fare = MIN_FARE;
                        Console.WriteLine($"Rounding off Amount \nTotal Fare {fare} \n");
                    }
                }
                catch (InvoiceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                multipleRideFareList.Add(fare);
            }
        }

        public void ShowMultipleRideList()
        {
            int averageFare = 0;
            Console.WriteLine("\n=========== List of Ride Fares =========== \n");
            foreach (var rideList in multipleRideFareList)
            {
                Console.WriteLine(rideList);
            }

            foreach (var item in multipleRideFareList)
            {

                averageFare = averageFare + item;
            }
            averageFare = averageFare / num_of_rides;
            Console.WriteLine($"\nAverage Fare: {averageFare}");
        }
    }
}