// Integer variable
int myInt = 10;
Console.WriteLine($"Integer: {myInt}");

// Double variable
double myDouble = 20.5;
Console.WriteLine($"Double: {myDouble}");

// String variable
string myString = "Hello, World!";
Console.WriteLine($"String: {myString}");

// Boolean variable
bool myBool = true;
Console.WriteLine($"Boolean: {myBool}");

// Character variable
char myChar = 'A';
Console.WriteLine($"Character: {myChar}");

// Array of integers
int[] myArray = { 1, 2, 3, 4, 5 };
Console.WriteLine("Array: " + string.Join(", ", myArray));

// Array of strings
string[] myStringArray = { "apple", "banana", "cherry" };
Console.WriteLine("String Array: " + string.Join(", ", myStringArray));

// List of strings
List<string> myList = new List<string> { "apple", "banana", "cherry" };
Console.WriteLine("List: " + string.Join(", ", myList));

// Dictionary with string keys and integer values
Dictionary<string, int> myDictionary = new Dictionary<string, int>
{
    { "one", 1 },
    { "two", 2 },
    { "three", 3 }
};
Console.WriteLine("Dictionary:");
foreach (var kvp in myDictionary)
{
    Console.WriteLine($"  {kvp.Key}: {kvp.Value}");
}

// Nullable integer
int? myNullableInt = null;
Console.WriteLine($"Nullable Integer: {myNullableInt}");

// Constant variable
const double Pi = 3.14159;
Console.WriteLine($"Constant Pi: {Pi}");
