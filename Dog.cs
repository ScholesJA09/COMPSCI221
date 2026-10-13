namespace COMPSCI221
{
    class Dog : Animal //Dog class derives from Animal
    {
        public Dog(string name, int age) : base(name, age) //Delegating constructor call
        {
        }

        public override void Speak() //Override in Dog from Animal
        {
            Console.WriteLine("Woof!");
        }

        public void PlayFetch()
        {
            Console.WriteLine($"Played fetch with {name}.");
        }
    }
}