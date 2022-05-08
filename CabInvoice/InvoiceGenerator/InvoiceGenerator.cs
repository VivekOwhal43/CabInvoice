namespace CabInvoice
{
    public class InvoiceGenerator
    {
        public static int COST_PER_KM = 10, COST_PER_MIN = 1, MIN_FARE = 5;
        public int distance, travelTime, fare;

        public void calculateFare()
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
                Console.WriteLine($"Total Fare {fare}");
                if (fare < MIN_FARE)
                {
                    fare = MIN_FARE;
                    Console.WriteLine($"Rounding off Amount \nTotal Fare {fare}");
                }
            }
            catch (InvoiceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}