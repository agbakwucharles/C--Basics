//If else
int number = 10;

if (number > 0)
{
    Console.WriteLine("The number is positive.");
}
else if (number < 0)
{
    Console.WriteLine("The number is negative.");
}
else
{
    Console.WriteLine("The number is zero.");
}

//switch case
int dayOfWeek = 3;

switch (dayOfWeek)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}

//Exception handling
//Try-Catch
try
{
    int[] numbers = { 1, 2, 3 };
    Console.WriteLine(numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"Exception caught: {ex.Message}");
}
finally
{
    Console.WriteLine("This block is always executed.");
}

//Throwing exceptions
void CheckAge(int age)
{
    if (age < 18)
    {
        throw new ArgumentException("Age must be 18 or older.");
    }
    else
    {
        Console.WriteLine("Age is valid.");
    }
}

try
{
    CheckAge(15);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Exception caught: {ex.Message}");
}
