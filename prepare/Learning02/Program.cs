using System;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Rentcars";
        job1._jobTitle = "Programmer";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Rentalcover";
        job2._jobTitle = "Seller";
        job2._startYear = 2019;
        job2._endYear = 2020;

        Resume resumeList = new Resume();
        resumeList._name = "Name: Allison Rose";
        resumeList._jobs.Add(job1);
        resumeList._jobs.Add(job2);

        resumeList.DisplayResume();
    }
}
        public class Job 
    {
        public string _company;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;
         public void Display()
    {
        Console.WriteLine($"{_jobTitle}  ({_company})  {_startYear}-{_endYear}");
    }

        }

        public class Resume 
        {
            public string _name;
    
            public List<Job> _jobs = new List<Job>();

            public void DisplayResume()
            {
                Console.WriteLine(_name);
                Console.WriteLine("Jobs:");
                foreach (Job job in _jobs)
                {
                    job.Display();
                    
                }
            }
        }   


