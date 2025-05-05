using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        Job job1 = new();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2021;
        job1._endYear = 2023;

        Job job2 = new();
        job2._jobTitle = "Janitor";
        job2._company = "BYU-Idaho";
        job2._startYear = 2022;
        job2._endYear = 2024;


        Resume myResume = new Resume();
        myResume._name = "Sadie Bybee";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }


    // class Applicant
    // {
    //     public string _firstName;
    //     public string _lastName;
    //     public string _phoneNumber;
    //     public string _emailAddress;
    //     public int _orderOfApplication;
    //     public int _rank;
    //     // public Resume _resume;
    //     public void Display()
    //     {
    //     }
    // }
}