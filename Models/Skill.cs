using System.ComponentModel.DataAnnotations;
namespace DnDCharacterSheet.Models
{
    public enum Skill
    {
        [Display(Name = "Acrobazia")] Acrobatics,
    [Display(Name = "Addestrare Animali")] AnimalHandling,
    [Display(Name = "Arcano")] Arcana,
    [Display(Name = "Atletica")] Athletics,
    [Display(Name = "Inganno")] Deception,
    [Display(Name = "Storia")] History,
    [Display(Name = "Intuizione")] Insight,
    [Display(Name = "Intimidazione")] Intimidation,
    [Display(Name = "Indagare")] Investigation,
    [Display(Name = "Medicina")] Medicine,
    [Display(Name = "Natura")] Nature,
    [Display(Name = "Percezione")] Perception,
    [Display(Name = "Intrattenere")] Performance,
    [Display(Name = "Persuasione")] Persuasion,
    [Display(Name = "Religione")] Religion,
    [Display(Name = "Rapidità di Mano")] SleightOfHand,
    [Display(Name = "Furtività")] Stealth,
    [Display(Name = "Sopravvivenza")] Survival
    }
}