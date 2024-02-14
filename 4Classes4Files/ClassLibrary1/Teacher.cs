using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Teacher : Person
    {
        public string Title { get; set; }
        public int YearsWorked{ get; set; }
        public Teacher(string firstName, string lastName, int age, string email, string title, int yearsWorked) : base(firstName, lastName, age, email)
        {
            Title = title;
            YearsWorked = yearsWorked;
        }

        public void addYear()
        {
            YearsWorked++;
            Console.WriteLine($"I have now worked {YearsWorked} years.");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Title and Name: {Title} {FirstName} {LastName}, Years Worked: {YearsWorked}, Email: {Email}");
        }
    }
}