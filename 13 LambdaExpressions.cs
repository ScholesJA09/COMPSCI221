namespace COMPSCI221
{
    static class _13_LambdaExpressions
    {
        private static int CompareByLength(string x, string y)
        {
            if (x.Length < y.Length)
            {
                return -1;
            }

            if (x.Length > y.Length)
            {
                return 1;
            }

            return 0;
        }

        private static bool HasI(string s)
        {
            return s.Contains('i');
        }

        static void Main()
        {
            List<string> words = [ "fig", "kiwi", "cherry", "grape", "date", "mango", "lemon", "banana", "nectarine", "apple" ];

            Console.WriteLine("Words:");
            words.ForEach(Console.WriteLine);
            //ForEach method belongs to List

            Console.WriteLine("\nSorted Words:");
            words.Sort();
            //Default compares strings in alphabetical order
            words.ForEach(Console.WriteLine);

            Console.WriteLine("\nSorted by Length:");
            words.Sort(CompareByLength);
            //Comparision is a delegate that takes two strings and returns an int
            words.ForEach(Console.WriteLine);

            Console.WriteLine("\nWords with 'i':");
            List<string> wordsWithI = words.FindAll(HasI);
            wordsWithI.ForEach(Console.WriteLine);

            Console.WriteLine("\nWords in uppercase:");
            Action<string> printInUppercase = (s) =>
            {
                Console.WriteLine(s.ToUpper());
            };
            //Action must be void and return single parameter string
            //Lambda Expression, a method that has no name, stored in a delegate
            words.ForEach(printInUppercase);
            //Using Lambda Expression

            Console.WriteLine("\nWords sorted by last character:");
            words.Sort((x, y) => //Requires Comparison
            {
                if (x[x.Length - 1] < y[y.Length - 1])
                {
                    return -1;
                }

                if (x[x.Length - 1] > y[y.Length - 1])
                {
                    return 1;
                }

                return 0;
            });
            words.ForEach(Console.WriteLine);

            Console.WriteLine("\nCapitalized words:");
            words.ForEach(s =>
            {
                Console.WriteLine(char.ToUpper(s[0]) + s.Substring(1));
            });

            Console.WriteLine("\nWords with 'e':");
            List<string> wordsWithE = words.FindAll(s => s.Contains('e'));
            //No curly braces/return if single statement
            wordsWithE.ForEach(Console.WriteLine);

            Console.WriteLine("\nTop 5 Longest Words:");
            words.Sort( (x,y) =>
            {
                if (x.Length < y.Length)
                {
                    return 1;
                }
                if (x.Length > y.Length)
                {
                    return -1;
                }
                return 0;
                //Descending Order
            });

            int num = 1; //Can pass non-constant variables in Lambda Expressions
            words.ForEach( s =>
            {
                if (num <= 5)
                {
                    Console.WriteLine($"{num++}: {s}");
                }
                //Stops consoling when num > 5
            });
        }
    }
}