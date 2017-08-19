using System;

public class Assassin : AbstractHero
{
    const long StrengthAssasin = 25;
    const long AgilityAssasin = 100;
    const long IntelligenceAssasin = 15;
    const long HitPointsAssasin = 150;
    const long DamageAssasin = 300;

    public Assassin(string name)
        : base(name, StrengthAssasin, AgilityAssasin, IntelligenceAssasin, HitPointsAssasin, DamageAssasin)
    {
    }
}
