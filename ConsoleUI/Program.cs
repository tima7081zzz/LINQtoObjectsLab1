using ConsoleApp1;
using Core.Infrastructure.Controllers;
using Core.Infrastructure.Interfaces.Enums;

namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new ControllerBuilder();

            controller.SetView(new UI {_color = ConsoleColor.Blue})
                .SetDefaultData()
                .Build().GetAllProfessorsWorksItems("Professor1");

            controller.SetView(new UI{_color = ConsoleColor.Green})
                .Build().GetAllProfessorNames();

            controller.SetView(new UI{_color = ConsoleColor.Magenta})
                .Build().GetAllStudentsDates();

            controller.SetView(new UI{_color = ConsoleColor.DarkBlue})
                .Build().GetAllWorkItems();

            controller.SetView(new UI{_color = ConsoleColor.DarkRed})
                .Build().GetAllPassedStudentsNames();

            controller.SetView(new UI{_color = ConsoleColor.Yellow})
                .Build().GetAllWorkMarksFromGroup(Group.IS02);

            controller.SetView(new UI{_color = ConsoleColor.DarkMagenta})
                .Build().GetGroupWithHighestWorkMark();

            controller.SetView(new UI{_color = ConsoleColor.DarkYellow})
                .Build().GetProfessorPositionByStudentName("Student1");

            controller.SetView(new UI{_color = ConsoleColor.White})
                .Build().GetAllProfessorsNamesWithFailedStudents();

            controller.SetView(new UI{_color = ConsoleColor.Green})
                .Build().GetAllWorksMarksByProfessorName("Professor1");

            controller.SetView(new UI{_color = ConsoleColor.Cyan})
                .Build().GetAllWorksItemsWhoseStudentOlderOfYear(2016);

            controller.SetView(new UI {_color = ConsoleColor.Blue})
                .SetDefaultData()
                .Build().GetAllProfessorsWorksItems("Professor1");

            controller.SetView(new UI{_color = ConsoleColor.Red})
                .Build().GetAllWorksMarksWhoseStudentProfessorIsAssociate();

            controller.SetView(new UI{_color = ConsoleColor.DarkCyan})
                .Build().GetDateOfTheOldestStudentWithAssistantProfessor();

            Console.ReadLine();
        }
    }
}