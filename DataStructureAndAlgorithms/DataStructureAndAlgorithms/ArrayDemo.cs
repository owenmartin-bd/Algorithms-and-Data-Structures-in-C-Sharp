namespace DataStructureAndAlgorithms;

public static class ArrayDemo
{
    public static void ArrayTimeComplexity(object[] array) 
    {
        // access by index O(1)
        Console.WriteLine(array[0]);

        int length = array.Length;
        object elementINeedToFind = new object();

        // searching for an element O(N)
        for (int i = 0; i < length; i++) 
        {
            if(array[i] == elementINeedToFind)
            {
                Console.WriteLine("Exists/Found");
            }
        }

        // add to a full array
        var bigArray = new int[length * 2];
        Array.Copy(array, bigArray, length);
        bigArray[length +  1] = 10;

        // add to the end when there's some space
        // O(1)
        array[length - 1] = 10;

        // O(1)
        array[6] = null;
    }

    public static void RemoveAt(object[] array, int index)
    {
        var newArray = new object[array.Length - 1];
        Array.Copy (array, 0,newArray, 0,index);
        Array.Copy(array, index + 1, newArray, index, array.Length - 1 - index);
    }

    public static void MultiDimArrays()
    {
        int[,] r1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] r2 = { { 1, 2, 3 }, { 4, 5, 6 } };

        for(int i = 0; i < r2.GetLength(0); i++)
        {
            for(int j = 0; j < r2.GetLength(1); j++)
            {
                Console.WriteLine($"{r2[i, j]}");
            }
            Console.WriteLine();
        }
    }

    public static void JaggedArrayDemo()
    {
        int[][] jaggedArray = new int[4][];
        jaggedArray[0] = new int[1];
        jaggedArray[1] = new int[3];
        jaggedArray[2] = new int[2];
        jaggedArray[3] = new int[4];

        Console.WriteLine("Enter the numbers for a jagged array.");

        for (int i = 0; i < jaggedArray.Length; i++) 
        {
            for(int j = 0;j < jaggedArray[i].Length; j++)
            {
                string st = Console.ReadLine()!;
                jaggedArray[i][j] = int.Parse(st);
            }
        }

        Console.WriteLine("") ;
        Console.WriteLine("Printing the Elements:") ;

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++) 
            {
                Console.Write(jaggedArray[i][j]);
                Console.WriteLine("\0");
            }
            Console.WriteLine("") ;
        }
    }

    public static void ArraysDemo()
    {
        int[] a1;
        a1 = new int[10];

        int[] a2 = new int[5];

        int[] a3 = new int[5] { 1, 3, -2, 5, 10 };

        int[] a4 = { 1, 2, 3, 4, 5 };

        for (int i = 0; i < a3.Length; i++)
        {
            Console.Write($"{a3[i]} ");
        }

        Console.WriteLine();

        foreach (var el in a4)
        {
            Console.WriteLine($"{el} ");
        }

        Console.WriteLine();

        Array myArray = new int[5];

        Array myArray2 = Array.CreateInstance(typeof(int), 5);
        myArray2.SetValue(1, 0);

        Console.Read();
    }

    public static void Test1BasedArray()
    {
        Array myArray = Array.CreateInstance(typeof(int), new[] { 4 }, new[] { 1 });

        myArray.SetValue(2024, 1);
        myArray.SetValue(2025, 2);
        myArray.SetValue(2026, 3);
        myArray.SetValue(2027, 4);

        Console.WriteLine($"Starting index: {myArray.GetLowerBound(0)}");
        Console.WriteLine($"Ending index: {myArray.GetUpperBound(0)}");

        for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
        {
            Console.WriteLine($"{myArray.GetValue(i)} at index {i}");
        }
    }

    public static unsafe void IterateOver(int[] array)
    {
        fixed (int* b = array) 
        {
            int* p = b;
            for (int i = 0; i < array.Length; i++) 
            {
                Console.WriteLine(*p);
                p++; 
            }
        }
    }
}

