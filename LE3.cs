namespace COMPSCI221
{
    internal class LE3
    {
        static void Main()
        {
            //Task 1/5
            double[] grades = [95.5, 72.6, 88.3, 62.9, 89.9, 70.4, 79.8, 97.1];
            Console.WriteLine($"{string.Join(", ", grades)}");
            Console.WriteLine($"\nAverage: {GetAverage(grades):F2}");
            char[] chars = ToLetterGrades(grades);

            Console.WriteLine("\nScores:");
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine($"{grades[i]} : {chars[i]}");
            }

            Console.WriteLine("\nApplying curve...");
            ApplyCurve(grades, 1.02);

            //Task 5/5
            for (int i = grades.Length - 1; i > -1; i--)
            {
                Console.Write($"{grades[i]:F2}, ");
            }
        }

        //Task 2/5
        static double GetAverage(double[] scores)
        {
            double sum = 0;
            int count = 0;

            if (scores == null || scores.Length == 0)
            {
                throw new Exception("Array can't be null or be 0 length.");
            }

            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
                count++;
            }

            return sum / count;
        }

        //Task 3/5
        static char[] ToLetterGrades(double[] scores)
        {
            char[] chars;
            chars = new char[scores.Length];

            if (scores == null || scores.Length == 0)
            {
                throw new Exception("Array can't be null or be 0 length.");
            }

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > 100)
                {
                    throw new Exception("No score can't be greater than 100.");
                }
                else if (scores[i] >= 90)
                {
                    chars[i] = 'A';
                }
                else if (scores[i] >= 80)
                {
                    chars[i] = 'B';
                }
                else if (scores[i] >= 70)
                {
                    chars[i] = 'C';
                }
                else if (scores[i] >= 61)
                {
                    chars[i] = 'D';
                }
                else
                {
                    chars[i] = 'F';
                }
            }

            return chars;
        }

        //Task 4/5
        static void ApplyCurve(double[] scores, double multiplier)
        {
            if (scores == null || scores.Length == 0)
            {
                throw new Exception("Array can't be null or be 0 length.");
            }

            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = scores[i] * multiplier;
            }
        }
    }
}
