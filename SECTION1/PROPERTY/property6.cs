using System;

class Point
{
    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;
}

class Program
{
    static void Main()
    {
        Point p1 = new Point();
        Point p2 = new Point() { X = 10, Y = 20 };
        Point p3 = new Point   { X = 10, Y = 20 };
        Point p4 = new Point { Y = 20 };


        // 무명 타입
        var p = new { Name = "kim", Age = 20 };

        Console.WriteLine(p.Name); // "kim"
        //p.Name = "lee"; // error

        Type t = p.GetType();
        Console.WriteLine(t.FullName);

    }
}






