using System.Collections.Generic;

public class QuitCommand : AbstractCommand
{
    public QuitCommand(IList<string> args, HeroManager manager)
        : base(args, manager)
    {
    }

    public override string Execute()
    {
        return base.Manager.Quit(this.Args);
    }
}