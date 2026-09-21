namespace COMPSCI221
{
    class Flight
    {
        //Task 1/7
        private int number;
        private string departure;
        private string arrival;
        private double price;

        //Task 3/7
        public Flight(int number, string departure, string arrival, double price)
        {
            if (number < 1000 || number > 9999)
            {
                throw new Exception("Invalid flight number.");
            }
            this.number = number;

            if (string.IsNullOrWhiteSpace(departure))
            {
                throw new Exception("Invalid departure city.");
            }
            this.departure = departure;

            if (string.IsNullOrWhiteSpace(arrival))
            {
                throw new Exception("Invalid arrival city.");
            }
            this.arrival = arrival;

            Price = price;
        }

        //Task 4/7
        public override string ToString()
        {
            return $"Flight #{number} from {departure} to {arrival} (${price:N2})";
        }

        //Task 2/7
        public int Number
        {
            get => number;
        }

        public string Departure
        {
            get => departure;
        }

        public string Arrival
        {
            get => arrival;
        }

        public double Price
        {
            get => price;

            set
            {
                if (value < 0 || value > 999.99)
                {
                    throw new Exception("Invalid price.");
                }
                price = value;
            }
        }
    }
}
