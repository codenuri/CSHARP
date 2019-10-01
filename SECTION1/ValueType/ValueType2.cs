using System;

class Program
{
    public static void Main()
    {
        // int n = new int();

        // 1. int
        int n1 = 1;
        int n2 = n1;

        n2 = 10;
        Console.WriteLine(n1); // 1




        // 2. array
        //System.Array a;
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = arr1;

        arr2[0] = 10;

        Console.WriteLine(arr1[0]); // 10






        // 3. string
        string s1 = "Hello";
        string s2 = s1;

        Console.WriteLine(s1 == s2); // true

        s2 = "world"; // s2 = new string("world")

        Console.WriteLine(s1 == s2); // false
        Console.WriteLine(s1);// "world"
    }
}


