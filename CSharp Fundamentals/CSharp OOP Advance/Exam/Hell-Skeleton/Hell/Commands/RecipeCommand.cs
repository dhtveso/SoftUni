using System;
using System.Collections.Generic;

public class RecipeCommand : AbstractCommand
{
    public RecipeCommand(IList<string> args, HeroManager manager) : base(args, manager)
    {
    }

    public override string Execute()
    {
        return base.Manager.AddRecipe(this.Args);
    }
}
