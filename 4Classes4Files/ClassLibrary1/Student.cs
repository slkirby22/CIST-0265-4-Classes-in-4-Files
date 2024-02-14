using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student : Person
    {
        public string Major { get; set; }
        public Student(string firstName, string lastName, int age, string email, string major) : base(firstName, lastName, age, email)
        {
            Major = major;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}, Major: {Major}, Email: {Email}");
        }
    }
}
