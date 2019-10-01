using System;

class Point
{
    private int x;
    private int y;
    public Point(int xPos, int yPos)
    {
        x = xPos;
        y = yPos;
    }
    public override string ToString()
    {
        return string.Format($"{x}, {y}");
    }

    public static explicit operator int(Point pt)
    {
        return pt.x;
    }
    public static explicit operator Point(int n)
    {
        return new Point(n, n);
    }
}

class Program
{
    static void Main()
    {
        double d = 3.4;
        //int n1 = d; // error        
        int n1 = (int)d; // ok


        Point pt = new Point(1, 2);

        //int n2 = pt; // Point => int
        int n2 = (int)pt; // Point => int.. ok
        Console.WriteLine(n2);

        //---------------------
        Point pt2 = (Point)n2; // int => Point
        Console.WriteLine(pt2); // pt2.ToString()


       // Point pt2 = n2 as Point; // error

    }
}






