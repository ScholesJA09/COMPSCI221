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
                using StreamWriter writer = new StreamWriter(path);
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

        }

        static void Main()
        {
            FileWritingDemo();
        }
    }
}
