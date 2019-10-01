using System;

struct Point
{
    public int x;
    public int y;
    public Point(int xPos, int yPos)
    {
        x = xPos;
        y = yPos;
    }

    public override bool Equals(object obj)
    {
        Point pt = (Point)obj;
        return x == pt.x;
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point(1, 1);
        Point p2 = p1;
        p2.y = 2;

        // 방법 1. == 연산자 사용
        // 기본적으로 제공 안됨. - 연산자 재정의 제공가능
        //Console.WriteLine(p1 == p2); 

        // 방법 2. Equals() 가상함수 사용
        // 
        Console.WriteLine(p1.Equals(p2)); // true
    }
}




