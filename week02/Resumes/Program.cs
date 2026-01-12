using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

    //first job
    Job job1 = new Job();
    job1._company = "Microsoft";
    job1._jobTitle = "Software Engineer";
    job1._startYear = 2019;
    job1._endYear = 2026;
    
    //second job
    Job job2 = new Job();
    job2._company = "Dangote Petroleum Refinery";
    job2._jobTitle = "Process Engineer";
    job2._startYear = 2023;
    job2._endYear = 2025;

    Job job3 = new Job();
    job3._company = "OBATEXT";
    job3._jobTitle = "Computer Instructor";
    job3._startYear = 2013;
    job3._endYear = 2014;

   

    //add jobs to list
    Resume newResume = new Resume ();

    newResume._name = "Charles Isama";

    newResume._jobs = new List<Job>();

    newResume._jobs.Add(job3);
    newResume._jobs.Add(job2);
    newResume._jobs.Add(job1);

   newResume.DisplayResume();

    
    }
    
}