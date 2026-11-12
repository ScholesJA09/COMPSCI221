namespace COMPSCI221
{
    static class _11_Collections
    {
        static void ListDemo()
        {
            List<int> numbers = new List<int>(); //Generic List Class with default constructor
            //Can add int in () to start a capacity

            numbers.Add(1); //Adds object to the end of the list
            numbers.Add(2);
            numbers.Add(3);

            //*Can also do List<int> numbers = [1, 2, 3];*

            for (int i = 0; i < numbers.Count; i++) //.Count - List Property, how many elements in List
            {
                Console.Write(numbers[i] + " "); //Listing out each element in List
            }
            Console.WriteLine();

            IEnumerator<int> enumerator = numbers.GetEnumerator(); //Same as above
            while (enumerator.MoveNext()) //Returns true if it can move to next element
            {
                Console.Write(enumerator.Current + " ");
            }
            Console.WriteLine();

            foreach (int n in numbers) //Literally the same as IEnumerable (DO THIS)
            {
                Console.Write(n + " "); //Dont care for the index
            }
            Console.WriteLine();

            Console.WriteLine(string.Join(" ", numbers)); //Printing out List with string.Join()

            numbers.RemoveAt(0); //Removes specific index, so 1 is no longer in List
            numbers.Remove(2); //Specifically remove instance of a value, so 2 is no longer in List
        }

        static void SetDemo()
        {

        }
        
        static void MapDemo()
        {

        }

        static void Main()
        {
            ListDemo();
        }
    }
}
