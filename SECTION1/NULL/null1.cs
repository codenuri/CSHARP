using System;

class Program
{
    //public static int foo()
    public static Nullable<int> foo()
    {
        if (실패)
            return null;
        return 100;
    }
    public static void Main()
    {
        // string : reference type
        string s1 = "Hello";
        string s2 = null;  // 객체 없음.

        // int : value type
        //int n1 = 10;
        //int n2 = ?;  // 값없음을 나타내고 싶다.

        Nullable<int> n1 = 10;
        Nullable<int> n2 = null;

        if (n2 == null) { }

        int? n3 = null; // Nullable<int> n3 = null;
    }
}