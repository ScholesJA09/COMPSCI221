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

            Animal mewlie = new Cat("Mewlie", 12); //Polymorphism - many forms
            Animal a1 = koro; //Upcast
            Animal a2 = mona;
            a1.Speak();
            a2.Speak();
            //Objects still know their identity

            Animal[] animals = [ //Implicit Upcasting
                new Cat("Oliver", 17),
                new Dog("Abbey", 16),
                new Dog("Koro", 5),
                new Cat("Pepper", 9)];

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
                animals[i].Speak();
                animals[i].BathTime();

                //if (animals[i] is Dog) //Type check
                //{
                //    Dog d = (Dog)animals[i]; //Explicit Downcasting
                //    d.PlayFetch();
                //}

                //Dog d = animals[i] as Dog; //Downcasts as long as type is Dog
                //d?.PlayFetch(); //? = Checks if it is not null

                if (animals[i] is Dog d) //Pattern Matching
                {
                    d.PlayFetch();
                }
            }
        }
    }
}