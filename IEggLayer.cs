namespace COMPSCI221
{
    internal interface IEggLayer : IAnimal //Interface = stateless (No Fields/Methods)
        //A contract that defines a set of methods and properties a class must implement
        //Solves the diamond problem
    {
        void LayEgg()
        {
            Console.WriteLine($"{Name} layed an egg.");
        }
    }
}
