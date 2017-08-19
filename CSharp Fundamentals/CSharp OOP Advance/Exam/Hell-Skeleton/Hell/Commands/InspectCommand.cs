using System;
using System.Collections.Generic;

public class InspectCommand : AbstractCommand
{
    public InspectCommand(IList<string> args, HeroManager manager) : base(args, manager)
    {
    }

    public override string Execute()
    {
        return Manager.Inspect(this.Args);
    }
}
