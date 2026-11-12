namespace COMPSCI221
{
    static class LE10
    {
        static void Main()
        {
            Stack<string> s1 = new Stack<string>(4);
            s1.Push("C++");
            s1.Push("Python");
            s1.Push("Java");
            Console.WriteLine(s1.Pop());
            s1.Push("C#");
            Console.WriteLine(s1.Peek());
            s1.Push("PHP");
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());

            Stack<char> s2 = new Stack<char>(8);
            s2.Push('P');
            s2.Push('R');
            s2.Push('A');
            s2.Push('H');
            s2.Push('S');
            s2.Push('C');

            while (s2.Size != 0)
            {
                Console.WriteLine(s2.Pop());
            }

            Stack<int> s3 = new Stack<int>(20);
            s3.Push(1);
            s3.Push(7);
            s3.Push(2);
            s3.Push(2);
            s3.Push(2);
            s3.Push(1);

            int sum = 0;
            double average = 0;
            int count = 0;

            while (s3.topOfStack != -1)
            {
                int value = s3.Pop();
                sum += value;
                count++;
            }

            average = sum / count;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
        }
    }
}