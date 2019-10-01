using System;

// CompareTo : IComparable, IComparable<T>
// Equals    : object, IEquatable<T>
/*
interface IEquatable<T>
{
    bool Equals(T other)
}
*/

struct Point : IEquatable<Point>
{
    private int x;
    private int y;
    public Point(int xPos, int yPos)
    {
        x = xPos;
        y = yPos;
    }
    public bool Equals(Point pt)
    {
        Console.WriteLine("Point");
        return x == pt.x && y == pt.y;
    }
    public override bool Equals(object obj)
    {
        Console.WriteLine("object");
        Point pt = (Point)obj;
        return x == pt.x && y == pt.y;
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point(1, 1);
        object p2 = new Point(1, 1);

        Console.WriteLine(p1.Equals(p2));
    }
}

