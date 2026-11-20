public static partial class LE11 {
	private static void Task1(IEnumerable<Person> people) 
	{
        // 1.2: Create a collection which will be used to store the names of all people in their 20s
        List<string> names = new List<string>();

        // 1.3: Iterate through 'people' and add each person in their 20s' name to the collection
        // You can get a person's age by accessing the 'Age' property
        // They are in their twenties if their age is greater than or equal to 20 and less than 30
		foreach (Person p in people)
		{
			if (p.Age >= 20 && p.Age < 30)
			{
				names.Add(p.Name);
			}
		}

        // 1.4: Iterate over the collection you created in 1.2 and print each element
		foreach (string name in names)
		{
			Console.WriteLine(name);
		}

		Console.WriteLine();
    }

	private static void Task2(IEnumerable<Person> people) 
	{
		// 2.2: Create a collection which will be used to store the unique names of the people
		HashSet<string> names = new HashSet<string>();

		// 2.3: Iterate through 'people' and add each person's name to the collection
		foreach (Person p in people)
		{
			names.Add(p.Name);
		}

		// 2.4: Print the number of unique names in the collection
		Console.WriteLine(names.Count);

		// 2.4: Print each name in the collection
		foreach (string name in names)
		{
			Console.WriteLine(name);
		}

		Console.WriteLine();
	}

	private static void Task3(IEnumerable<Person> people) 
	{
		// 3.2: Create a collection which allows you to look up a person by their ID
		Dictionary<int, Person> names = new Dictionary<int, Person>();

		// 3.3: Iterate through 'people' and add each person to the collection
		// Each person has a unique ID which would be useful for looking them up
		foreach (Person p in people)
		{
			names.Add(p.Id, p);
		}

		// 3.4: Print the number of people in the collection
		Console.WriteLine(names.Count);

        // 3.5: Print the person with the ID 9676529 if they exist in the collection
        // If they do not exist, print "Person not found"
        if (names.TryGetValue(9676529, out Person value))
        {
			Console.WriteLine(value);
        }
		else
		{
			Console.WriteLine("Person not found");
		}

        // 3.6: Print the person with the ID 7879447 if they exist in the collection
        // If they do not exist, print "Person not found"
        if (names.TryGetValue(7879447, out Person value1))
        {
            Console.WriteLine(value1);
        }
        else
        {
            Console.WriteLine("Person not found");
        }

		// 3.7: Create a Person object which represents you. Use your own name, age, and student ID.
		// Add yourself to the collection from 3.2, overwriting anyone else who might share your ID.
		Person me = new Person("Jacob", 22, 2063728);
		names[me.Id] = me;

		// 3.8: Print every entry in the collection in the following format:
		// ID : Name
		foreach (KeyValuePair<int, Person> n in names)
		{
			Console.WriteLine($"{n.Key} : {n.Value.Name}");
		}
    }
}

#region DO NOT MODIFY
public static partial class LE11 {
	private static void Main() {
		Person[] people =  {
			new Person("Thomas", 29, 4424053),
			new Person("Doug", 28, 3566351),
			new Person("Emily", 21, 1414265),
			new Person("Brandon", 33, 3327914),
			new Person("Sydney", 25, 4662533),
			new Person("Katie", 34, 7597009),
			new Person("Sean", 18, 9768190),
			new Person("Allison", 45, 1904318),
			new Person("Patrick", 39, 4257062),
			new Person("Thomas", 65, 9676529),
			new Person("Dan", 47, 5796922),
			new Person("Cheryl", 68, 3602379),
			new Person("Diane", 59, 7879547),
			new Person("Sean", 29, 3126082),
			new Person("Emily", 21, 8625939),
			new Person("Steve", 72, 9896929),
			new Person("Roger", 80, 6166000),
			new Person("Thomas", 19, 5166720),
			new Person("Jack", 34, 8831654),
			new Person("Veronica", 27, 1169289),
		};

		Console.WriteLine("Names of Users in their 20s:");
		Task1(people);

		Console.WriteLine("Unique Names:");
		Task2(people);

		Console.WriteLine("Lookup Table:");
		Task3(people);
	}
}

public sealed class Person {
	private string name;
	private int age;
	private int id;

	public Person(string name, int age, int id) {
		Name = name;
		Age = age;
		Id = id;
	}

	public override string ToString() {
		return $"{Name} ({Age}) [{Id}]";
	}

	public string Name {
		get => name;
		set {
			if (string.IsNullOrWhiteSpace(value)) {
				throw new ArgumentNullException(nameof(Name));
			}

			name = value;
		}
	}

	public int Age {
		get => age;
		set {
			if (value < 0 || value > 120) {
				throw new ArgumentOutOfRangeException(nameof(Age));
			}

			age = value;
		}
	}

	public int Id {
		get => id;
		set {
			if (value < 1000000 || value > 9999999) {
				throw new ArgumentOutOfRangeException(nameof(Id));
			}

			id = value;
		}
	}
}
#endregion