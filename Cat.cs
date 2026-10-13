namespace COMPSCI221
{
    class Cat : Animal //Cat class derives from Animal
    {
        public Cat(string name, int age) : base(name, age) //Delegating constructor call
        {
        }

        public override void Speak() //Override in Cat from Animal
        {
            Console.WriteLine("Meow!");
        }

        public override void BathTime()
        {
            Console.WriteLine($"{name} is a cat and doesn't like water.");
        }
    }
}