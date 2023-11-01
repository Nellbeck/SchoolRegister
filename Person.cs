using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegister
{
    internal abstract class Person
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected string Role { get; set; }
        protected int PersonalNumber { get; set; }
        public Person(string firstName, string lastName, string role, int personalNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            PersonalNumber = personalNumber;
        }
        public abstract void PrintInfo();
    }
}
