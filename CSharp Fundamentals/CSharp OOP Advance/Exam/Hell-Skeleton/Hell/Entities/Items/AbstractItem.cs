using System;
using System.Text;

public abstract class AbstractItem : IItem
{
    public AbstractItem(string name, long strengthBonus, long agilityBonus, long intelligenceBonus, long hitpointsBonus, long damageBonus)
    {
        this.Name = name;
        this.StrengthBonus = strengthBonus;
        this.AgilityBonus = agilityBonus;
        this.IntelligenceBonus = intelligenceBonus;
        this.HitPointsBonus = hitpointsBonus;
        this.DamageBonus = damageBonus;
    }

    public long AgilityBonus { get; }

    public long DamageBonus { get; }

    public long HitPointsBonus { get; }

    public long IntelligenceBonus { get; }
   
    public string Name { get; }
    
    public long StrengthBonus { get; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"###Item: {this.Name}");
        sb.AppendLine($"###+{this.StrengthBonus} Strength");
        sb.AppendLine($"###+{this.AgilityBonus} Agility");
        sb.AppendLine($"###+{this.IntelligenceBonus} Intelligence");
        sb.AppendLine($"###+{this.HitPointsBonus} HitPoints");
        sb.AppendLine($"###+{this.DamageBonus} Damage");

        return sb.ToString().Trim();
    }

}
