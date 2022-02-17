using Core.Models;
using Core.View;

namespace ConsoleApp1;

public class UI : IView
{
    public UI(IEnumerable<Student> students, IEnumerable<Work> works, IEnumerable<Professor> professors, string result)
    {
        Students = students;
        Works = works;
        Professors = professors;
    }

    public IEnumerable<Student> Students { get; set; }
    public IEnumerable<Work> Works { get; set; }
    public IEnumerable<Professor> Professors { get; set; }
    public string Result { get; set; }
}