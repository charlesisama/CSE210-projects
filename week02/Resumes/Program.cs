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
    job2._company = "DPRP";
    job2._jobTitle = "Process Engineer";
    job2._startYear = 2023;
    job2._endYear = 2025;

    //diplay the jobs
    job1.DisplayJobDetails();
    job2.DisplayJobDetails();

    //add jobs to list
    Resume newResume = new Resume ();

    newResume._name = "Charles Isama";

    newResume._jobs = new List<Job>();

    newResume._jobs.Add(job1);
    newResume._jobs.Add(job2);

   newResume.DisplayResume();

    
    }
    
}