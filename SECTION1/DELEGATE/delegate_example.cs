using System;

delegate int Comparison(int arg1, int arg2);


class Program
{
    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    

    public static void Sort(int[] arr, Comparison cmp)
    {
        int sz = arr.GetLength(0);

        for (int i = 0; i < sz - 1; i++)
        { 
            for (int j = i + 1; j < sz; j++)
            {
                //if ( arr[i] > arr[j] )           

                if ( cmp( arr[i], arr[j]) > 0)
                    Swap(ref arr[i], ref arr[j]);
            }
        }
    }


    static void Main()
    {
        int[] x = { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };

        Sort(x, 
            delegate(int a, int b) { return a < b ? 1 : -1; } );

        foreach (int n in x)
            Console.WriteLine(n);
    }
}

