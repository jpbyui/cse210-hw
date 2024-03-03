using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        String firstName = "";
        String lastName = "";
        Console.WriteLine("What is your first name?");
        firstName = Console.ReadLine();
        Console.Write("What is your last name?");
        lastName = Console.ReadLine();
        Console.WriteLine("Your name is "+lastName+", "+firstName +" "+ lastName+".");


    }
}