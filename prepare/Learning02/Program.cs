using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job _job1 = new Job();
        _job1._jobTitle = "Software Engineer";
        _job1._company = "Apple";
        _job1._startYear = 1992;
        _job1._endYear = 2022;

        Job _job2 = new Job();
        _job2._jobTitle = "Manager";
        _job2._company = "Microsoft";
        _job2._startYear = 2022;
        _job2._endYear = 2025;
        
        Resume _myResume = new Resume();
        _myResume._personsname = "Carter Hart";
        _myResume._jobs.Add(_job1);
        _myResume._jobs.Add(_job2);

        _myResume.Display_Resume();
    }


}

