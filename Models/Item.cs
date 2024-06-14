namespace DnDCharacterSheet.Models{
public class Item
{
   public string Name { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public double Weight { get; set; }
    public int Value { get; set; }
    public string Description { get; set; }

    public Item(string name, int quantity) 
    {
        Name = name;
        Quantity = quantity;
        Weight = 0;
        Value = 0;
        Description = "";
    }
}
}