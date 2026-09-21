namespace COMPSCI221
{
    //Task 5/10
    internal class Theater
    {
        private Movie currentlyShowing;
        private double price;
        private int numSeats;

        //Task 6/10
        public Theater(Movie currentlyShowing, double price, int numSeats)
        {
            CurrentlyShowing = currentlyShowing;
            Price = price;

            if (numSeats < 0)
            {
                throw new Exception("A theater cannot have negative seats.");
            }
            this.numSeats = numSeats;
        }

        //Task 7/10
        public override string ToString()
        {
            return $"{numSeats} seats available to see {currentlyShowing} for ${price}";
        }

        public Movie CurrentlyShowing
        {
            get => currentlyShowing;

            set
            {
                currentlyShowing = value;
            }
        }

        public double Price
        {
            get => price;

            set
            {
                if (value < 0)
                {
                    throw new Exception("Price cannot be negative.");
                }
                price = value;
            }
        }

        public int NumSeats
        {
            get => numSeats;
        }
    }
}
