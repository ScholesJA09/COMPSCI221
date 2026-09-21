namespace COMPSCI221
{
    static class ObjectOrientedProgramming
    {
        private static void Main()
        {
            string name1 = "Alice"; //Parallel Arrays
            int id1 = 1234567;
            double salary1 = 55000.00;

            Person p1 = new Person("Alice", 1234567, 55000); //Person Class Instantiation & Constructor

            //Print out employee
            Console.WriteLine($"Employee 1: {p1.Name}, ID: {p1.Id}, Salary: {p1.Salary:C2}");
            Console.WriteLine(p1);

            //Person p3 = p2; //No copy is being made, memory address of p2 goes into p3 = any changes to p2 changes p3
        }
    }
}