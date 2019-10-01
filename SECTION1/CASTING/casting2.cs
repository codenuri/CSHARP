using System;

class Animal { }
class Dog : Animal
{
    public void Cry() { Console.WriteLine("Dog Cry"); }
}

class Program
{
    public static void foo(Animal a)
    {
        //a.Cry();

        // Animal 참조 타입을 Dog 참조타입으로 캐스팅
        //Dog d = (Dog)a; 
        //d.Cry();

        /*
        if ( a is Dog )
        {
            Console.WriteLine("Dog 맞음");
            Dog d = (Dog)a;
            d.Cry();
        }
        */

        //Dog d = (Dog)a; // 실패시 예외
        Dog d = a as Dog; // 실패시 null 반환

        if ( d == null)
        {
            Console.WriteLine("null");
        }


    }
    static void Main()
    {
        //foo(new Dog());
        foo(new Animal());

        int n = 3;
        object obj = n;

        //int n1 = obj as int; // error

        int? n1 = obj as int?; // ok
        Console.WriteLine(n1);
    }
}

