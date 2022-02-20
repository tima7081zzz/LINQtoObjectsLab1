using Core.Infrastructure;
using Core.View;

namespace ConsoleApp1;

using static System.Console;
public class UI : IConsoleView
{
    public ConsoleColor _color { get; set; }
    public CommandResponseModel Result
    {
        set
        {
            ForegroundColor = _color;
            WriteLine($"Result of the method {value.MethodName}: \n{value.Result}");
        }
    }
    public void WelcomeAction(string msg) => WriteLine("Hi! It`s Console View");
}