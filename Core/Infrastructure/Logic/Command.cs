using System;
using System.Collections.Generic;
using System.Linq;
using Core.Infrastructure.Interfaces;
using Core.Infrastructure.Interfaces.Enums;
using Core.Models;

namespace Core.Infrastructure.Logic
{
    internal class Command : ICommand
    {
        public CommandRequestModel _data { get; set; }

        public List<int> GetAllWorksMarksWhoseStudentProfessorIsAssociate()
        {
            return _data.Works.Where(x => x.Student.Professor.Position == Position.Associate).Select(x => x.Mark).ToList();
        }

        public List<string> GetAllPassedStudentsNames()
        {
            return _data.Students.Where(s => s.Work.Mark > 60).Select(x => x.FullName).ToList();
        }

        public Group GetGroupWithHighestWorkMark()
        {
            return _data.Works.OrderBy(x => x.Mark).FirstOrDefault()!.Student.Group;
        }

        public DateTime GetDateOfTheOldestStudentWithAssistantProfessor()
        {
            return _data.Students.Where(x => x.Professor.Position == Position.Assistant).OrderBy(x => x.DateOfBirth).FirstOrDefault()!.DateOfBirth;
        }

        public List<string> GetAllWorksItemsWhoseStudentOlderOfYear(int year)
        {
            return _data.Works.Where(x => x.Student.DateOfBirth.Year < year).Select(x => x.Item).ToList();
        }

        public List<string> GetAllProfessorsWorksItems(string professorName)
        {
            return _data.Professors.
                FirstOrDefault(x => x.FullName.Contains(professorName))
                ?.Students
                .Select(x => x.Work.Item)?.ToList();
        }

        public List<int> GetAllWorkMarksFromGroup(Group group)
        {
            return _data.Students
                .GroupBy(x => x.Group)
                .Where(x => x.Key == group)
                .SelectMany(x => x).ToList()
                .Select(x => x.Work.Mark).ToList();
        }

        public Position GetProfessorPositionByStudentName(string name)
        {
            return (from s in _data.Students
                where s.FullName == name
                select s.Professor.Position).FirstOrDefault();
        }

        public List<int> GetAllWorksMarksByProfessorName(string name)
        {
            return (from p in _data.Professors
                where p.FullName == name
                join w in _data.Works on p.FullName equals w.Student.Professor.FullName
                select w.Mark).ToList();
        }

        public List<string> GetAllWorksItemsByStudentName(string name)
        {
            return (from s in _data.Students
                where s.FullName == name
                select s.Work.Item).ToList();
        }

        public List<DateTime> GetAllStudentsDates()
        {
            return (from s in _data.Students
                select s.DateOfBirth).ToList();
        }

        public List<string> GetAllWorkItems()
        {
            return (from w in _data.Works
                select w.Item).ToList();
        }

        public List<string> GetAllProfessorNames()
        {
            return (from p in _data.Professors
                select p.FullName).ToList();
        }

        public List<string> GetAllProfessorsNamesWithFailedStudents()
        {
            return (from s in _data.Students
                where s.Work.Mark < 60
                select s.Professor.FullName).ToList();
        }

        public void GenerateDefaultData()
        {
            var result = new CommandRequestModel();

            var professor1 = new Professor
            {
                FullName = "Professor1",
                Position = Position.Assistant,
                Students = new List<Student>
                {
                    new Student
                    {
                        FullName = "Student1",
                        Group = Group.IS03,
                        DateOfBirth = new DateTime(2011, 7, 20),
                        AvgMark = 60,
                        Work = new Work
                        {
                            Item = "Computer Science",
                            Mark = 90,
                        }
                    },
                    new Student
                    {
                        FullName = "Student2",
                        Group = Group.IS01,
                        DateOfBirth = new DateTime(2015, 7, 20),
                        AvgMark = 60,
                        Work = new Work
                        {
                            Item = "English Literature",
                            Mark = 80,
                        }
                    }
                }
            };
            var professor2 = new Professor
            {
                FullName = "Professor2",
                Position = Position.Assistant,
                Students = new List<Student>
                {
                    new Student
                    {
                        FullName = "Student3",
                        Group = Group.IS03,
                        DateOfBirth = new DateTime(2014, 7, 20),
                        AvgMark = 60,
                        Work = new Work
                        {
                            Item = "Economics",
                            Mark = 95,
                        }
                    }
                }
            };
            var professor3 = new Professor
            {
                FullName = "Professor3",
                Position = Position.Assistant,
                Students = new List<Student>
                {
                    new Student
                    {
                        FullName = "Student4",
                        Group = Group.IS02,
                        DateOfBirth = new DateTime(2017, 7, 20),
                        AvgMark = 60,
                        Work = new Work
                        {
                            Item = "Biology",
                            Mark = 77,
                        }
                    }
                }
            };

            result.Professors = new List<Professor> {professor1, professor2, professor3};
            var students = new List<Student>();
            var works = new List<Work>();

            foreach (var professor in result.Professors)
            {
                foreach (var student in professor.Students)
                {
                    student.Professor = professor;
                    student.Work.Student = student;
                    students.Add(student);
                    works.Add(student.Work);
                }
            }

            result.Students = students;
            result.Works = works;

            _data = result;
        }
    }
}