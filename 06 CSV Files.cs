using CompSci221;

namespace COMPSCI221
{
    static class _06_CSV_Files
    {
        static int GetLineCount(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("File not found", path);
            }

            int count = 0;
            using StreamReader reader = new StreamReader(path);

            while(!reader.EndOfStream) //Go through entire file
            {
                reader.ReadLine();
                count++;
            }

            return count;
        }
        static Album[] ReadAlbumsFromFile(string path)
        {
            if(!File.Exists(path))
            {
                throw new FileNotFoundException("File not found", path); //Specific exception
            }

            int lineCount = GetLineCount(path);

            Album[] albums = new Album[lineCount - 1]; //-1 for header line

            using StreamReader reader = new StreamReader(path);
            reader.ReadLine(); //Discards header row

            for (int i = 0; i < albums.Length; i++)
            {
                string line = reader.ReadLine();
                string[] cols = line.Split(','); //Comma delimative

                int rank = int.Parse(cols[0]); //Reading data
                int year = int.Parse(cols[1]);
                string title = cols[2];
                string artist = cols[3];
                string genre = cols[4];

                albums[i] = new Album(title, artist, rank, year, genre); //Creating new album object
            }

            return albums;
        }

        static void WriteAlbumToFile(Album album, string path)
        {
            using StreamWriter writer = new StreamWriter(path, true); //True = doesn't reset file
            //Writing new data
            string line = string.Join(',', album.Rank, album.Year, album.Title, album.Artist, album.Genre);
            writer.WriteLine(line);
        }

        static void Main()
        {
            string path = "Rolling-Stone-Top-500-Albums.csv";

            Album[] albums = ReadAlbumsFromFile(path);

            Console.WriteLine($"Top {albums.Length} Albums:"); //Printing out album class
            for (int i = 0; i < albums.Length; i++)
            {
                Console.WriteLine(albums[i]);
            }
        }
    }
}
