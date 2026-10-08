namespace COMPSCI221
{
    class Animal
    {
        private string name;
        private int age;
    }

    public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw Exception("Name cannot be null or zero length.");
                }
            }
        }

    }
}
