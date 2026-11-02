namespace COMPSCI221
{
    class Student : Person2
    {
        protected string major;
        protected string minor;
        protected double gpa;

        public Student(string firstName, string lastName, int id, string major, string minor, double gpa)
            : base(firstName, lastName, id)
        {
            Major = major;
            Minor = minor;
            Gpa = gpa;
        }

        public override string ToString()
        {
            return $"{lastName}, {firstName} ({id}) [{major} Major / {minor} Minor] GPA: {gpa:F1}";
        }

        public string Major
        {
            get => major;
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Major cannot be empty.");
                }
                major = value;
            }
        }

        public string Minor
        {
            get => minor;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Minor cannot be empty.");
                }
                minor = value;
            }
        }

        public double Gpa
        {
            get => gpa;
            set
            {
                if (value < 0.0 || value > 4.0)
                {
                    throw new Exception("GPA must be between 0.0-4.0.");
                }
                gpa = value;
            }
        }
    }
}
