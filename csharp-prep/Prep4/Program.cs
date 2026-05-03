using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!\n");

        // Initialize List
        List<int> Numbers_PTE = new List<int>();

        // Initialize variables
        string UserNumberInput_PTE;
        int IntUserNumber_PTE;
        int LargestInteger_PTE;
        int SumTotalOfList_PTE;
        float AverageOfList_PTE;
        int SmallestInteger_PTE;

        // Print program introduction & instructions
        Console.WriteLine("Welcome to the Number Novelty Program.\nEnter a list of numbers, type 0 when finished to see the results.");
        
        // Do-while loop until the value 0 is provided
        do {
            // Prompt for Numbers
            Console.Write("Enter a number: ");
            UserNumberInput_PTE = Console.ReadLine();

            // Convert to Integer
            IntUserNumber_PTE = int.Parse(UserNumberInput_PTE);

            if (IntUserNumber_PTE != 0) 
            {
                Numbers_PTE.Add(IntUserNumber_PTE);
            }
        } while (UserNumberInput_PTE != "0");

        // Calculate Sum
        SumTotalOfList_PTE = SumValues(Numbers_PTE);
        // Calculate Average
        AverageOfList_PTE = FindAverage(Numbers_PTE);
        // Find the Largest Number
        LargestInteger_PTE = FindMaxValue(Numbers_PTE);
        // Find the Smallest Positive number
        SmallestInteger_PTE = FindSmallestPositiveValue(Numbers_PTE);

        
        // Output Results
        Console.WriteLine($"\n\nThe sum is: {SumTotalOfList_PTE}");
        Console.WriteLine($"The average is: {AverageOfList_PTE}");
        Console.WriteLine($"The largest number is: {LargestInteger_PTE}");
        Console.WriteLine($"The smallest number is: {SmallestInteger_PTE}");

        // Goodbye message
        Console.WriteLine("\n\n We hope you enjoyed using the Number Novelty today!");
    }




    static int SumValues(List<int> IntList)
    {
        int Sum_PTE = 0;

        foreach (int number in IntList)
        {
            Sum_PTE += number;
        }
        return Sum_PTE;
    }

    static float FindAverage(List<int> IntList)
    {
        // Find the Sum of the list
        int SumTotal_PTE = SumValues(IntList);
        
        // Get the length of the List
        int LenList_PTE = IntList.Count;

        // Return the Sum Total, cast as float, divided by the List Length
        return ((float)SumTotal_PTE)/LenList_PTE;
    }

    static int FindMaxValue(List<int> IntList)
    {
        // Set inital Highest value
        int HighestInt_PTE = IntList[0];

        // Compare every number successively to find the highest
        foreach (int CurrentNumber in IntList)
        {
            if (CurrentNumber > HighestInt_PTE)
            {
                HighestInt_PTE = CurrentNumber;
            }    
        }
        return HighestInt_PTE;
    }

    static int FindSmallestPositiveValue(List<int> IntList)
    {
        // Initialize continuing Index
        int ContinuingIndex_PTE = 0;

        // Set initial Smallest value, which must be greater than 0
        int SmallestInt_PTE = 0;
        for (int i=0; i<IntList.Count; i++)
        {
            if (IntList[i] > 0)
            {
                SmallestInt_PTE = IntList[i];
            }
            else {ContinuingIndex_PTE++;}
        }

        // From ContinuingIndex, compare the remaining list values
        for (int i = ContinuingIndex_PTE; i<IntList.Count; i++)
        {
            if (IntList[i] > 0 && IntList[i] < SmallestInt_PTE)
            {
                SmallestInt_PTE = IntList[i];
            }
        }

        return SmallestInt_PTE;
    }
}