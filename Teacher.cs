using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegister
{
    internal class Teacher : Person
    {
        string Subject { get; set; }
        public Teacher(string subject, string firstName, string lastName, string role, int personalNumber) : base(firstName, lastName, role, personalNumber)
        {
            Subject = subject;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{GetType().Name} - {FirstName} - {LastName} - {Role} - {PersonalNumber} - {Subject}");
        }
    }
}
