using System;

public class CommonItem : AbstractItem
{
    public CommonItem(string name, long strengthBonus, long agilityBonus, long intelligenceBonus, long hitpointsBonus, long damageBonus)
        : base(name, strengthBonus, agilityBonus, intelligenceBonus, hitpointsBonus, damageBonus)
    {
    }
}
