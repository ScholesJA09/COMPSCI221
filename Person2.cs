namespace COMPSCI221
{
    class Person2
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person2(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("First name cannot be empty.");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Last name cannot be empty.");
                }
                lastName = value;
            }
        }

        public int Id
        {
            get => id;
            set
            {
                if (value < 1000000 || value > 9999999)
                {
                    throw new Exception("ID must be between 1000000-9999999.");
                }
                id = value;
            }
        }
    }
}
