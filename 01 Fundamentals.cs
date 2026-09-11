class Fundamentals //Same name as file
{
    static void Main() //Main must be capitalized
    {
        Console.WriteLine("Hello, World!"); //Printing out

        byte a;
        bool b; //1 byte
        char c; //2 bytes
        short d; //2 bytes
        int e; //4 bytes
        float f; //4 bytes
        long g; //8 bytes
        double h; //8 bytes

        sbyte i; //signed byte
        ushort j; //unsigned short
        uint k; //unsigned int
        ulong l; //unsigned long

        string m;

        string name = "Jacob";
        int age = 21;
        double salary = 55000;
        double percent = 0.44;

        Console.WriteLine($"Hello {name}, you are {age} years old. Your salary is {salary:N}."); //Preferred string interperlation & number formatter
        Console.WriteLine($"{percent:P1}"); //Percent formatter

        name = name + " Scholes";

        name = name.ToUpper(); //Uppercase method
        Console.WriteLine(name);
        name = name.ToLower(); //Lowercase method
        Console.WriteLine(name);

        Console.WriteLine(name.Length); //Length property

        //User Input
        Console.Write("Enter your name: "); //Enter on same line
        string newName = Console.ReadLine();

        Console.Write("Enter your age: ");
        int newAge = int.Parse(Console.ReadLine()); //Parsing a string to an int

        Console.WriteLine($"Hello {newName}, you are {newAge} years old.");

        //Functions/Methods
        DoSomething();

        //Arrays
        int[] array = new int[5]; //Empty
        int[] array2 = [1, 2, 3, 4, 5]; //Know what to put in

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
    static void DoSomething()
    {

    }
}