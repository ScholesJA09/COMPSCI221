namespace COMPSCI221
{
    internal interface IFlying : IAnimal
    {
        void Fly() //Can use name because it impliments IAnimal
        {
            Console.WriteLine($"{Name} is flying.");
        }
    }
}
