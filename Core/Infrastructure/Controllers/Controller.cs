using System.Collections;
using System.Text;
using Core.Infrastructure.Interfaces.Enums;

namespace Core.Infrastructure.Controllers
{
    public class Controller : BaseController
    {
        public void GetAllProfessorsWorksItems()
        {
            View.Result = new CommandResponseModel
            {
                Result = CommandResponseStringConvert(CommandModel.GetAllProfessorsWorksItems()),
                MethodName = System.Reflection.MethodBase.GetCurrentMethod()?.Name
            };
        }
        public void GetAllWorksMarksWhoseStudentProfessorIsAssociate()
        {
            View.Result = new CommandResponseModel
            {
                Result = CommandResponseStringConvert(CommandModel.GetAllWorksMarksWhoseStudentProfessorIsAssociate()),
                MethodName = System.Reflection.MethodBase.GetCurrentMethod()?.Name
            };
        }
        public void GetAllPassedStudentsNames()
        {
            View.Result = new CommandResponseModel
            {
                Result = CommandResponseStringConvert(CommandModel.GetAllPassedStudentsNames()),
                MethodName = System.Reflection.MethodBase.GetCurrentMethod()?.Name
            };
        }
        public void GetGroupWithHighestWorkMark()
        {
            View.Result = new CommandResponseModel
            {
                Result = CommandResponseStringConvert(CommandModel.GetGroupWithHighestWorkMark()),
                MethodName = System.Reflection.MethodBase.GetCurrentMethod()?.Name
            };
        }
        public void GetDateOfTheOldestStudentWithAssistantProfessor()
        {
            View.Result = new CommandResponseModel
            {
                Result = CommandResponseStringConvert(CommandModel.GetDateOfTheOldestStudentWithAssistantProfessor()),
                MethodName = System.Reflection.MethodBase.GetCurrentMethod()?.Name
            };
        }
        public void GetAllWorksItemsWhoseStudentOlderOfYear(int year)
        {
            View.Result = new CommandResponseModel
            {
                Result = CommandResponseStringConvert(CommandModel.GetAllWorksItemsWhoseStudentOlderOfYear(year)),
                MethodName = System.Reflection.MethodBase.GetCurrentMethod()?.Name
            };
        }
        public void GetAllProfessorsWorksItems(string name)
        {
            View.Result = new CommandResponseModel
            {
                Result = CommandResponseStringConvert(CommandModel.GetAllProfessorsWorksItems(name)),
                MethodName = System.Reflection.MethodBase.GetCurrentMethod()?.Name
            };
        }
        public void GetAllWorkMarksFromGroup(Group group)
        {
            View.Result = new CommandResponseModel
            {
                Result = CommandResponseStringConvert(CommandModel.GetAllWorkMarksFromGroup(group)),
                MethodName = System.Reflection.MethodBase.GetCurrentMethod()?.Name
            };
        }
        public void GetProfessorPositionByStudentName(string name)
        {
            View.Result = new CommandResponseModel
            {
                Result = CommandResponseStringConvert(CommandModel.GetProfessorPositionByStudentName(name)),
                MethodName = System.Reflection.MethodBase.GetCurrentMethod()?.Name
            };
        }
        public void GetAllWorksMarksByProfessorName(string name)
        {
            View.Result = new CommandResponseModel
            {
                Result = CommandResponseStringConvert(CommandModel.GetAllWorksMarksByProfessorName(name)),
                MethodName = System.Reflection.MethodBase.GetCurrentMethod()?.Name
            };
        }
        public void GetAllStudentsDates()
        {
            View.Result = new CommandResponseModel
            {
                Result = CommandResponseStringConvert(CommandModel.GetAllStudentsDates()),
                MethodName = System.Reflection.MethodBase.GetCurrentMethod()?.Name
            };
        }
        public void GetAllWorkItems()
        {
            View.Result = new CommandResponseModel
            {
                Result = CommandResponseStringConvert(CommandModel.GetAllWorkItems()),
                MethodName = System.Reflection.MethodBase.GetCurrentMethod()?.Name
            };
        }
        public void GetAllProfessorNames()
        {
            View.Result = new CommandResponseModel
            {
                Result = CommandResponseStringConvert(CommandModel.GetAllProfessorNames()),
                MethodName = System.Reflection.MethodBase.GetCurrentMethod()?.Name
            };
        }
        public void GetAllProfessorsNamesWithFailedStudents()
        {
            View.Result = new CommandResponseModel
            {
                Result = CommandResponseStringConvert(CommandModel.GetAllProfessorsNamesWithFailedStudents()),
                MethodName = System.Reflection.MethodBase.GetCurrentMethod()?.Name
            };
        }

        #region private methods
        private static string CommandResponseStringConvert<T>(T model)
        {
            if (model == null) return string.Empty;

            var result = new StringBuilder();
            if (model is ICollection collection)
            {
                foreach (var element in collection)
                {
                    result.AppendLine(element.ToString());
                }
            }
            else
            {
                result.AppendLine(model.ToString());
            }

            return result.ToString();
        }
        #endregion
    }
}