using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // For loop example
        Console.WriteLine("For loop:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Iteration {i}");
        }

        // While loop example
        Console.WriteLine("\nWhile loop:");
        int j = 0;
        while (j < 5)
        {
            Console.WriteLine($"Iteration {j}");
            j++;
        }

        // Do-while loop example
        Console.WriteLine("\nDo-while loop:");
        int k = 0;
        do
        {
            Console.WriteLine($"Iteration {k}");
            k++;
        } while (k < 5);

        // Foreach loop example
        Console.WriteLine("\nForeach loop:");
        List<string> items = new List<string> { "Item1", "Item2", "Item3" };
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}
