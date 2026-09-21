namespace COMPSCI221
{
    internal class PA1
    {
        //Task 4/10
        static void Main()
        {
            Movie[] movies =
            [
                new Movie("2001: A Space Odyssey", "Stanley Kubrick", 1968),
                new Movie("Interstellar", "Christopher Nolan", 2014),
                new Movie("Blade Runner", "Ridley Scott", 1982)
            ];

            foreach (Movie m in movies)
            {
                Console.WriteLine(m);
            }

            //Task 8&9/10
            Theater[] theaters =
            [
                new Theater(movies[0], 9.99, 30),
                new Theater(movies[2], 14.99, 50),
                new Theater(movies[1], 4.99, 60),
                new Theater(movies[0], 19.99, 90),
                new Theater(movies[2], 14.99, 100)
            ];

            //Task 10/10
            foreach (Theater t in theaters)
            {
                Console.WriteLine(t);
            }
        }
    }
}
