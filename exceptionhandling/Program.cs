// Purpose: Demonstrate exception handling in C#.

// IndexOutOfRangeException checks if the index is out of range.
try
{
    // Code that may throw an exception
    int[] numbers = { 1, 2, 3 };
    Console.WriteLine(numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"Index out of range: {ex.Message}");
}

// DivideByZeroException checks if the denominator is zero.
try
{
    // Code that may throw an exception
    using (var reader = new StreamReader("file.txt"))
    {
        Console.WriteLine(reader.ReadToEnd());
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"File not found: {ex.Message}");
}
finally
{
    Console.WriteLine("Execution completed.");
}

// FormatException checks if the input is in the correct format.
try
{
    // Code that may throw an exception
    int result = int.Parse("abc");
}
catch (FormatException ex)
{
    Console.WriteLine($"Format exception: {ex.Message}");
}
catch (OverflowException ex)
{
    Console.WriteLine($"Overflow exception: {ex.Message}");
}

// FileNotFoundException checks if the file is not found.
try
{
    // Code that may throw an exception
    string content = File.ReadAllText("file.txt");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

// default exception
try
{
    // Code that may throw an exception
    int result = int.Parse("abc");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
finally
{
    Console.WriteLine("Execution completed.");
}