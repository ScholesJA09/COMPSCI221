namespace COMPSCI221
{
    internal class LE6
    {
        static void Main()
        {
            //Task 2/4
            Item[] items = [
                new Television(1097.99, "Q60B", "Samsung", 75),
                new Television(179.99, "F20", "Insignia", 32),
                new Television(14997.99, "QN90A", "Samsung", 98),
                new Desktop(2229.39, "Z2G4", "HP", 1024),
                new Desktop(699.99, "Inspiron 3910", "Dell", 256),
                new Desktop(204.62, "M92p", "Lenovo", 3072),
                new Laptop(1093.60, "Elitebook 850 G8", "HP", 512, 4),
                new Laptop(1879.00, "XPS 17", "Dell", 1024, 10),
                new Laptop(169.99, "A4-9120e", "Gateway", 64, 8)
                ];

            //Task 3/4
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }

            //Task 4/4
            Console.WriteLine("\nALL COMPUTERS ARE ON SALE THIS WEEKEND! 25% OFF!\n");

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] is Computer c)
                {
                    items[i].Price = (items[i].Price * .75);
                }
            }

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

    }
}
