using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 to finish.");

        int input;
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
                numbers.Add(input);
        } while (input != 0);

        int sum = numbers.Sum();
        double average = numbers.Average();
        int largestNumber = numbers.Max();

        Console.WriteLine("The sum is: "+sum);
        Console.WriteLine("The average is: "+average);
        Console.WriteLine("The largest number is: "+largestNumber);

        List<int> positiveNumbers = numbers.Where(num => num > 0).ToList();
        int smallestPosNum = positiveNumbers.Count > 0 ? positiveNumbers.Min() : 0;

        Console.WriteLine("The smallest positive number is: " + smallestPosNum);

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}