using System;

struct SPoint
{
    public int x;
    public int y;
    public SPoint(int xPos, int yPos) 
    { 
        x = xPos; 
        y = yPos; 
    }
}
class CPoint
{
    public int x;
    public int y;
    public CPoint(int xPos, int yPos) 
    { 
        x = xPos; 
        y = yPos; 
    }
}

class Program
{
    public static void Main()
    {
        SPoint sp1 = new SPoint(1, 1);
        CPoint cp1 = new CPoint(1, 2);

        SPoint sp2 = sp1; // 객체 2개. 객체 자체를 복사
        CPoint cp2 = cp1; // 참조(주소)복사, 객체 한개

        sp2.x = 10;
        Console.WriteLine(sp1.x); // 1

        cp2.x = 10;
        Console.WriteLine(cp1.x); // 10
    }
}


