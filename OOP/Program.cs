using System;

namespace OOP
{
    // Abstraction: Abstract class defining a blueprint for derived classes
    public abstract class Animal
    {
        // Encapsulation: Private field with a public property
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Abstract method to be implemented by derived classes
        public abstract void MakeSound();
    }

    // Inheritance: Dog class inherits from Animal class
    public class Dog : Animal
    {
        // Polymorphism: Overriding the abstract method
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }

    // Inheritance: Cat class inherits from Animal class
    public class Cat : Animal
    {
        // Polymorphism: Overriding the abstract method
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of Dog and Cat
            Animal myDog = new Dog { Name = "Buddy" };
            Animal myCat = new Cat { Name = "Whiskers" };

            // Demonstrating polymorphism
            myDog.MakeSound(); // Output: Woof!
            myCat.MakeSound(); // Output: Meow!

            // Accessing encapsulated property
            Console.WriteLine($"Dog's name: {myDog.Name}");
            Console.WriteLine($"Cat's name: {myCat.Name}");
        }
    }
}
