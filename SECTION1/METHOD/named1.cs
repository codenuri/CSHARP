using System;

class Program
{
    public static void Main()
    {
        SetRect(10, 20, 30, 40);

        SetRect(x: 10, y: 20, width: 30, height: 40);
        SetRect(y: 20, x: 10, width: 30, height: 40);
        SetRect(10, 20, width: 30, height: 40);

    }

    public static void SetRect(int x,     int y, 
                               int width, int height)
    {
        Console.WriteLine($"{x}, {y}, {width}, {height}");
    }
}