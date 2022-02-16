using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Infrastructure.Interfaces
{
    public interface ICommand
    {
        CommandModelWrapper Result(CommandModelWrapper command);
    }

    public class GetAllProfessorWorks : ICommand
    {
        public CommandModelWrapper Result(CommandModelWrapper command)
        {
            return new CommandModelWrapper
            {
                Work = command.Professors.FirstOrDefault()?.Students.Select(s => s.Work)
            };
        }
    }

    public class GetAllPassedStudents : ICommand
    {
        public CommandModelWrapper Result(CommandModelWrapper command)
        {
            return new CommandModelWrapper
            {
                Students = command.Students.Where(s => s.Work.Mark > 60),
            };
        }
    }
}
