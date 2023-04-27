using System;

class Program
{
    static void Main(string [] args)
    {
        
        int[] arr = { 3, 6, 1, 5, 2, 7, 11, 8 };

        
        int maxIndex = 0;
        int minIndex = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > arr[maxIndex])
            {
                maxIndex = i;
            }
            else if (arr[i] < arr[minIndex])
            {
                minIndex = i;
            }
        }

        
        int temp = arr[maxIndex];
        arr[maxIndex] = arr[minIndex];
        arr[minIndex] = temp;

        
        Console.WriteLine(string.Join(", ", arr));
    }
}
