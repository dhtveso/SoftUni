using System;
using System.Collections.Generic;

public class ItemCommand : AbstractCommand
{
    public ItemCommand(IList<string> args, HeroManager manager) : base(args, manager)
    {
    }

    public override string Execute()
    {
        return this.Manager.AddItemToHero(this.Args);
    }
}
