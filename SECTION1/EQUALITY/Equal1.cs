using System;

class Point
{
    private int x = 0;
    private int y = 0;
    public Point(int xPos, int yPos)
    {
        x = xPos;
        y = yPos;
    }

    public override bool Equals(object obj)
    {
        Point pt = (Point)obj; // as 

        return x == pt.x && y == pt.y;
    }

    // == 연산자 재정의 
    public static bool operator ==(Point p1, Point p2)
    {
        return p1.x == p2.x && p1.y == p2.y;
    }
    public static bool operator !=(Point p1, Point p2)
    {
        return p1.x != p2.x || p1.y != p2.y;
    }
}

class Program
{
    static void Main()
    {
        //Point p1 = new Point(1, 1);
        //Point p2 = p1;
        //Point p3 = new Point(1, 1);

        object p1 = new Point(1, 1);
        object p2 = p1;
        object p3 = new Point(1, 1);

        // 방법 1. == 연산자 사용
        // 기본 동작 : 참조(주소)가 동일한가 ?
        Console.WriteLine(p1 == p2); // true
        Console.WriteLine(p1 == p3); // false


        // 방법 2. Equals() 가상함수 사용
        // 기본 동작 : 참조가 동일 한가 ?
        Console.WriteLine(p1.Equals(p2)); // true
        Console.WriteLine(p1.Equals(p3)); // true
    }
}




