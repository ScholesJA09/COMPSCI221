using System.Net.Http.Headers;
using System.Xml;

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

            //Can also do List<int> numbers = [1, 2, 3];

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
            // The HashSet<T> class represents a set of unique elements
            // It is a generic class, so you must specify the type of the elements(T)
            // Items will be stored in an unspecified order
            // A set cannot contain duplicate elements

            //Creating HashSet
            HashSet<string> names = ["David", "Stephen", "Graham"];
            //Not in order you declared 

            //Adding value to names
            names.Add("Neil");

            //Enumerator over HashSet to print
            IEnumerator<string> enumerator = names.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Write(enumerator.Current + " ");
            }
            Console.WriteLine();

            foreach (string n in names) //Same as IEnumerator
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            Console.WriteLine(string.Join(" ", names)); //This too

            names.Add("David");
            //Cannot add duplicate values

            //Checking if certain value is in Hashset
            if (names.Contains("Neil"))
            {
                Console.WriteLine("Yes, this set contains that value.");
            }
            else
            {
                Console.WriteLine("No, this set does not contain that value.");
            }

            //Removing a value from a HashSet
            names.Remove("Neil");
            Console.WriteLine(string.Join(" ", names));
        }
        
        static void MapDemo()
        {
            // The Dictionary<TKey, TValue> class represents a collection of key / value pairs
            // It is a generic class, so you must specify the type of the key (TKey) and the type of the value(TValue)
            // The key is used to uniquely identify the value
            // The key must be unique, but the value does not have to be unique
            // This data structure is also known as a map or an associative array

            //Creating Dictionary
            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                {9876, "David"},
                {5000, "Stephen"},
                {1234, "Graham"}
            };

            //Adding value to Dictionary
            names.Add(7654, "Neil");

            //Printing out Dictionary
            IEnumerator<KeyValuePair<int, string>> enumerator = names.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Write(enumerator.Current + " ");
            }
            Console.WriteLine();

            foreach (KeyValuePair<int, string> n in names)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            Console.WriteLine(string.Join(" ", names));

            //names.Add(7654, "Kevin");
            //Cannot add duplicate key. throws exception

            names[5000] = "Roger";
            //Not index 5000, key 5000, either will put in a new pair or update original
            Console.WriteLine(string.Join(" ", names));

            //Removing value from Dictionary, only care about key value
            names.Remove(9876);
            Console.WriteLine(string.Join(" ", names));

            //Get value with key
            if (names.TryGetValue(1234, out string value))
            {
                Console.WriteLine($"Yes, found value: {value}.");
            }
        }

        static void Main()
        {
            ListDemo();
            Console.WriteLine();
            SetDemo();
            Console.WriteLine();
            MapDemo();
        }
    }
}
