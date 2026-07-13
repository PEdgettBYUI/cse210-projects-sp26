/* References and Notes
 * 1. https://byui-cse.github.io/cse210-course-2023/unit05/prepare.html
 * 2. duck.ai_2026-07-10_11-56-15.txt - Used to remind me how protected worked
 *      to allow for each child class to inherit it and still act as a
 *      helper function for ToString()
 * 3.
 * 4.
 * 
 */

namespace Develop05;

// Simple Goal/"Abstract Goal"-equivalent
public class Goal
{
    private bool _goalDone_PTE;
    private string _name_PTE;
    private string _description_PTE;
    private int _points_PTE;

    public Goal(string name, string description, int points)
    {
        _goalDone_PTE = false;
        _name_PTE = name;
        _description_PTE = description;
        _points_PTE = points;
    }

    public virtual void IsCompleted()
    {  
        if (!_goalDone_PTE)
        {
            _goalDone_PTE = true;
            GivePoints();
        }
    }

    public virtual int GivePoints()
    {
        return _points_PTE;
    }

    // See Reference 1
    protected string BoolToCharacter()
    { if (_goalDone_PTE) { return "X"; } 
        /*else*/ return " "; }

    override public string ToString()
    {
        return $"[{BoolToCharacter()}] {_name_PTE} ({_description_PTE})";
    }
}