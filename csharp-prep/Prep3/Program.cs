using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        /*Start by asking the user for the magic number. Ask the user for a guess. 
        Using an if statement, determine if the user needs to guess higher or lower 
        next time, or tell them if they guessed it.*/

        /*Add a loop that keeps looping as long as the guess does not match the magic number.
        At this point, the user should be able to keep playing until they get the correct answer.*/

        /*Instead of having the user supply the magic number, generate a random number from 1 to 100.
        Play the game and make sure it works!*/

        // Console.WriteLine("What is the magic number? ");
        // int magicNum = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNum)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());      

            if (magicNum > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNum < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        };
    }
}
