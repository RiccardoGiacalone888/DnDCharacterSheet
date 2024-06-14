using System.ComponentModel.DataAnnotations;
namespace DnDCharacterSheet.Models
{
   
    public enum CharacterClass
{
    [Display(Name = "Barbaro")] Barbarian,
    [Display(Name = "Bardo")] Bard,
    [Display(Name = "Chierico")] Cleric,
    [Display(Name = "Druido")] Druid,
    [Display(Name = "Guerriero")] Fighter,
    [Display(Name = "Monaco")] Monk,
    [Display(Name = "Paladino")] Paladin,
    [Display(Name = "Ranger")] Ranger,
    [Display(Name = "Ladro")] Rogue,
    [Display(Name = "Stregone")] Sorcerer,
    [Display(Name = "Warlock")] Warlock,
    [Display(Name = "Mago")] Wizard
}

}