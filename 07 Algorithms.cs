namespace COMPSCI221
{
    static class _07_Algorithms
    {
        static int IndexOf(double[] array, double key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }
        //Best Case: Order of 1
        //Worst Case: Order of n

        static bool Contains(double[] array, double key)
        {
            return IndexOf(array, key) != -1; //Returns true if index != -1
        }

        static int MinIndex(double[] array)
        {
            if (array.Length == 0)
            {
                return -1;
            }

            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }
        //Best Case: Order of n
        //Worst Case: Order of n

        static int MaxIndex(double[] array)
        {
            if (array.Length == 0)
            {
                return -1;
            }

            int maxIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        static void SelectionSort(double[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (i != minIndex)
                {
                    //double temp = array[i];
                    //array[i] = array[minIndex];
                    //array[minIndex] = temp;

                    (array[i], array[minIndex]) = (array[minIndex], array[i]);
                    //Tuffle Swap - Same as code above
                }
            }
        }
        //Base Case: Order of 0 swaps
        //Worst Case: Order of n swaps
        //Base Case: Order of n^2 time
        //Worst Case: Order of n^2 time

        static void InsertionSort(double[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                double temp = array[i];
                
                while (j > 0 && temp < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }

                array[j] = temp;
            }
        }
        //Best Case: Order of 0 swaps
        //Worst Case: Order of n^2 swaps
        //Base Case: Order of n time
        //Worst Case: Order of n^2 time

        static void Main()
        {
            double[] nums = [7.6, 9.5, 6.2, 3.6, 2.8, 5.4, 1.2, 8.9, 8.3, 5.6];
            Console.Write("Array: ");
            Console.WriteLine(string.Join(", ", nums));
            Console.WriteLine();

            InsertionSort(nums);
            Console.WriteLine(string.Join(", ", nums));

        }
    }
}
