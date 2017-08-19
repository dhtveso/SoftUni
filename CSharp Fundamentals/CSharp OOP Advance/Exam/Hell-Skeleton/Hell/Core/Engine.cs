using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private IInputReader reader;
    private IOutputWriter writer;
    private IManager manager;

    public Engine(IInputReader reader, IOutputWriter writer, IManager manager)
    {
        this.reader = reader;
        this.writer = writer;
        this.manager = manager;
    }

    public void Run()
    {
        bool isRunning = true;

        while (isRunning)
        {
            string inputLine = this.reader.ReadLine();
            List<string> arguments = this.parseInput(inputLine);
            this.writer.WriteLine(this.processInput(arguments));
            isRunning = !this.ShouldEnd(inputLine);
        }
    }

    private List<string> parseInput(string input)
    {
        return input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
    }

    private string processInput(List<string> arguments)
    {
        string command = arguments[0];
        arguments.RemoveAt(0);

        Type commandType = Type.GetType(command + "Command");
        var constructor = commandType.GetConstructor(new Type[] { typeof(IList<string>), typeof(HeroManager) });
        AbstractCommand cmd = (AbstractCommand)constructor.Invoke(new object[] { arguments, this.manager });
        return cmd.Execute();
    }

    private bool ShouldEnd(string inputLine)
    {
        return inputLine.Equals("Quit");
    }
}