namespace COMPSCI221
{
    class GraduateStudent : Student , IEmployee
    {
        protected double salary;

        public GraduateStudent(string firstName, string lastName, int id, string major, string minor, double gpa, double salary)
            : base(firstName, lastName, id, major, minor, gpa)
        {
            Salary = salary;
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

        public override string ToString()
        {
            return $"{lastName}, {firstName} ({id}) [Studying {major}] GPA: {gpa:F1} (${salary})";
        }
    }
}
