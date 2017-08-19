using System;
using System.Collections.Generic;

public class HeroCommand : AbstractCommand
{
    public HeroCommand(IList<string> args, HeroManager manager)
        : base(args, manager)
    {
    }

    public override string Execute()
    {
        return Manager.AddHero(this.Args);
    }
}
