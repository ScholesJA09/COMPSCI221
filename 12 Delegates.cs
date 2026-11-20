namespace COMPSCI221 
{
	public static class _12_Delegates 
	{
		private static void HelloWorld() {
			Console.WriteLine("Hello World!");
		}

		private static int Square(int x) {
			return x * x;
		}

		private static bool IsEven(int x) {
			return x % 2 == 0;
		}

		private static bool IsPrime(int x) {
			if (x <= 1) {
				return false;
			}

			if (x == 2) {
				return true;
			}

			if (x % 2 == 0) {
				return false;
			}

			for (int i = 3; i * i <= x; i += 2) {
				if (x % i == 0) {
					return false;
				}
			}

			return true;
		}

        private static void Main()
		{
			//The job of delegate classes is to encapsulate a method and call it later

			//Action is a delegate that takes no arguments and returns void
			Action a1 = HelloWorld;

			// Invoke is a method of the Action class
			// It calls the method encapsulated by the Action object
			a1.Invoke();

			//There is an Action<T> delegate that takes a single argument of type T
			//There are Action<T1, T2>, Action<T1, T2, T3>, etc. up to 16 arguments
			Action<string> a2 = Console.WriteLine;

            // We can now call the Console.WriteLine method via the Action<string> object
            // The Invoke() method takes one string argument- as expected be the Action<string> object
            a2.Invoke("Delegates are cool!");

			// Func is a delegate that takes arguments and returns a value
			//<parameter type, return type>
			Func<int, int> f1 = Square;
			Console.WriteLine(f1.Invoke(4));

			Func<int, bool> f2 = IsEven;
			Console.WriteLine(f2.Invoke(4));

			f2 = IsPrime;
			Console.WriteLine(f2.Invoke(11));

			// Specifically, we use a Predicate<T> to determine whether or not a T matches some criteria we define
			Predicate<int> p = IsEven;
			p = IsPrime;

			//Creating a List of 100 ints
			List<int> nums = new List<int>(100);
            for (int i = 0; i < 100; i++)
            {
                nums.Add(i);
            }

			//Using methods via Predicate
			PrintIf(nums, IsEven);
			PrintIf(nums, IsPrime);
        }

        // The method prints all elements of the collection that match the criteria defined by the Predicate<T>
        private static void PrintIf<T>(IEnumerable<T> values, Predicate<T> predicate)
		{
			foreach (T x in values) 
			{
				if (predicate.Invoke(x)) {
					Console.WriteLine(x);
				}
			}
		}
	}
}