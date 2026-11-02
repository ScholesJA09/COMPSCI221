namespace COMPSCI221
{
    internal class Instructor : Person2 , IEmployee
    {
        protected string department;
        protected double salary;

        public Instructor(string firstName, string lastName, int id, string department, double salary)
            : base(firstName, lastName, id)
        {
            Department = department;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Prof. {lastName} ({id}) [Dept. of {department}] (${salary})";
        }

        public string Department
        {
            get => department;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Department cannot be empty.");
                }
                department = value;
            }
        }

        public double Salary
        {
            get => salary;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Salary cannot be negative.");
                }
                salary = value;
            }
        }
    }
}
