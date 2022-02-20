using System;
using System.Collections.Generic;
using Core.Infrastructure.Interfaces.Enums;

namespace Core.Infrastructure.Interfaces
{
    public interface ICommand
    {
        CommandRequestModel _data { get; set; }
        void GenerateDefaultData();
        List<string> GetAllProfessorsWorksItems();
        List<int> GetAllWorksMarksWhoseStudentProfessorIsAssociate();
        List<string> GetAllPassedStudentsNames();
        Group GetGroupWithHighestWorkMark();
        DateTime GetDateOfTheOldestStudentWithAssistantProfessor();
        List<string> GetAllWorksItemsWhoseStudentOlderOfYear(int year);
        List<string> GetAllProfessorsWorksItems(string professorName);
        List<int> GetAllWorkMarksFromGroup(Group group);
        Position GetProfessorPositionByStudentName(string name);
        List<int> GetAllWorksMarksByProfessorName(string name);
        List<string> GetAllWorksItemsByStudentName(string name);
        List<DateTime> GetAllStudentsDates();
        List<string> GetAllWorkItems();
        List<string> GetAllProfessorNames();
        List<string> GetAllProfessorsNamesWithFailedStudents();
    }
}
