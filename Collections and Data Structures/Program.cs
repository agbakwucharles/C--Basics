using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Arrays
        int[] intArray = { 1, 2, 3, 4, 5 };
        string[] stringArray = { "one", "two", "three" };
        Console.WriteLine("Arrays:");
        foreach (int i in intArray)
        {
            Console.WriteLine(i);
        }
        foreach (string s in stringArray)
        {
            Console.WriteLine(s);
        }
        // 2D Arrays
        int[,] int2DArray = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        Console.WriteLine("\n2D Arrays:");
        for (int i = 0; i < int2DArray.GetLength(0); i++)
        {
            for (int j = 0; j < int2DArray.GetLength(1); j++)
            {
                Console.Write(int2DArray[i, j] + " ");
            }
            Console.WriteLine();
        }

        // 3D Arrays
        int[,,] int3DArray = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };
        Console.WriteLine("\n3D Arrays:");
        foreach (int i in int3DArray)
        {
            Console.Write(i + " ");
        }

        // Lists
        List<int> intList = new List<int> { 1, 2, 3, 4, 5 };
        List<string> stringList = new List<string> { "one", "two", "three" };
        Console.WriteLine("\nLists:");
        foreach (int i in intList)
        {
            Console.WriteLine(i);
        }
        foreach (string s in stringList)
        {
            Console.WriteLine(s);
        }

        // Dictionaries
        Dictionary<int, string> dictionary = new Dictionary<int, string>
        {
            { 1, "one" },
            { 2, "two" },
            { 3, "three" }
        };

        Console.WriteLine("\nDictionaries:");
        foreach (KeyValuePair<int, string> kvp in dictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        // Queues
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("first");
        queue.Enqueue("second");
        queue.Enqueue("third");

        Console.WriteLine("\nQueues:");
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }

        // Stacks
        Stack<string> stack = new Stack<string>();
        stack.Push("first");
        stack.Push("second");
        stack.Push("third");

        Console.WriteLine("\nStacks:");
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }

        // HashSets
        HashSet<int> hashSet = new HashSet<int> { 1, 2, 3, 4, 5 };

        Console.WriteLine("\nHashSets:");
        foreach (int i in hashSet)
        {
            Console.WriteLine(i);
        }
    }
}
