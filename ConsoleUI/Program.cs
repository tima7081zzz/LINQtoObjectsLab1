using System;
using ConsoleApp1;
using Core.Infrastructure.Controllers;
using Core.Infrastructure.Interfaces;
using Core.Infrastructure.Interfaces.Enums;
using Core.Models;

namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var profs = new Professor[]
            {
                new Professor
                {
                    FullName = "giga",
                    Position = Position.Assistant,
                }
            };

            foreach (var i in profs)
            {
                i.Students = new Student[]
                {
                    new Student
                    {
                        FullName = "gogo",
                        Group = Group.IS03,
                        DateOfBirth = DateTime.Now,
                        AvgMark = 60,
                        Work = null,
                        Professor = i
                    }
                };
            }

            var controller = new ControllerBuilder()
                .SetView(new UI())
                .SetCommandModel(new CommandModel(new GetAllPassedStudents()));

            controller.Build().Click();
            Console.ReadLine();
        }
    }
}