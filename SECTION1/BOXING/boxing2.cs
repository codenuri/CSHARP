using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(10 < 20); // true
        
        Console.WriteLine(10.CompareTo(20)); // -1
        Console.WriteLine(10.CompareTo(10)); // 0
        Console.WriteLine(10.CompareTo(5));  // 1

        string s1 = "AAA";
        string s2 = "BBB";

        //Console.WriteLine(s1 < s2); // 
        Console.WriteLine(s1.CompareTo(s2)); // -1


    }
}
