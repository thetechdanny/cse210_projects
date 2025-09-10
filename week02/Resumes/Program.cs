using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Microsoft Engineer";
        job1._startYear = 1990;
        job1._endYear = 2000;
        // job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Back-End Developer";
        job2._startYear = 2000;
        job2._endYear = 2005;
        // job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        myResume._name = "Daniel Kalu";

        myResume.DisplayResume();

    }
}