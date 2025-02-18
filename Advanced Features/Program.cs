// Delegates and Events
using System;

public delegate void Notify();  // Delegate

public class ProcessBusinessLogic
{
    public event Notify ProcessCompleted; // Event

    public void StartProcess()
    {
        Console.WriteLine("Process Started!");
        // Some process logic here
        OnProcessCompleted();
    }

    protected virtual void OnProcessCompleted()
    {
        ProcessCompleted?.Invoke();
    }
}

class Program
{
    static void Main(string[] args)
    {
        ProcessBusinessLogic bl = new ProcessBusinessLogic();
        bl.ProcessCompleted += Bl_ProcessCompleted; // Subscribe to event
        bl.StartProcess();
    }

    private static void Bl_ProcessCompleted()
    {
        Console.WriteLine("Process Completed!");
    }
}

// Lambda Expressions
using System;
using System.Collections.Generic;

class LambdaExpressions
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0); // Lambda expression

        evenNumbers.ForEach(x => Console.WriteLine(x)); // Lambda expression
    }
}

// LINQ
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        var evenNumbers = from num in numbers
                          where num % 2 == 0
                          select num;

        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }
}

// Asynchronous Programming(async/await/Task)
using System;
using System.Threading.Tasks;

class AsynchronousProgram
{
    static async Task Main(string[] args)
    {
        await DoWorkAsync();
    }

    static async Task DoWorkAsync()
    {
        Console.WriteLine("Starting work...");
        await Task.Delay(2000); // Simulate async work
        Console.WriteLine("Work completed!");
    }
}
