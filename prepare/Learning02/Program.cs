using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Google";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2010;
        job1._endYear = 2012;
        job1.Display();

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Senior Developer";
        job2._startYear = 2015;
        job2._endYear = 2018;
        job2.Display();

        Resume person1 = new Resume();
        person1._name = "Ana Clara";
        person1._jobs.Add(job1);
        person1._jobs.Add(job2);
        person1.Display();

        
    }
}