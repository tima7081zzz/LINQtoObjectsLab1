using System.Collections.Generic;
using Core.Models;

namespace Core.View
{
    public interface IView
    {
        IEnumerable<Student> Students { get; set; }
        IEnumerable<Work> Works { get; set; }
        IEnumerable<Professor> Professors { get; set; }
        string Result { get; set; }
    }

    public interface IConsoleView : IView
    {
        void WelcomeAction(string msg);
    }
}