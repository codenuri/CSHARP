using System;

class Program
{
    static void Main()
    {
        int[]  a = new int[3];
        int[,] b = new int[3,3];


        int[][] arr = new int[3][];

        arr[0] = new int[3] { 1, 2, 3 };
        arr[1] = new int[2] { 1, 2 };
        arr[2] = new int[1] { 1 };

        int[] a1 = arr[0];

        arr[0][1] = 10;
      
        int[][] arr2 = new int[3][] { new int[3], 
                                      new int[2], 
                                      new int[1] };  

    }
}


