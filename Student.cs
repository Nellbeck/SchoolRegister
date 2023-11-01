using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegister
{
    internal class Student : Person
    {
        string Course { get; set; }
        public Student(string course, string firstName, string lastName, string role, int personalNumber) : base(firstName, lastName, role, personalNumber)
        {
            Course = course;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{GetType().Name} - {FirstName} - {LastName} - {Role} - {PersonalNumber} - {Course}");
        }
    }
}
