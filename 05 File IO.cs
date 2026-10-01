namespace COMPSCI221
{
    static class _05_File_IO
    {
        static void FileWritingDemo()
        {
            string path = "test.txt"; //Relative file path

            if (File.Exists(path)) //Checks if a certain file exists
            {
                Console.WriteLine("File exists.");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }

            try
            {
                using StreamWriter writer = new StreamWriter(path); //Writing to file
                writer.WriteLine("Hello world!");
                //Using = Disposes whatever you have when clearing (automatically closes)
            }
            catch (Exception e) //Throw an exception if anything goes wrong
            {
                Console.WriteLine("Error while writing to file.");
            }
        }

        static void FileReadingDemo()
        {
            string path = "test.txt"; //Will create file if not already exists

            if (!File.Exists(path))
            {
                Console.WriteLine("File doesn't exist.");
                return;
            }

            try
            {
                using StreamReader reader = new StreamReader(path); //Reading File

                while (!reader.EndOfStream) //Reads until end of file
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while reading file.");
            }
        }

        static void Main()
        {
            //FileWritingDemo();
            FileReadingDemo();        }
    }
}
