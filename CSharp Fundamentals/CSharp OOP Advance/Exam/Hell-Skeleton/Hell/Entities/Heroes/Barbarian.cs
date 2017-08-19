using System;

public class Barbarian : AbstractHero
{
    const long StrengthBarbarian = 90;
    const long AgilityBarbarian = 25;
    const long IntelligenceBarbarian = 10;
    const long HitPointsBarbarian = 350;
    const long DamageBarbarian = 150;

    public Barbarian(string name)
        : base(name, StrengthBarbarian, AgilityBarbarian, IntelligenceBarbarian, HitPointsBarbarian, DamageBarbarian)
    {
    }
}
