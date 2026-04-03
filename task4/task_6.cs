using System;

class Program
{
    static void Main()
    {
        int[] arr = {1, 2, 3, 4, 5, 6, 7};
        int k = 3;

        int[] result = RotateLeft(arr, k);

        Console.WriteLine(string.Join(" ", result));
    }

    static int[] RotateLeft(int[] arr, int k)
    {
        int n = arr.Length;
        int[] rotated = new int[n];

        k = k % n;

        for (int i = 0; i < n; i++)
        {

            int newIndex = (i + (n - k)) % n;
            rotated[newIndex] = arr[i];
        }

        return rotated;
    }
}
