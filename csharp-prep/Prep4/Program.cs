using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's create a list of numbers!");
        List<int> numbers = new List<int>();

        int givenNumber = -1;

        while (givenNumber != 0)
        {
            Console.Write("Give a number ('0' if youn want to quit): ");
            givenNumber = int.Parse(Console.ReadLine());
            numbers.Add(givenNumber);
        }

        numbers.Remove(0);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The total is: {sum}");

        int totalOfNumbers = numbers.Count;
        float average = sum / totalOfNumbers;
        Console.WriteLine($"The average is {average}");

        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");
    }
}