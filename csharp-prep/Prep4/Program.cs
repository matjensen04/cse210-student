using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers =new List<int>();

        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter a number. Type 0 to quit: ");
            string response = Console.ReadLine();
            number = int.Parse(response);
            
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        foreach (int number2 in numbers)
        {
            sum += number2;
        }

        Console.WriteLine($"The sume is: {sum}");
        
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number3 in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
    
        Console.WriteLine($"The max is: {max}");
    }

    
}