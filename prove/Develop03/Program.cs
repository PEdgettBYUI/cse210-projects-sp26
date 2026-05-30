/* References Used or Borrowed from
 * 1. https://chatgpt.com/share/6a18ac43-58f4-83e8-9a4a-4f0656ba9c95
 * 2. https://chatgpt.com/share/6a19e56f-d17c-83e8-b981-b725cb694c3c
 * 3. 
 */
using System;
using System.Dynamic;
using System.Text.Json;

class Program
{


    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        // Test Code for Reference.cs
        /*
        Reference testRef = new Reference("John", 3, 16);
        Reference testRef2 = new Reference("Proverbs", 3, 5, 6);
        Console.WriteLine(testRef); // This is possible because of the ToString Override
        Console.WriteLine(testRef2); // This is possible because of the ToString Override
        */
        
        // // See Reference 2.
        // string json = File.ReadAllText(GetJsonPath("NT-Truncated-lds-scriptures-filtered.json"));

        // Dictionary<string, Dictionary<string, List<string>>>? books =
        //     JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, List<string>>>>(json);
        
        // Console.WriteLine($"\nBooks in JSON: {books.Count}");   // Test Print
        // Console.WriteLine($"{ books["John"]["3"][16-1]}\n");    // Test Print

        JsonScripture_Utility test = new JsonScripture_Utility("New Testament", "NT-Truncated-lds-scriptures-filtered.json");

    }

}

