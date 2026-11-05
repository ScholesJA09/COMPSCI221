namespace COMPSCI221
{
    public static class _09_EnumsAndSwitch
    {
        static void TellItLikeItIs(Day d)
        {
            switch (d) //Switch behavior based on some value (Day)
            {
                case Day.Monday:
                    Console.WriteLine("Mondays are the worst.");
                    break; //End switch statement
                case Day.Friday:
                    Console.WriteLine("Fridays are great.");
                    break;
                case Day.Saturday:
                case Day.Sunday:
                    Console.WriteLine("Weekends are the best.");
                    break;
                default:
                    Console.WriteLine("Midweeks are alright.");
                    break;
            }
        }

        static void Main()
        {
            Day thisDay = Day.Thursday;
            Month thisMonth = Month.November;
            int thisDate = 5;

            Console.ForegroundColor = ConsoleColor.Red; //Text Color
            Console.BackgroundColor = ConsoleColor.Green; //Highlight Color

            Console.WriteLine($"Today is {thisDay}, {thisMonth} {thisDate}.");

            TellItLikeItIs(thisDay);

            Console.ResetColor(); //Reset Color before program ends
        }
    }
}
