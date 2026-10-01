namespace COMPSCI221
{
    static class LE4
    {
        //Task 1/4
        static int GetLineCount(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("File not found.", path);
            }

            int count = 0;
            using StreamReader reader = new StreamReader(path);

            while (!reader.EndOfStream)
            {
                reader.ReadLine();
                count++;
            }

            return count;
        }

        static Movie[] ReadMoviesFromFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("File not found.", path);
            }

            int lineCount = GetLineCount(path);

            Movie[] movies = new Movie[lineCount - 1];

            using StreamReader reader = new StreamReader(path);
            reader.ReadLine();

            for (int i = 0; i < movies.Length; i++)
            {
                string line = reader.ReadLine();
                string[] cols = line.Split(',');

                string title = cols[0];
                string directorLast = cols[1];
                string directorFirst = cols[2];
                int year = int.Parse(cols[3]);
                double rating = double.Parse(cols[4]);

                movies[i] = new Movie(title, year, directorFirst, directorLast, rating);
            }

            return movies;
        }

        static void WriteMovieToFile(Movie movie, string sortedPath)
        {
            using StreamWriter writer = new StreamWriter(sortedPath, true);
            string line = string.Join(',', movie.Title, movie.DirectorLastName, movie.DirectorFirstName, movie.Year, movie.Rating);
            writer.WriteLine(line);
        }

        static void Main()
        {
            //Task 2/4
            string path = "movies-star-wars.csv";

            Movie[] movies = ReadMoviesFromFile(path);

            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(movies[i]);
            }

            //Task 3/4
            for (int i = 0; i < movies.Length; i++)
            {
                int min_index = i;
                for (int j = i + 1; j < movies.Length; j++)
                {
                    if (movies[j].Rating > movies[min_index].Rating)
                    {
                        min_index = j;
                    }
                }
                if (min_index != i)
                {
                    Movie temp = movies[i];
                    movies[i] = movies[min_index];
                    movies[min_index] = temp;
                }
            }

            Console.WriteLine();
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(movies[i]);
            }

            //Task 4/4
            string sortedPath = "movies-star-wars-sorted.csv";

            using StreamWriter writer = new StreamWriter(sortedPath);
            writer.WriteLine("Title,Director Last Name,Director First Name,Year,Rating");
            writer.Close();

            for (int i = 0; i < movies.Length; i++)
            {
                WriteMovieToFile(movies[i], sortedPath);
            }
        }
    }
}