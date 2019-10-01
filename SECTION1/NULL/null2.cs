using System;

class Program
{
    public static void Main()
    {
        int? n1 = null;// 10;
        int  a1 = 20;

        //n1 = a1; // int? = int   ok 
        //a1 = n1; // int = int?   error

        //a1 = (int)n1; // int = int?   

        Console.WriteLine(a1);

        int? n2 = null;// 10;
        int? n3 = 20;
        int? n4 = n2 + n3;

        Console.WriteLine(n4==null);
        Console.WriteLine(n4);

    }
}