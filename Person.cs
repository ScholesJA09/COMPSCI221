namespace COMPSCI221
{
    class Person //Declaring a class, Reference Semantics / Goes to Heap
    {
        //Declaring Class Variables (FIELDS)
        private string name;
        private int id;
        private double salary;

        //Constructor
        public Person(string name, int id, double salary)
        {
            Name = name;

            if (id < 1000000 || id > 9999999)
            {
                throw new Exception("Id must be a 7-digit number.");
            }
            this.id = id;

            Salary = salary;
        }

        public override string ToString() //Print out when p1 is called *DONT PRINT*
        {
            return $"Employee 1: {Name}, ID: {Id}, Salary: {Salary:C2}";
        }

        //Encapsulating with Properties
        public string Name
        {
            //Get Accessor
            get
            {
                return name;
            }
            //Set Accessor
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be null or empty.");
                }
                name = value;
            }
        }

        public int Id //Read only
        {
            get => id;
        }

        //Or public int Id { get; }

        public double Salary
        {
            get => salary; //same as before

            set
            {
                if(value < 0)
                {
                    throw new Exception("Salary must be positive.");
                }
                salary = value;
            }
        }
    }
}
