using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!\n\n");


        Resume myResume_PTE = new Resume();
        myResume_PTE._name_PTE = "Allison Rose";

        Job job1_PTE = new Job();
        Job job2_PTE = new Job();

        job1_PTE._jobTitle_PTE = "Software Engineer";
        job1_PTE._company_PTE = "Microsoft";
        job1_PTE._startYear_PTE = 2022;
        job1_PTE._endYear_PTE = 2023;


        // Console.WriteLine($"{Job1_PTE._Company_PTE}\n{Job1_PTE._JobTitle_PTE}"); // TEST print
        job1_PTE.DisplayJobDetails();

        job2_PTE._jobTitle_PTE = "Manager";
        job2_PTE._company_PTE = "Apple";
        job2_PTE._startYear_PTE = 2019;
        job2_PTE._endYear_PTE = 2022;

        myResume_PTE._jobs_PTE.Add(job1_PTE);
        myResume_PTE._jobs_PTE.Add(job2_PTE);

        myResume_PTE.DisplayResume();
        Console.WriteLine();




    }
}