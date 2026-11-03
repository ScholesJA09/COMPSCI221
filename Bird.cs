namespace COMPSCI221
{
    class Bird : Animal , IEggLayer , IFlying
    {
        public Bird(string name, int age) : base(name, age) { }

        public override void Speak()
        {
            Console.WriteLine("Tweet!");
        }

        //Other methods can be deleted since they derive from IEggLayer and IFlying

        //public void LayEgg() //Interface
        //{
        //    Console.WriteLine($"{name} layed an egg.");
        //}

        //public void Fly() //Interface
        //{
        //    Console.WriteLine($"{name} is flying.");
        //}
    }
}
