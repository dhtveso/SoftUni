using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

[TestFixture]
public class HeroInventoryTests
{
    private HeroInventory sud;

    [SetUp]
    public void TestInit()
    {
        this.sud = new HeroInventory();
    }

    [Test]
    public void AddCommonItem()
    {
        CommonItem item = new CommonItem("Item", 1, 2, 3, 4, 5);

        this.sud.AddCommonItem(item);
        Type clazz = typeof(HeroInventory);
        var field = clazz.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
            .FirstOrDefault(f => f.GetCustomAttribute(typeof(ItemAttribute)) != null);
        var collection = (Dictionary<string, IItem>)field.GetValue(this.sud);

        Assert.AreEqual(1, collection.Count);
    }

    [Test]
    public void AddRecipeItem()
    {
        RecipeItem item = new RecipeItem("Item", 1, 2, 3, 4, 5, new List<string>());

        this.sud.AddRecipeItem(item);
        Type clazz = typeof(HeroInventory);
        var field = clazz.GetField("recipeItems", BindingFlags.Instance | BindingFlags.NonPublic);
        var collection = (Dictionary<string, IRecipe>)field.GetValue(this.sud);

        Assert.AreEqual(1, collection.Count);
    }

    [Test]
    public void CombineItemFromRecipe()
    {
        RecipeItem recipe = new RecipeItem("Item", 1, 2, 3, 4, 5, new List<string>() { "Axe", "Tochilka"});
        var commonItems = new Dictionary<string, IItem>();
        IItem item1 = new CommonItem("Axe", 1,2,3,4,5);
        IItem item2 = new CommonItem("Tochilka", 1, 2, 3, 4, 5);

        commonItems["Axe"] = item1;
        commonItems["Tochilka"] = item2;
        for (int i = 0; i < recipe.RequiredItems.Count; i++)
        {
            string item = recipe.RequiredItems[i];
            commonItems.Remove(item);
        }
        IItem newItem = new CommonItem(recipe.Name,
            recipe.StrengthBonus,
            recipe.AgilityBonus,
            recipe.IntelligenceBonus,
            recipe.HitPointsBonus,
            recipe.DamageBonus);
        commonItems.Add(newItem.Name, newItem);

        Assert.AreEqual(newItem.Name, recipe.Name);
    }

    [Test]
    public void StrengthBonusFromItems()
    {
        CommonItem item = new CommonItem("Item", 1, 2, 3, 4, 5);

        this.sud.AddCommonItem(item);

        Assert.AreEqual(1, this.sud.TotalStrengthBonus);
    }

    [Test]
    public void AgilityBonusFromItems()
    {
        CommonItem item = new CommonItem("Item", 1, 2, 3, 4, 5);

        this.sud.AddCommonItem(item);

        Assert.AreEqual(2, this.sud.TotalAgilityBonus);
    }

    [Test]
    public void IntelligenceBonusFromItems()
    {
        CommonItem item = new CommonItem("Item", 1, 2, 3, 4, 5);

        this.sud.AddCommonItem(item);

        Assert.AreEqual(3, this.sud.TotalIntelligenceBonus);
    }

    [Test]
    public void HitPointsBonusFromItems()
    {
        CommonItem item = new CommonItem("Item", 1, 2, 3, 4, 5);

        this.sud.AddCommonItem(item);

        Assert.AreEqual(4, this.sud.TotalHitPointsBonus);
    }

    [Test]
    public void DamageBonusFromItems()
    {
        CommonItem item = new CommonItem("Item", 1, 2, 3, 4, 5);

        this.sud.AddCommonItem(item);

        Assert.AreEqual(5, this.sud.TotalDamageBonus);
    }
}
