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

    public int GivePoints()
    {
        return _points_PTE;
    }

    private string BoolToCharacter()
    { if (_goalDone_PTE) { return "X"; } 
        /*else*/ return " "; }

    override public string ToString()
    {
        return $"[{BoolToCharacter()}] {_name_PTE} ({_description_PTE})";
    }
}