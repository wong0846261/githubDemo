using System;
class Program
{
    private static int count = 2;

    private static IEnumerable<int> NonRepeatable()
    {
        for (; count <= 4; count++)
        {
            yield return count;
        }
    }

    // function with integer return type declaration  
    public int square(int nmbr)
    {
        int sq = nmbr * nmbr;
        // Lets provide a return statement  
        return sq;
    }

    public int Max(int a, int b)
    {
        //return a > a ? a : b;
        return a > a ? a : b;
    }

    public static bool checkBoolean(bool a, bool b, bool c, bool d, bool e, bool f, bool g)
    {
        bool x = a || b || c || d || e || f || g; // OK
        bool y = a && b || !(b && c) || !(d && e) && !(f && g); // NOT OK
        bool z = (a && b || (b && c)) && ((d && e) || (f && g)); // NOT OK
        return x && y && z; // OK
    }
    public static void Main(string[] args)
    {
        Program pr = new Program(); // Creating a class Object  

        IEnumerable<int> nr = NonRepeatable();
        foreach (int i in nr) // Bad multiple iteration
            Console.WriteLine(i);

        foreach (int i in nr) // Bad multiple iteration
            Console.WriteLine(i);

        // int compareValue = pr.Max(3, 64); // Useless assignment to local variable

        int valueA = 83;
        int valueB = valueA;
        // int valueB = (int)valueA;
        // bool valueBoolean = checkBoolean(true, false, false, true, false, true, true); // Complex condition
        int rslt = pr.square(2); //Calling the method and assigning the value to an integer type
        Console.WriteLine("Square of the given number is  " + rslt + " boolean " + valueBoolean + " int " + valueB); //Printing the result
        // GC.Collect(); // Call to GC.Collect()
    }
}
