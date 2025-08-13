using System;

int GetMax(int[] num, int n)
{
    int max = int.MinValue;

    for (int i = 0; i < n; i++)
    {
        if (num[i] > max)
        {
            max = num[i];
        }
    }
    return max;
}

int[] arr = {1, 2, 3, 4, 5, 0 };
int max;
max = GetMax(arr, 6);
Console.WriteLine("Max value in array io : "+ max);

int GetMin(int[] num, int n)
{
    int min = int.MaxValue;

    for (int i = 0; i < n; i++)
    {
        if (num[i] < min)
        {
            min = num[i];
        }
    }
    return min;
}

//int[] arr = new int[5];

//int[] arr2 = { 1, 2, 3, 4, 5 };

//int max = GetMax(arr2, 5);
//int min = GetMin(arr2, 5);

//Console.WriteLine("Max Value is: " + GetMax(arr2, 5));
//Console.WriteLine("Min Value is: " + GetMin(arr2, 5));

//Console.WriteLine("-- Using For Loop --");

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}

//Console.WriteLine("-- Using Foreach Loop --");
//foreach (int item in arr)
//{
//    Console.WriteLine(item);
//}

//******************************** Take Input From User ********************

//Console.WriteLine("Enter Array Size?");
//int size = int.Parse(Console.ReadLine());

//int[] arr1 = new int[size];

//for (int i = 0; i < size; i++)
//{
//    arr1[i] = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("Max Value is: " + GetMax(arr1, size));
//Console.WriteLine("Min Value is: " + GetMin(arr1, size));

// ************************************** Reverse Array ******************************

//void ReverseArray(int[] arr, int n)
//{
//    Console.WriteLine("---- Reverse Array Start ----");
//    int start = 0;
//    int end = n-1;
//    int temp;

//    while (start<= end){
//        temp = arr[start];
//        arr[start]= arr[end];
//        arr[end] = temp;
//        start++;
//        end--;
//    }
//}

//void PrintArray(int[] Arr, int n)
//{
//    for (int i = 0; i < n; i++)
//    {
//        Console.WriteLine(Arr[i]);
//    }
//}

//int SumOfArray(int[] Arr, int n)
//{
//    Console.WriteLine("Sum Of Array!");
//    int sumOfArray = 0;

//    for (int i = 0; i < n; i++)
//    {
//        sumOfArray += Arr[i];
//    }

//    return sumOfArray;
//}

//void AlternateReverse(int[] Arr, int n)
//{
//    Console.WriteLine("Alternate Array Reverse!");
//    int first = 0;
//    int second = 1;
//    int temp;
    
//    while (second <= n)
//    {
//        temp = Arr[first];
//        Arr[first] = Arr[second];
//        Arr[second] = temp;

//        first = first + 2;
//        second = second + 2;
//    }
//}

//int[] Arr3 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

//PrintArray(Arr3, 10);
//ReverseArray(Arr3, 10);
//PrintArray(Arr3, 10);
//AlternateReverse(Arr3, 10);
//PrintArray(Arr3, 10);

//int TotalSum = SumOfArray(Arr3, 10);
//Console.WriteLine("Sum Of Array:" + TotalSum);

Console.WriteLine("---- DONE ----");