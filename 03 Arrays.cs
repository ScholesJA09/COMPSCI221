namespace COMPSCI221
{
    static class _03_Arrays
    {
        static void Main()
        {
            int[] nums;
            nums = new int[4];

            nums[0] = 10;
            nums[1] = 5;
            nums[2] = 20;

            for(int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
                Console.Write(", ");
            }
            Console.WriteLine();

            Console.WriteLine(string.Join(", ", nums)); //Prints out list of array seperated by string

            double[] a = [1.0, 2.0, 3.0]; //Know what values are going to be in array
            double[] b = a; //Copying memory address of a into b
            b[0] = 4;

            Console.WriteLine($"a:  {string.Join(", ", a)}");
            Console.WriteLine($"b:  {string.Join(", ", b)}");
            //Both point to same memory address

            int[] c = [1, 2, 3];
            Console.WriteLine($"Before: {string.Join(", ", c)}");
            AddOne(c);
            Console.WriteLine($"After: {string.Join(", ", c)}");

            int[][] jagged = new int[3][]; //Two Dimensional Array
            jagged[0] = new int[3];
            jagged[1] = new int[10];
            jagged[2] = new int[5];

            int[,] rectangle = new int[2, 3]; //One Dimensional Array
            rectangle[1, 2] = 6;
        }

        private static void AddOne(int[] x) //Dont return an array if you are changing it
        {
            // x = [5, 6, 7, 8, 9]; - overwritten memory address of a COPY
            for (int i = 0; i < x.Length; i++)
            {
                x[i]++;
            }
        }
    }
}
