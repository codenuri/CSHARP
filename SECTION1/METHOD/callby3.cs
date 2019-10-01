using System;

class Program
{
    //메소드로 부터 2개의 결과 값을 반환 받고 싶다.
    public static int prev_next_number1(int n, ref int r)
    {
        int a = r; // ok
        r = n + 1;
        return n - 1;
    }

    public static int prev_next_number2(int n, out int r)
    {
        int a = r; // error
        r = n + 1;
        return n - 1;
    }

    public static void Main()
    {
        int n1 = 10;
        int result2;// = 0;

        //int result1 = prev_next_number1(n1, ref result2);
        int result1 = prev_next_number2(n1, out result2);

        Console.WriteLine($"{result1}, {result2}");

    }
}