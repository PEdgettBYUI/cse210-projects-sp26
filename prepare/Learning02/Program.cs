using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!\n\n");

        Job job1_PTE = new Job();

        job1_PTE._jobTitle_PTE = "Software Engineer";
        job1_PTE._company_PTE = "Microsoft";
        job1_PTE._startYear_PTE = 2022;
        job1_PTE._endYear_PTE = 2023;


        // Console.WriteLine($"{Job1_PTE._Company_PTE}\n{Job1_PTE._JobTitle_PTE}"); // TEST print
        job1_PTE.DisplayJobDetails();




    }
}