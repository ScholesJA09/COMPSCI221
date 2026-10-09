public static class PA3 {
	private static int Range(int[] array) {
		//throw new NotImplementedException(nameof(Range) + " not implemented");

		if (array.Length == 0)
		{
			return 0;
		}

		int minIndex = 0;
		int maxIndex = 0;

		for(int i = 1; i < array.Length; i++)
		{
			if (array[i] < array[minIndex])
			{
				minIndex = i;
			}
			else if (array[i] > array[maxIndex])
			{
				maxIndex = i;
			}
		}

		return array[maxIndex] - array[minIndex];
	}

	private static int Frequency(int[] array, int key) {
		//throw new NotImplementedException(nameof(Frequency) + " not implemented");

		int count = 0;

		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == key)
			{
				count++;
			}
		}

		return count;
	}

	private static bool IsSorted(int[] array) {
		//throw new NotImplementedException(nameof(IsSorted) + " not implemented");

		for (int i = 1; i < array.Length; i++)
		{
			if (array[i] < array[i - 1])
			{
				return false;
			}
		}

		return true;
	}

	private static void Reverse(int[] array) {
		//throw new NotImplementedException(nameof(Reverse) + " not implemented");

		for (int i = 0; i < array.Length / 2; i++)
		{
			(array[i], array[array.Length - (1 + i)]) = (array[array.Length - (1 + i)], array[i]);
		}
	}

	private static void RotateRight(int[] array) {
		//throw new NotImplementedException(nameof(RotateRight) + " not implemented");
		if (array.Length > 0)
		{
            int furthestRight = array[array.Length - 1];

            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = furthestRight;
        }
	}

	private static void GnomeSort(int[] array) {
		//throw new NotImplementedException(nameof(GnomeSort) + " not implemented");

		int i = 0;

		while (i < array.Length)
		{
			if (i == 0 || array[i] >= array[i - 1])
			{
				i++;
			}
			else
			{
				(array[i], array[i - 1]) = (array[i - 1], array[i]);
				i--;
			}
				
		}
	}

	private static int[] Merge(int[] a, int[] b) {
		//throw new NotImplementedException(nameof(Merge) + " not implemented");

		int[] array = new int[a.Length + b.Length];
		int count = 0;

		for (int i = 0; i < a.Length; i++)
		{
			array[i] = a[i];
			count++;
		}

		for (int i = 0; i < b.Length; i++)
		{
			array[i + count] = b[i];
		}

		return array;
	}

	private static bool HasSubsequence(int[] array, int[] sequence) {
		//throw new NotImplementedException(nameof(HasSubsequence) + " not implemented");
		
		bool found = false;

		if (sequence.Length == 0)
		{
			return true;
		}

		for (int i = 0; i < array.Length - sequence.Length + 1; i++)
		{
			found = true;
			for (int j = 0; j < sequence.Length; j++)
			{
				if (array[i + j] != sequence[j])
				{
					found = false;
					break;
				}
			}

			if (found)
			{
				return true;
			}
		}
		return false;
	}

	#region DO NOT MODIFY
	private static void Main() {
		Console.WriteLine("Range Tests:");
		Console.WriteLine(Range([1, 2, 3, 4, 5]) == 4);
		Console.WriteLine(Range([1, 1, 1, 1, 1, 1, 1]) == 0);
		Console.WriteLine(Range([-10, 0, 10, 20, 30]) == 40);
		Console.WriteLine(Range([5]) == 0);
		Console.WriteLine(Range([8, 6, 4, 2, 0, 7, 3, 5, 1]) == 8);

		Console.WriteLine("\nFrequency Tests:");
		Console.WriteLine(Frequency([1, 2, 3], 2) == 1);
		Console.WriteLine(Frequency([1, 2, 2, 3, 3, 3], 2) == 2);
		Console.WriteLine(Frequency([4, 8, 12, 16], 5) == 0);
		Console.WriteLine(Frequency([4], -4) == 0);
		Console.WriteLine(Frequency([7, 7, 7, 7], 7) == 4);

		Console.WriteLine("\nIs Sorted Tests:");
		Console.WriteLine(IsSorted([1, 2, 3, 4, 5]) == true);
		Console.WriteLine(IsSorted([5, 4, 3, 2, 1]) == false);
		Console.WriteLine(IsSorted([1, 1, 1, 1]) == true);
		Console.WriteLine(IsSorted([8]) == true);
		Console.WriteLine(IsSorted([1, 3, 2, 4, 5]) == false);

		Console.WriteLine("\nReverse Tests:");
		int[] arr1 = [1, 2, 3, 4, 5];
		Reverse(arr1);
		Console.WriteLine(Enumerable.SequenceEqual(arr1, [5, 4, 3, 2, 1]));
		int[] arr2 = [1, 2, 3, 4];
		Reverse(arr2);
		Console.WriteLine(Enumerable.SequenceEqual(arr2, [4, 3, 2, 1]));
		int[] arr3 = [1];
		Reverse(arr3);
		Console.WriteLine(Enumerable.SequenceEqual(arr3, [1]));
		int[] arr4 = [];
		Reverse(arr4);
		Console.WriteLine(Enumerable.SequenceEqual(arr4, []));
		int[] arr5 = [1, 2];
		Reverse(arr5);
		Console.WriteLine(Enumerable.SequenceEqual(arr5, [2, 1]));

		Console.WriteLine("\nRotate Right Tests:");
		int[] arr6 = [1, 2, 3, 4, 5];
		RotateRight(arr6);
		Console.WriteLine(Enumerable.SequenceEqual(arr6, [5, 1, 2, 3, 4]));
		int[] arr7 = [1, 2, 3, 4];
		RotateRight(arr7);
		Console.WriteLine(Enumerable.SequenceEqual(arr7, [4, 1, 2, 3]));
		int[] arr8 = [1];
		RotateRight(arr8);
		Console.WriteLine(Enumerable.SequenceEqual(arr8, [1]));
		int[] arr9 = [1, 2, 2, 3, 3, 3];
		RotateRight(arr9);
		Console.WriteLine(Enumerable.SequenceEqual(arr9, [3, 1, 2, 2, 3, 3]));
		int[] arr10 = [];
		RotateRight(arr10);
		Console.WriteLine(Enumerable.SequenceEqual(arr10, []));

		Console.WriteLine("\nGnome Sort Tests:");
		int[] arr11 = [5, 3, 2, 4, 1];
		GnomeSort(arr11);
		Console.WriteLine(Enumerable.SequenceEqual(arr11, [1, 2, 3, 4, 5]));
		int[] arr12 = [1, 2, 3, 4, 5];
		GnomeSort(arr12);
		Console.WriteLine(Enumerable.SequenceEqual(arr12, [1, 2, 3, 4, 5]));
		int[] arr13 = [3, 3, 2, 1, 2];
		GnomeSort(arr13);
		Console.WriteLine(Enumerable.SequenceEqual(arr13, [1, 2, 2, 3, 3]));
		int[] arr14 = [1];
		GnomeSort(arr14);
		Console.WriteLine(Enumerable.SequenceEqual(arr14, [1]));
		int[] arr15 = [];
		GnomeSort(arr15);
		Console.WriteLine(Enumerable.SequenceEqual(arr15, []));

		Console.WriteLine("\nMerge Tests:");
		int[] merged1 = Merge([1, 3, 5], [2, 4, 6]);
		Console.WriteLine(Enumerable.SequenceEqual(merged1, [1, 3, 5, 2, 4, 6]));
		int[] merged2 = Merge([1, 2, 3], [4, 5, 6, 7, 8]);
		Console.WriteLine(Enumerable.SequenceEqual(merged2, [1, 2, 3, 4, 5, 6, 7, 8]));
		int[] merged3 = Merge([], [1, 2, 3]);
		Console.WriteLine(Enumerable.SequenceEqual(merged3, [1, 2, 3]));
		int[] merged4 = Merge([1, 2, 3], []);
		Console.WriteLine(Enumerable.SequenceEqual(merged4, [1, 2, 3]));
		int[] merged5 = Merge([], [1, 2, 3, 4, 5]);
		Console.WriteLine(Enumerable.SequenceEqual(merged5, [1, 2, 3, 4, 5]));

		Console.WriteLine("\nHas Subsequence Tests:");
		Console.WriteLine(HasSubsequence([1, 2, 3, 4, 5], [2, 3]) == true);
		Console.WriteLine(HasSubsequence([1, 2, 3, 4, 5], [3, 5]) == false);
		Console.WriteLine(HasSubsequence([1, 2, 3, 4, 5], [3]) == true);
		Console.WriteLine(HasSubsequence([1, 2, 3, 4, 5], [6]) == false);
		Console.WriteLine(HasSubsequence([1, 2, 3, 4, 5], [1, 2, 3, 4, 5]) == true);
	}
	#endregion
}