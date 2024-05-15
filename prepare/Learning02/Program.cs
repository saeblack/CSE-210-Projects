using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "software engineer";
        job1._company = "BYU";
        job1._startYear = "2020";
        job1._endYear = "2020";
        job1.showJobInfo();

    }
}