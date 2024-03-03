using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());
        string letter; 
        if (grade >= 90)
            letter = "A";
        else if (grade >= 80)
            letter = "B";
        else if (grade >= 70)
            letter = "C";
        else if (grade >= 60)
            letter = "D";
        else
            letter = "F";

        int lastDigit = (int)grade % 10;
        string sign = "";
        if (lastDigit >= 7)
            sign = "+";
        else if (lastDigit < 3 && grade != 100)
            sign = "-";
        
        if (letter == "A" && lastDigit >= 7)
            sign = "-"; 
        else if (letter == "F")
            sign = "";
        Console.WriteLine($"Your final grade is: {letter}{sign}");
        if (grade >= 70)
            Console.WriteLine("Congratulations! You approve");
        else
            Console.WriteLine("Sorry, not this time");

    }
}