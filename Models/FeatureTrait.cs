using System.Runtime.CompilerServices;

namespace DnDCharacterSheet.Models{
public class FeatureTrait
{
    public string Name { get; set; }
    public string Description { get; set; }

    public FeatureTrait(string name, string description)
    {
        Name = string.Empty;
        Description = string.Empty;
    }
}
}
