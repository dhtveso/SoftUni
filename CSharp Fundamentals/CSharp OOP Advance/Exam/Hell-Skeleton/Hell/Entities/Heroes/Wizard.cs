using System;

public class Wizard : AbstractHero
{
    const long StrengthWizard = 25;
    const long AgilityWizard = 25;
    const long IntelligenceWizard = 100;
    const long HitPointsWizard = 100;
    const long DamageWizard = 250;

    public Wizard(string name)
        : base(name, StrengthWizard, AgilityWizard, IntelligenceWizard,HitPointsWizard, DamageWizard)
    {
    }
}
