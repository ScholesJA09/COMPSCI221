namespace COMPSCI221
{
    public interface IAnimal
    {
        //All animals have these methods
        void Speak();
        void BathTime();

        //All animals have these properties
        string Name { get; set; }
        int Age { get; set; }

    }
}