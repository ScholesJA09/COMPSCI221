class LE1
{
    static void Main()
    {
        //Task 1
        Console.WriteLine("Hello World!");

        //Task 2
        string name = "Ethan Jones";
        int age = 27;
        string jobTitle = "Computer Programmer";
        int salary = 80000;
        bool isManager = false;

        //Task 3
        Console.WriteLine($"{name} is a {age}-year old {jobTitle} who makes ${salary:N} per year.");

        if (isManager == true)
        {
            Console.WriteLine("They are a manager.");
        }
        else
        {
            Console.WriteLine("They are not a manager.");
        }

        //Task 4
        double[] hours = [8.0, 7.5, 8.5, 8.0, 4.0, 0.0, 0.0];

        //Task 5
        double totalHoursWorked = 0;
        for (int i = 0; i < hours.Length; i++)
        {
            totalHoursWorked += hours[i];
        }

        Console.WriteLine($"{name} worked a total of {totalHoursWorked:N2} hours this week.");

        //Task 6
        double averageHours = totalHoursWorked / 7;
        Console.WriteLine($"{name} worked an average of {averageHours:N2} hours this week.");

        //Task 7
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        Console.Write("Enter your age: ");
        int userAge = int.Parse(Console.ReadLine());

        //Task 8
        if (userAge < 18 || userAge > 100)
        {
            Console.WriteLine("Invalid age entered. Please enter an age between 18 and 100.");
            throw new InvalidOperationException("Invalid operation!");
        }

        //Task 10
        greetingMessage(name, age);
        greetingMessage(userName, userAge);
    }
    //Task 9
    static void greetingMessage(string name, int age)
    {
        Console.WriteLine($"Hello, {name}! You are {age} years old!");
    }
}