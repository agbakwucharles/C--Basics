using System;

namespace BasicClassExample
{
    // Define a simple class named 'Person'
    public class Person
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public static int Count = 0;

        // Constructor
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Count++;
        }

        // Method to display person's details
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create objects of the Person class
            Person person1 = new Person("John", "Doe", 30);
            person1.DisplayPersonInfo();
            Console.WriteLine($"Total number of persons: {Person.Count}");

            Person person2 = new Person("Jane", "Smith", 25);
            person2.DisplayPersonInfo();
            Console.WriteLine($"Total number of persons: {Person.Count}");
        }
    }
}
