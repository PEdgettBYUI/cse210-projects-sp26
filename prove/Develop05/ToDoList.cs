namespace Develop05;
using System.IO;


public class ToDoList
{
    private List<Goal> _goalToDoList = new List<Goal>();
    
    // TEMP Functions
    void SaveToDoList()
    {
        //Check if the list has entires, if not, Output error message
        if (_goalToDoList.Count > 0)
        {
            // Using StreamWriter, go through _entries and output each Entry's ConvertToString()
            // NOTE: Streamwriter will create a new file of the given filename.txt if it does not exist already
            using (StreamWriter outputFile = new StreamWriter("ToBeReplacedWithInputLater" + ".txt"))
            {
                foreach (Goal goal in _goalToDoList)
                {
                    outputFile.WriteLine();
                }
            }
        }
        else
        {
            // Error message
            Console.WriteLine("[NO Entries. SAVE Failed.]");
        }
    }

    public void AddGoalToToDoList(Goal aGoal)
    { _goalToDoList.Add(aGoal); }

    public override string ToString()
    {
        string allGoals = "";
        foreach (Goal goalItem in _goalToDoList)
        {
            allGoals += $"goalItem.ToString()\n";
        }
        return allGoals;
    }
    
}