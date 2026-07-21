/* References and Notes
 * 1. https://byui-cse.github.io/cse210-course-2023/unit05/prepare.html
 */
namespace Develop05;


public class Eternal : Goal
{
    // Constructor
    public Eternal(string name, string description, int points, bool goalDone = false)
        : base(name, description, points, goalDone) { Set_goalType_PTE('E'); }    // E for Eternal
    
    // Methods
    public override void IsCompleted()
    { GivePoints(); }
    
    private protected override string ToCsvOutputFormat()
    { return $"{Get_name_PTE()},{Get_description_PTE()},{Get_points_PTE()}"; }
    
    public override string ToString()
    { return $"[{BoolToCharacter()}] {Get_points_PTE()} ({Get_description_PTE()})"; }
}