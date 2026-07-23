/* References and Notes
 * 1. https://byui-cse.github.io/cse210-course-2023/unit05/prepare.html
 * 2. duck.ai_2026-07-10_11-56-15.txt - Used to remind me how protected worked
 *      to allow for each child class to inherit it and still act as a
 *      helper function for ToString()
 * 3.   A suggestion made while using JetBrains Rider by the IDE's Context
 *      Actions. I had not previously considered that Protected and Private
 *      were not mutually exclusive.
 * 4.
 * 
 */

namespace Develop05;

// Simple Goal/"Abstract Goal"-equivalent from design
public class Goal
{
    // Attributes
    private bool _goalDone_PTE;
    private string _name_PTE;
    private string _description_PTE;
    private int _points_PTE;
    private char _goalType_PTE;
    
    // Setters and Getters
    // See Reference 3.
    private protected void ToggleGoalDone_PTE()
    { _goalDone_PTE = !_goalDone_PTE; }
    public bool Get_goalDone_PTE()
    { return _goalDone_PTE; }
    private protected string Get_name_PTE()
    { return _name_PTE; }
    private protected string Get_description_PTE()
    { return _description_PTE; }
    private protected int Get_points_PTE()
    { return _points_PTE; }
    
    // Goal-Type distinguisher for Save and Load
    private protected void Set_goalType_PTE(char goalType)
    {  _goalType_PTE = goalType; }
    private protected char Get_goalType_PTE()
    { return _goalType_PTE; }
    
    
    // Constructor
    public Goal(string name, string description, int points, bool goalDone = false)
    {
        _goalDone_PTE = goalDone;
        _name_PTE = name;
        _description_PTE = description;
        _points_PTE = points;
        _goalType_PTE = 'S';    // S for simple
    }
    
    // Methods
    public virtual void IsCompleted()
    {  
        if (!_goalDone_PTE)
        {
            ToggleGoalDone_PTE();
            GivePoints();
        }
        else { Console.WriteLine("You've Already Completed this Goal"); }
    }

    protected virtual int GivePoints()
    { return _points_PTE; }

    // See Reference 1
    private protected string BoolToCharacter()
    { if (_goalDone_PTE) { return "X"; } 
        /*else*/ return " "; }

    private protected virtual string ToCsvOutputFormat()
    {
        return $"{Get_goalType_PTE()},{Get_name_PTE()},{Get_description_PTE()},{Get_points_PTE()},{Get_goalDone_PTE()}";
    }

    public override string ToString()
    {
        return $"[{BoolToCharacter()}] {Get_name_PTE()} ({Get_description_PTE()})";
    }
    
    
}