using System.Collections.Generic;

namespace COMPSCI221
{
    public class PA5
    {
        static void Main()
        {
            //1/5
            List<int> nums = [12, 12, 4, 5, 19, 19, 5, 0, 17, 17, 12, 14, 19, 2, 8, 10, 2, 10, 2, 7, 11, 14, 1, 4, 15, 16, 7, 10, 14, 5, 5, 4, 2, 11, 4, 14, 16, 7, 4, 19, 11, 5, 8, 6, 19, 14, 7, 6, 4, 16];

            Console.WriteLine("Number Sequence:");
            IEnumerator<int> enumerator = nums.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Write(enumerator.Current + ", ");
            }

            //2/5
            HashSet<int> nums2 = [];
            List<int> sortNums2 = [];

            Console.WriteLine("\n\nUnique Numbers:");
            IEnumerator<int> enumeratorToHash = nums.GetEnumerator();
            while (enumeratorToHash.MoveNext())
            {
                nums2.Add(enumeratorToHash.Current);
            }

            IEnumerator<int> enumeratorToSort = nums2.GetEnumerator();
            while (enumeratorToSort.MoveNext())
            {
                sortNums2.Add(enumeratorToSort.Current);
            }
            sortNums2.Sort();
  
            Console.Write(string.Join(", ", sortNums2));

            //3/5
            Dictionary<int, int> frequency = [];

            Console.WriteLine("\n\nNumber Frequency:");
            IEnumerator<int> enumeratorFrequency = nums.GetEnumerator();
            while (enumeratorFrequency.MoveNext())
            {
                int currentNum = enumeratorFrequency.Current;

                if (frequency.ContainsKey(currentNum))
                {
                    frequency[currentNum]++;
                }
                else
                {
                    frequency.Add(currentNum, 1);
                }
            }

            foreach (int numSort in sortNums2)
            {
                int count = frequency[numSort];

                if (count == 1)
                {
                    Console.WriteLine($"{numSort} appears {count} time");
                }
                else
                {
                    Console.WriteLine($"{numSort} appears {count} times");
                }
            }
            

            //4/5
            Console.WriteLine("\nReduced Number Sequence (original odd indices removed):");
            for (int i =nums.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    nums.RemoveAt(i);
                }
            }

            Console.Write(string.Join(", ", nums));

            //5/5
            Console.WriteLine("\n\nReduced Number Sequence (single digits only):");
            for (int i = nums.Count - 1; i >= 0; i--)
            {
                if (!(nums[i] > -10 && nums[i] < 10))
                {
                    nums.RemoveAt(i);
                }
            }

            Console.Write(string.Join(", ", nums));
        }
    }
}
