class Program
{
    static void Main()
    {
        // Call the Greet method
        Greet();
        // Call the GreetUser method
        GreetUser("Alice");
        // Call the Add method
        int sum = Add(5, 3);
        Console.WriteLine(sum); // Output: 8
        // Call the FetchDataAsync method
        Task<string> fetchDataTask = FetchDataAsync();
        Console.WriteLine(fetchDataTask.Result); // Output: Data fetched
        // Call the GetDefaultValue method
        int defaultInt = GetDefaultValue<int>();
        Console.WriteLine(defaultInt); // Output: 0
        // Call the DisplayMessage method
        DisplayMessage("Hello, World!");
        DisplayMessage("Hello, World!", true);
    }

    public static void Greet()
    {
        Console.WriteLine("Hello, World!");
    }
    public static void GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static async Task<string> FetchDataAsync()
    {
        await Task.Delay(1000); // Simulate async work
        return "Data fetched";
    }
    public static T GetDefaultValue<T>()
    {
        return default(T);
    }
    public static void DisplayMessage(string message, bool isUrgent = false)
    {
        if (isUrgent)
        {
            Console.WriteLine($"URGENT: {message}");
        }
        else
        {
            Console.WriteLine(message);
        }
    }

}