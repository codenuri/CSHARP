using System;
using System.Collections.Generic;

class Point<T>
{
    private T x;
    private T y;

    // C++ : T a = T()
    public Point( T xPos = default(T), T yPos = default(T))
    {
        x = xPos;
        y = yPos;
    }
}
class Program
{
    static void Main()
    {
        Point<int> pt = new Point<int>(1, 1);
        Point<double> pt2 = new Point<double>(1.1, 1.1);

        LinkedList<int> s = new LinkedList<int>();
    }
}
