namespace COMPSCI221
{
    internal class _08_Inheritance
    {
        static void Main()
        {
            Dog koro = new Dog("Koro", 5);
            Cat mona = new Cat("Mona", 7);
            koro.Speak();
            mona.Speak();
            koro.BathTime();
            mona.BathTime();
            koro.PlayFetch();

            //Animal a = new Animal("Crime against nature!", 10000);

            Animal mewliw = new Cat("Mewlie", 12);
            Animal a1 = koro; //Upcast
            Animal a2 = mona;
            a1.Speak();
            a2.Speak();
            //Objects still know their identity
        }
    }
}