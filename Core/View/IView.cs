using System;
using Core.Infrastructure;
using Core.Models;

namespace Core.View
{
    public interface IView
    {
        ConsoleColor _color { set; }
        CommandResponseModel Result { set; }
    }

    public interface IConsoleView : IView
    {
        void WelcomeAction(string msg);
    }
}