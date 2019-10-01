using System;

class Program
{
    /*
    public static int Max(int a, int b)
    {
        return a.CompareTo(b) < 0 ? b : a;
    }
    public static string Max(string a, string b)
    {
        return a.CompareTo(b) < 0 ? b : a;
    }
    */


    // 1. object
    /*
    public static object Max(object a, object b)
    {
        IComparable c1 = a as IComparable;
        IComparable c2 = b as IComparable;

        return c1.CompareTo(c2) < 0 ? b : a;
    }
    */

    // 2. IComparable
    // 모든 인터페이스 : reference type
    /*
    public static object Max(IComparable a, IComparable b)
    {
        return a.CompareTo(b) < 0 ? b : a;
    }
    */
    // 3. generic
    // C++20 : concept
    public static T Max<T>(T a, T b) where T : IComparable, new()
    {
        // 기본적으로 object로 할수 있는 연산만 가능
        // a.Equals(b); // ok.. object 멤버
        return a.CompareTo(b) < 0 ? b : a;
    }


    static void Main()
    {
        Console.WriteLine(Max(10, 20));
        Console.WriteLine(Max("A", "B"));
     //   Console.WriteLine(Max(new Car(), new Car()));

        int n = Max(10, 20);
    }
}

class Car { }


