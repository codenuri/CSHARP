using System;

class Point
{
    private int xPos = 0;
    private int yPos = 0;

    public Point(int x, int y) { xPos = x; yPos = y; }

    public override string ToString()
    {
        return string.Format($"{xPos}, {yPos}");
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 1);
        Point p2 = new Point(2, 2);

        Console.WriteLine( p1.ToString() );
        Console.WriteLine( p2.ToString() );
    }
}
