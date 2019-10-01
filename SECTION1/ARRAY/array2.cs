using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[3];

        int[,] arr1 = new int[3, 2];
        int[,] arr2 = new int[3, 2] { { 1, 1 }, 
                                      { 2, 2 }, 
                                      { 3, 3 } };

        int[,] arr3 = new int[,] { { 1, 1 }, 
                                   { 2, 2 }, 
                                   { 3, 3 } };

        int[,] arr4 = { { 1, 1 }, { 2, 2 }, { 3, 3 } };

        arr1[0, 0] = 10;
        arr1[0, 1] = 20;

        foreach (int n in arr2)
            Console.WriteLine(n);

        int[,,] arr5 = new int[2, 2, 2];
    }
}
    




// 5.  다차원 배열