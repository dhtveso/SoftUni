using System;
using System.Collections.Generic;

public class RecipeItem : AbstractItem, IRecipe
{
    public RecipeItem(string name, long strengthBonus, long agilityBonus, long intelligenceBonus, long hitpointsBonus, long damageBonus, IList<string> requiredItems)
        : base(name, strengthBonus, agilityBonus, intelligenceBonus, hitpointsBonus, damageBonus)
    {
        this.RequiredItems = requiredItems;
    }

    public IList<string> RequiredItems { get; private set; }
}
