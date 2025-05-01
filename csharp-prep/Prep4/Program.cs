using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        List<int> numbers;
        numbers = new List<int>();

        int userNum = -1;
        while (userNum != 0)
        {
            Console.WriteLine("Enter a number (0 to quit): ");

            string userResponse = Console.ReadLine();
            userNum = int.Parse(userResponse);

            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
        }

        // Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        //Compute the average
        float average = ((float)sum / numbers.Count);
        Console.WriteLine($"The average is: {average}");

        //Find the max
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}