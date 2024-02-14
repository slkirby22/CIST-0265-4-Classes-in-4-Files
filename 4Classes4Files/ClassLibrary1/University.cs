using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class University
    {
        public string Name { get; set; }
        public int NumOfStudents { get; set; }
        public int NumOfTeachers { get; set; }
        public int AcceptanceRate { get; set; }

        public University(string name, int numofStudents, int numofTeachers, int acceptanceRate)
        {
            Name = name;
            NumOfStudents = numofStudents;
            NumOfTeachers = numofTeachers;
            AcceptanceRate = acceptanceRate;
        }

        public void ListUniv()
        {
            Console.WriteLine($"University Name: {Name}, Number of Students: {NumOfStudents}, Number of Teachers: {NumOfTeachers}, Acceptance Rate: {AcceptanceRate}");
        }
    }
}
