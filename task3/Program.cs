int[] arr = { 1, 2, 3, 4, 5 };

    
 PrintArray(arr, arr.Length - 1);


 void PrintArray(int[] arr, int index)
{
    
    if (index < 0) return;

    Console.WriteLine(arr[index]);
    PrintArray(arr, index - 1);
}