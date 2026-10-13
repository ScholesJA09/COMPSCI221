namespace COMPSCI221
{
    abstract class Animal //Abstract - Shouldn't be instantiated
    {
        protected string name; //Protected = subclasses can use fields
        protected int age;

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void Speak(); //abstract = Animal cannot speak, but its subclasses can

        public virtual void BathTime() //virtual = Option of overriding, need to still have a body
        {
            Console.WriteLine($"{name} took a bath.");
        }

        public sealed override string ToString() //sealed = cannot be overwritten anymore in child classes
        {
            return $"{name} is {age} years old.";
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be null or zero length.");
                }
                name = value;
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Age must be positive");
                }
                age = value;
            }
        }
    }
}