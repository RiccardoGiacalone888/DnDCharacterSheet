using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DnDCharacterSheet.Models
{
    public class Character
    {
        // Informazioni di base
        [Required(ErrorMessage = "Il nome è obbligatorio.")]
        public string Name { get; set; } = "";

        [Range(1, 20, ErrorMessage = "Il livello deve essere compreso tra 1 e 20.")]
        public int Level { get; set; } = 1;

        [Required(ErrorMessage = "La razza è obbligatoria.")]
        public Race Race { get; set; }

        [Required(ErrorMessage = "La classe è obbligatoria.")]
        public CharacterClass CharacterClass { get; set; }

        public string CharacterSubclass { get; set; } = "";

        [Required(ErrorMessage = "L'allineamento è obbligatorio.")]
        public string Alignment { get; set; } = "";

        public string Background { get; set; } = "";

        public int ExperiencePoints { get; set; }

        public bool HasInspiration { get; set; }

        // Statistiche
        public int ProficiencyBonus => (int)Math.Floor((Level - 1) / 4.0) + 2;
        public Dictionary<AbilityScoreType, int> AbilityScores { get; set; } = new();
        public Dictionary<AbilityScoreType, SavingThrowInfo> SavingThrows { get; set; } = new();
        public Dictionary<Skill, SkillInfo> Skills { get; set; } = new();
        public CombatStats CombatStats { get; set; } = new();

        // Altre sezioni
        public List<Item> Inventory { get; set; } = new();
        public List<Spell> Spells { get; set; } = new();
        public List<FeatureTrait> FeaturesTraits { get; set; } = new();
        public string BackgroundDescription { get; set; } = "";
        public string Notes { get; set; } = "";

        // Costruttore
        public Character()
        {
            // Inizializza le abilità
            foreach (AbilityScoreType score in Enum.GetValues(typeof(AbilityScoreType)))
            {
                AbilityScores[score] = 10;
                SavingThrows[score] = new SavingThrowInfo { Score = AbilityScores[score], IsProficient = false };
            }

            // Inizializza le skills
            foreach (Skill skill in Enum.GetValues(typeof(Skill)))
            {
                Skills[skill] = new SkillInfo { AbilityScore = GetAbilityScoreForSkill(skill), IsProficient = false };
            }
        }

        // Metodi
        public int GetAbilityModifier(AbilityScoreType ability)
        {
            return (AbilityScores[ability] - 10) / 2;
        }

        private AbilityScoreType GetAbilityScoreForSkill(Skill skill)
        {
            switch (skill)
            {
                case Skill.Acrobatics:
                case Skill.SleightOfHand:
                case Skill.Stealth:
                    return AbilityScoreType.Dexterity;
                case Skill.Athletics:
                    return AbilityScoreType.Strength;
                case Skill.AnimalHandling:
                case Skill.Insight:
                case Skill.Medicine:
                case Skill.Perception:
                case Skill.Survival:
                    return AbilityScoreType.Wisdom;
                case Skill.Arcana:
                case Skill.History:
                case Skill.Investigation:
                case Skill.Nature:
                case Skill.Religion:
                    return AbilityScoreType.Intelligence;
                case Skill.Deception:
                case Skill.Intimidation:
                case Skill.Performance:
                case Skill.Persuasion:
                    return AbilityScoreType.Charisma;
                default:
                    throw new ArgumentException("Skill non valida: " + skill);
            }
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new JsonStringEnumConverter() }
            });
        }

        public static Character FromJson(string json)
        {
            return JsonSerializer.Deserialize<Character>(json, new JsonSerializerOptions
            {
                Converters = { new JsonStringEnumConverter() }
            });
        }
    }
}