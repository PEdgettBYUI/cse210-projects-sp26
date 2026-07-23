namespace Develop05;
using System.IO;


public class ToDoList
{
    private int _goalHighScore;
    private List<Goal> _goalToDoList = new List<Goal>();
    
    // Setters and Getters
    public int Get_goalHighScore()
    { return _goalHighScore; }
    public void Set_goalHighScore(int goalHighScore) { _goalHighScore = goalHighScore; }
    public List<Goal> Get_goalToDoList() { return _goalToDoList; }
    
    
    public void SaveToDoList(string filename)
    {
        //Check if the list has entires, if not, Output error message
        if (_goalToDoList.Count > 0)
        {
            // Using StreamWriter, go through _entries and output each Entry's ConvertToString()
            // NOTE: Streamwriter will create a new file of the given filename.txt if it does not exist already
            using (StreamWriter outputFile = new StreamWriter(filename + ".txt"))
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

    public void LoadToDoList(string filename)
    {
        // Adds .txt for the file search function to work
        filename = filename + ".txt";

        // Open the given file name
        if (System.IO.File.Exists(filename))
        {
            string[] lines_PTE = System.IO.File.ReadAllLines(filename);
            string[] headerLess_PTE = lines_PTE.Skip(1).ToArray();
            
            // Set current High Score value
            Set_goalHighScore(int.Parse(lines_PTE[0]));
            
            // Read each line from the file
            foreach (string line in headerLess_PTE)
            {
                // Split the line into parts at the '#'
                string[] parts_PTE = line.Split(",");
                // Use the split parts to instance an Entry with the "Loading" constructor
                string f_goalType_PTE = parts_PTE[0];
                string f_goalname_PTE = parts_PTE[1];
                string f_description_PTE = parts_PTE[2];
                int f_points_PTE = int.Parse(parts_PTE[3]);
                bool f_completeFlag_PTE = bool.Parse(parts_PTE[4]);
                
                Goal aGoal = null;
                // If Checklist
                if (f_goalType_PTE == "C")
                {
                    int f_bonusPoints_PTE = int.Parse(parts_PTE[5]);
                    int f_finalCount_PTE = int.Parse(parts_PTE[6]);
                    int f_currentCount_PTE =  int.Parse(parts_PTE[7]);
                    aGoal = new Checklist(f_goalname_PTE, f_description_PTE, f_points_PTE, f_bonusPoints_PTE, f_finalCount_PTE, f_currentCount_PTE, f_completeFlag_PTE);
                }
                
                // Create a New Goal object of the given Child-Class
                switch (f_goalType_PTE)
                {
                    case "S":
                        aGoal = new Goal(f_goalname_PTE, f_description_PTE, f_points_PTE, f_completeFlag_PTE);
                        break;
                    case "E":
                        aGoal = new Goal(f_goalname_PTE, f_description_PTE, f_points_PTE, f_completeFlag_PTE);
                        break;
                    case "C":
                        break;
                    default:
                        throw new Exception($"UNKNOWN goalType: {f_goalType_PTE}");
                }
                // Add the current line/Goal to the TO-DO List
                this.AddGoalToToDoList(aGoal);
                
            }
            Console.WriteLine($"[TO-DO List: \"{filename}\" Loaded.");
        }
        else
        {
            // Error message
            Console.WriteLine($"ERROR!\nThe File: \"{filename}\" Does Not Exist within the save directory.\nPlease provide an existing filename.\n\n");
        }
    }

    public void AddGoalToToDoList(Goal aGoal)
    { _goalToDoList.Add(aGoal); }

    public override string ToString()
    {
        string allGoals = "";
        foreach (Goal goalItem in _goalToDoList)
        {
            allGoals += $"{goalItem.ToString()}\n";
        }
        return allGoals;
    }
    
}