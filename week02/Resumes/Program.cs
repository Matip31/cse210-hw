using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1= new Job();
        job1._company="ErfelySA";
        job1._jobTitle="IT Help Desk";
        job1._startYear=2025;
        job1._endYear=2027;
        Job job2= new Job();
        job2._company="Sabre";
        job2._jobTitle="API Support";
        job2._startYear=2026;
        job2._endYear=2028;
        job1.Display();
        job2.Display();
        Resume resume1= new Resume();
        resume1._name="Matias Ponce";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
    }
}