namespace COMPSCI221
{
    internal class LE2
    {
        private static void Main()
        {
            //Task 5/7
            Flight[] flights = new Flight[]
            {
                new Flight(4570, "Tokyo", "Honolulu", 400),
                new Flight(6409, "Chicago", "Detroit", 200),
                new Flight(8432, "Toronto", "Rome", 500),
                new Flight(9913, "Milwaukee", "Charlotte", 300),
                new Flight(1920, "New York City", "Los Angeles", 350)
            };

            //Task 6/7
            foreach (Flight f in flights)
            {
                Console.WriteLine(f);
            }

            //Task 7/7
            Console.WriteLine("\n---HOLIDAY SALE! 25% OFF ALL FLIGHTS OVER $300---\n");

            foreach (Flight f in flights)
            {
                if(f.Price >= 300)
                {
                    f.Price = f.Price * 0.75;
                }
            }

            foreach (Flight f in flights)
            {
                Console.WriteLine(f);
            }
        }
    }
}
