using ClassLibrary1;

string input = "";
List<Person> people = new List<Person>();
List<Student> students = new List<Student>();
List<Teacher> teachers = new List<Teacher>();
List<University> universities = new List<University>();

while (input != "6")
{
    Console.WriteLine("Hello! Would you like to...");
    Console.WriteLine("1. Add a student, teacher, or university.");
    Console.WriteLine("2. List student information.");
    Console.WriteLine("3. List teachers information.");
    Console.WriteLine("4. List all people's names.");
    Console.WriteLine("5. Add a year of work for a teacher.");
    Console.WriteLine("6. List all universities.");
    Console.WriteLine("7. Exit.");

    input = Console.ReadLine();
    switch (input)
    {
        case "1":
            Console.WriteLine("Would you like to add a...");
            Console.WriteLine("1. Student");
            Console.WriteLine("2. Teacher");
            Console.WriteLine("3. University");
            string addition = Console.ReadLine();
            switch (addition)
            {
                case "1":
                    Console.WriteLine("What is the first name of the student?");
                    string sfName = Console.ReadLine();
                    Console.WriteLine("What is the last name of the student");
                    string slname = Console.ReadLine();
                    Console.WriteLine("How old is the student?");
                    int sage = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the student's email?");
                    string semail = Console.ReadLine();
                    Console.WriteLine("What is the student's major?");
                    string major = Console.ReadLine();
                    Student newStudent = new Student(sfName, slname, sage, semail, major);
                    students.Add(newStudent);
                    people.Add(newStudent);
                    break;
                case "2":
                    Console.WriteLine("What is the first name of the teacher?");
                    string tfName = Console.ReadLine();
                    Console.WriteLine("What is the last name of the teacher");
                    string tlname = Console.ReadLine();
                    Console.WriteLine("How old is the teacher?");
                    int tage = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the teacher's email?");
                    string temail = Console.ReadLine();
                    Console.WriteLine("What is the teacher's title?");
                    string title = Console.ReadLine();
                    Console.WriteLine("How many years has the teacher worked?");
                    int yearsworked = Convert.ToInt32(Console.ReadLine());
                    Teacher newTeacher = new Teacher(tfName, tlname, tage, temail, title, yearsworked);
                    teachers.Add(newTeacher);
                    people.Add(newTeacher);
                    break;
                case "3":
                    Console.WriteLine("What is the name of the University?");
                    string UName = Console.ReadLine();
                    Console.WriteLine("How many students are there?");
                    int numofstud = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How many teachers are there?");
                    int numofteach = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the University's accpetance rate");
                    int acceptanceRate = Convert.ToInt32(Console.ReadLine());
                    University newUniversity = new University(UName, numofstud, numofteach, acceptanceRate);
                    universities.Add(newUniversity);
                    break;
                default:
                    break;
            }
            break;
        case "2":
            Console.WriteLine("List all students:");
            foreach (var student in students)
            {
                student.ShowInfo();
            }
            break;
        case "3":
            Console.WriteLine("List all teachers:");
            foreach (var teacher in teachers)
            {
                teacher.ShowInfo();
            }
            break;
        case "4":
            Console.WriteLine("List all people:");
            foreach (var person in people)
            {
                person.listNames();
            }
            break;
        case "5":
            Console.WriteLine("Add a year of work.");
            Console.WriteLine("What is the email of the teacher you want to change?");
            string YearAddEmail = Console.ReadLine();
            foreach (var teacher in teachers)
            {
                if (YearAddEmail == teacher.Email)
                {
                    teacher.addYear();
                }
            }
            break;
        case "6":
            foreach (var university in universities)
            {
                university.ListUniv();
            }
            break;
        default:
            break;
    }
}