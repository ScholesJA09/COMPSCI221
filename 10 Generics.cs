namespace COMPSCI221
{
    static class _10_Generics
    {
        private static void Print<T>(T[] array) //Generic Method - Declaring an identifier T
        {
            Console.Write("[ ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("]");
        }

        public class Container<T> //Generic class
        { 
            public T Value { get; set; }
        }

        public class Barn<TAnimal> : Container<TAnimal> where TAnimal : IAnimal //Generic class with restrictions
        {
            public void Visit()
            {
                Console.WriteLine($"Hello, {Value.Name}"); //TAnimal must have what IAnimal has
                Value.Speak();
            }
        }

        static void Main()
        {
            int[] a1 = [1, 2, 3, 4, 5];
            double[] a2 = [1.1, 2.2, 3.3, 4.4, 5.5];
            string[] a3 = ["one", "two", "three", "four", "five"];

            Print<int>(a1); //option to inference by context
            Print(a2);
            Print(a3);

            Container<int> c1 = new Container<int>(); //Generic type is int
            c1.Value = 1;

            Container<double> c2 = new Container<double>(); //Generic type is double
            c2.Value = 1.1;

            Container<string> c3 = new Container<string>(); //Generic type is string
            c3.Value = "one";
        }
    }
}