namespace COMPSCI221
{
    static class _04_Semantics
    {
        static void Main()
        {
            int a = 4; //Value Semantics
            int b = a; //Make a copy
            Console.WriteLine($"a = {a}, b = {b}");
            b = 5; //Does not modify the original
            Console.WriteLine($"a = {a}, b = {b}");

            Wrapper w1 = new Wrapper(4); //Classes use Reference Semantics
            Wrapper w2 = w1; //w2 points to same location as w1, both are a reference to where the object of x=4 is
            Console.WriteLine($"w1.X = {w1.X}, w2.X = {w2.X}");
            w2.X = 5; //Any changes to actual value will affect both
            Console.WriteLine($"w1.X = {w1.X}, w2.X = {w2.X}");

            int x = 44;
            Console.WriteLine($"\nBefore Value Semantics, x = {x}");
            ValueSemantics(x); 
            Console.WriteLine($"After Value Semantics, x = {x}");

            Wrapper w3 = new Wrapper(44);
            Console.WriteLine($"\nBefore Reference Semantics, x = {w3.X}");
            ReferenceSemantics(w3);
            Console.WriteLine($"After Reference Semantics, x = {w3.X}");

            Wrapper w4 = new Wrapper(44);
            Console.WriteLine($"\nBefore Pass By Value, x = {w4.X}");
            PassByValue(w4);
            Console.WriteLine($"After Pass By Value, x = {w4.X}");

            Wrapper w5 = new Wrapper(44);
            Console.WriteLine($"\nBefore Pass By Reference, x = {w5.X}");
            PassByReference(ref w5);
            Console.WriteLine($"After Pass By Reference, x = {w5.X}");

            int y = 44;
            Console.WriteLine($"\nBefore Pass By Reference, x = {y}");
            PassByReference(ref y);
            Console.WriteLine($"After Pass By Reference, x = {y}");

            Point p1 = new Point(3, 4);
            Console.WriteLine($"\nPoint p1 : ({p1.X}, {p1.Y})");

            Point p2 = p1;
            Console.WriteLine($"Point p2 : ({p2.X}, {p2.Y})");

            p2.X = 5; //p1 remains uncahnged
            Console.WriteLine($"Point p1 : ({p1.X}, {p1.Y})");
            Console.WriteLine($"Point p2 : ({p2.X}, {p2.Y})");
        }

        static void ValueSemantics(int x)
        {
            Console.WriteLine($"Inside of Value Semantics, x = {x}");
            x = 99; //Changes inside that function are local to that function
            Console.WriteLine($"Inside of Value Semantics, x = {x}");
        }

        static void ReferenceSemantics(Wrapper w)
        {
            Console.WriteLine($"Inside of Reference Semantics, x = {w.X}");
            w.X = 99; //Since we are passing a copy of the memory address, changes made in this function will affect the original
            Console.WriteLine($"Inside of Reference Semantics, x = {w.X}");
        }

        static void PassByValue(Wrapper w)
        {
            Console.WriteLine($"Inside Pass By Value, x = {w.X}");
            w = new Wrapper(99); //w now points to x = 99, but w4 still points to the original x = 44
            Console.WriteLine($"Inside Pass By Value, x = {w.X}");
        }

        static void PassByReference(ref Wrapper w) //Passing a copy of a memory address of a memory address
        {
            Console.WriteLine($"Inside of Pass By Reference, x = {w.X}");
            w = new Wrapper(99); //Overidden memory address of a memory address with a new memory address
            Console.WriteLine($"Inside of Pass By Reference, x = {w.X}");
        }

        static void PassByReference(ref int x) //ref = pass address of
        {
            Console.WriteLine($"Inside of Pass By Reference, x = {x}");
            x = 99;
            Console.WriteLine($"Inside of Pass By Reference, x = {x}");
        }

        class Wrapper
        {
            public Wrapper(int x)
            {
                X = x;
            }
            public int X { get; set; }
        }

        struct Point //Uses Value Semantics, Use when values aren't modifiable often
        {
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; set; }
            public int Y { get; set; }
        }

        readonly struct ReadOnlyPoint
        { 
            public ReadOnlyPoint(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; } //No set accessors, incapable of modification
            public int Y { get; }
        }
    }
}