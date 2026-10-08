namespace COMPSCI221
{
    static class LE5
    {
        //Task 2/4
        static int Range(int[] temps)
        {
            if (temps.Length == 0)
            {
                return -1;
            }

            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < temps.Length; i++)
            {
                if (temps[i] < temps[minIndex])
                {
                    minIndex = i;
                }

                else if (temps[i] > temps[maxIndex])
                {
                    maxIndex = i;
                }
            }

            return temps[maxIndex] - temps[minIndex];
        }

        //Task 3/4
        static void PrintReportMin(int[] temps)
        {
            int minIndex = 0;
            int amount = 1;

            for (int i = 1; i < temps.Length; i++)
            {
                if (temps[i] < temps[minIndex])
                {
                    minIndex = i;
                    amount = 1;
                }
                else if (temps[i] == temps[minIndex])
                {
                    amount++;
                }
            }

            Console.WriteLine($"Min: {temps[minIndex]} degrees C first observed on day {minIndex} occurred {amount} time(s).");
        }

        static void PrintReportMax(int[] temps)
        {
            int maxIndex = 0;
            int amount = 1;

            for (int i = 1; i < temps.Length; i++)
            {
                if (temps[i] > temps[maxIndex])
                {
                    maxIndex = i;
                    amount = 1;
                }
                else if (temps[i] == temps[maxIndex])
                {
                    amount++;
                }
            }

            Console.WriteLine($"Max: {temps[maxIndex]} degrees C first observed on day {maxIndex} occurred {amount} time(s).");
        }

        //Task 4/4
        static int Median(int[] temps)
        {
            int[] tempsSorted = new int[temps.Length];

            for (int i = 0; i < tempsSorted.Length; i++)
            {
                tempsSorted[i] = temps[i];
            }

            for (int i = 0; i < tempsSorted.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < tempsSorted.Length; j++)
                {
                    if (tempsSorted[j] < tempsSorted[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    (tempsSorted[i], tempsSorted[minIndex]) = (tempsSorted[minIndex], tempsSorted[i]);
                }
            }

            int median = tempsSorted[tempsSorted.Length / 2];
            return median;
        }

        static void Main()
        {
            //Task 1/4
            int[] array = { 5, -2, 7, 7, 3, -10, 4, 0, -2, 9, 1, -10, 6, 0 };

            int range = Range(array);
            Console.WriteLine($"Temperature range: {range} degrees C");
            PrintReportMin(array);
            PrintReportMax(array);
            int median = Median(array);
            Console.WriteLine($"Median: {median} degrees C");

            Console.WriteLine();

            int[] array2 = { 29, 27, 33, 28, 26, 31, 29, 30, 27, 28, 32, 33, 26, 29, 30, 28, 27, 26, 29, 30, 31 };

            int range2 = Range(array2);
            Console.WriteLine($"Temperature range: {range2} degrees C");
            PrintReportMin(array2);
            PrintReportMax(array2);
            int median2 = Median(array2);
            Console.WriteLine($"Median: {median2} degrees C");
        }
    }
}
