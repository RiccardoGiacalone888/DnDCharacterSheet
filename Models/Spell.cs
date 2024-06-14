namespace DnDCharacterSheet.Models{
public class Spell
{
    public string Name { get; set; } = string.Empty;
    public int Level { get; set; }
    public string School { get; set; } = string.Empty;
    public string CastingTime { get; set; } = string.Empty;
    public string Range { get; set; } = string.Empty;
    public string Components { get; set; } = string.Empty;
    public string Duration { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public Spell(string name, string description)
    {
        Name = name;
        Description = description;
    }
}
}
