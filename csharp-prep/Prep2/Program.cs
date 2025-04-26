using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        
        // Ask the user for their grade percentage, then write a series of if-elif-else statements 
        // to print out the appropriate letter grade. 

        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        /*Assume that you must have at least a 70 to pass the class. After determining 
        the letter grade and printing it out. Add a separate if statement to determine 
        if the user passed the course, and if so display a message to congratulate them. 
        If not, display a different message to encourage them for next time.*/

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("You failed, better luck next time!");
        }

        /*Change your code from the first part, so that instead of printing the letter 
        grade in the body of each if, elif, or else block, instead create a new 
        variable called letter and then in each block, set this variable to the 
        appropriate value. Finally, after the whole series of if-elif-else statements, 
        have a single print statement that prints the letter grade once.*/
    }
}