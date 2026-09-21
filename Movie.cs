namespace COMPSCI221
{
    //Task 1/10
    internal class Movie
    {
        private string title;
        private string director;
        private int year;

        //Task 2/10
        public Movie(string title, string director, int year)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new Exception("Title cannot be null and must have non-zero length.");
            }
            this.title = title;

            if (string.IsNullOrWhiteSpace(director))
            {
                throw new Exception("Director cannot be null and must have non-zero length.");
            }
            this.director = director;

            if (year < 1900 || year > 2026)
            {
                throw new Exception("Year must be from 1900 to 2026.");
            }
            this.year = year;
        }

        //Task 3/10
        public override string ToString()
        {
            return $"{title} by {director} ({year})";
        }

        public string Title
        {
            get => title;
        }

        public string Director
        {
            get => director;
        }

        public int Year
        {
            get => year;
        }
    }
}