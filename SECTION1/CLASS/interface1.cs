using System;
using System.Collections;

/*
interface IList
{
    void Clear();
}
*/
// 모든 컬렉션은 반드시 IList 를 구현해야 한다.
class Stack : IList 
{
    public void Clear() { }
}
class Queue : IList
{
    public void Clear() { }
}
class Program
{
    static void Main()
    {

    }
}
