/* References and Notes
 * 1. https://byui-cse.github.io/cse210-course-2023/unit05/prepare.html
 */
namespace Develop05;

public class Checklist : Goal
{
    // Attributes
    private int _bonusPoints_PTE;
    private int _currentCount_PTE;
    private int _finalCount_PTE;
    
    // Setters and Getters
    private int Get_bonusPoints_PTE()
    { return _bonusPoints_PTE; }
    private int Get_currentCount_PTE()
    { return _currentCount_PTE; }
    private int Get_finalCount_PTE()
    { return _finalCount_PTE; }
    
    // Constructor
    public Checklist(string name, string description, int points, int bonusPoints, int finalCount)
        : base(name, description, points)
    {
        _currentCount_PTE = 0;
        _bonusPoints_PTE = bonusPoints;
        _finalCount_PTE = finalCount;
    }
    
    // Methods
    public override void IsCompleted()
    {
        if (_currentCount_PTE == _finalCount_PTE)
        { ToggleGoalDone_PTE(); }
        GivePoints();
    }

    protected override int GivePoints()
    {
        if (!Get_goalDone_PTE())
        { return Get_points_PTE(); }
        else
        { return (_bonusPoints_PTE + Get_points_PTE()); }
    }
    
    private protected override string ToCsvOutputFormat()
    {
        return $"{Get_name_PTE()},{Get_description_PTE()},{Get_points_PTE()},{Get_bonusPoints_PTE()},{Get_finalCount_PTE()},{Get_currentCount_PTE()}";
    }
    public override string ToString()
    {
        return $"[{BoolToCharacter()}] {Get_points_PTE()} ({Get_description_PTE()}) -- Currently completed: {Get_currentCount_PTE()}/{Get_finalCount_PTE()}";
    }
}