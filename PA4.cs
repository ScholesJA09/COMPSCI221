namespace COMPSCI221
{
    public static class PA4
    {
        static void Main()
        {
            Person2[] myUniversity = new Person2[]
            {
                new Instructor("First", "Ikari", 9597792, "Robotics", 35000),
                new GraduateStudent("Eleanor", "Arroway", 1119620, "Astronomy", "Minor", 4.0, 7000),
                new Student("Sam", "Bell", 1151968, "Geology", "Computer Science", 3.2),
                new Instructor("First", "Bowman", 5201936, "Neurology", 50000),
                new GraduateStudent("Paul", "Atreides", 1227195, "Political Science", "Minor", 3.4, 6000),
                new Student("Louise", "Banks", 8201974, "Communication", "Philosophy", 3.8),
                new Instructor("First", "Gannon", 1012767, "Medicine", 40000),
                new GraduateStudent("Veronica", "Santangelo", 1532109, "Engineering", "Minor", 3.9, 8000),
                new Student("Ren", "Amamiya", 1125102, "Criminology", "Psychology", 3.1)
            };

            Console.WriteLine("Everyone at the university:");

            for (int i = 0; i < myUniversity.Length; i++)
            {
                Person2 p = myUniversity[i];

                if (p is Instructor inst)
                {
                    Console.WriteLine($"Prof. {inst.LastName} ({inst.Id}) [Dept. of {inst.Department}] (${inst.Salary})");
                }

                else if (p is GraduateStudent gs)
                {
                    Console.WriteLine($"{gs.LastName}, {gs.FirstName} ({gs.Id}) [Studying {gs.Major}] GPA: {gs.Gpa:F1} (${gs.Salary})");
                }

                else if (p is Student s)
                {
                    Console.WriteLine($"{s.LastName}, {s.FirstName} ({s.Id}) [{s.Major} Major / {s.Minor} Minor] GPA: {s.Gpa:F1}");
                }
            }

            Console.WriteLine("\nGraduate students enrolled at the university:");

            for (int i = 0; i < myUniversity.Length; i++)
            {
                Person2 p = myUniversity[i];

                if (p is GraduateStudent gs)
                {
                    Console.WriteLine($"{gs.LastName}, {gs.FirstName} ({gs.Id}) [Studying {gs.Major}] GPA: {gs.Gpa:F1} (${gs.Salary})");
                }
            }

            Console.WriteLine("\nAverage GPA of all students at the university:");
            double totalGPA = 0;
            int count = 0;

            for (int i = 0; i < myUniversity.Length; i++)
            {
                Person2 p = myUniversity[i];

                if (p is Student s)
                {
                    totalGPA += s.Gpa;
                    count++;
                }
            }

            Console.WriteLine($"{(totalGPA / count):F3}");

            IEmployee highestPaid = null;
            IEmployee lowestPaid = null;

            for (int i = 0; i < myUniversity.Length; i++)
            {
                Person2 p = myUniversity[i];

                if (p is IEmployee em)
                {
                    if (highestPaid == null)
                    {
                        highestPaid = em;
                        lowestPaid = em;
                    }

                    else if (em.Salary > highestPaid.Salary)
                    {
                        highestPaid = em;
                    }

                    else if (em.Salary < lowestPaid.Salary)
                    {
                        lowestPaid = em;
                    }
                }
            }

            Console.WriteLine("\nHighest paid employee:");
            Console.WriteLine(highestPaid);
            Console.WriteLine("\nLowest paid employee:");
            Console.WriteLine(lowestPaid);
        }
    }
}
