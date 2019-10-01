using System;

//void foo(IComparable c) { }
/*
// 비교 하는 메소드의 이름을 약속하자.
interface IComparable
{
    int CompareTo(object other);
}
*/
// 모든 비교 가능한 객체는 IComparable 인터페이스를 구현
// 해야 한다.
class Point  : IComparable
{
    private int x;
    private int y;
    public Point(int xPos, int yPos)
    {
        x = xPos;
        y = yPos;
    }  
    public int CompareTo(object other)
    {
        Point pt = other as Point;

        if (x > pt.x) return 1;
        else if (x == pt.x) return 0;
        return -1;
    }
}
class Program
{
    static void Main()
    {
        Point p1 = new Point(1, 1);
        Point p2 = new Point(2, 2);

        Console.WriteLine(p1.CompareTo(p2));
    }
}

