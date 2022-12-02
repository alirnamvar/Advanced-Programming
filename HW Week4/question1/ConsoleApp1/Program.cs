using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool finish = false;
            var golestan = new Golestan();

            while (!finish)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                if (command.Length == 0) continue;

                if (command[0] == "register_student")
                {
                    golestan.RegisterStudent(command);
                }
                else if (command[0] == "register_professor")
                {
                    golestan.RegisterProfessor(command);
                }
                else if (command[0] == "make_class")
                {
                    golestan.MakeClass(command);
                }
                else if (command[0] == "add_student")
                {
                    golestan.AddStudent(command);
                }
                else if (command[0] == "add_professor")
                {
                    golestan.AddProfessor(command);
                }
                else if (command[0] == "student_status")
                {
                    golestan.StudentStatus(command);
                }
                else if (command[0] == "professor_status")
                {
                    golestan.ProfessorStatus(command);
                }
                else if (command[0] == "class_status")
                {
                    golestan.ClassStatus(command);
                }
                else if (command[0] == "end")
                {
                    finish = true;
                }
            }
        }
    }
}

class Golestan
{
    public Golestan()
    {
        Classes = new List<Class>();
        Students = new List<Student>();
        Professors = new List<Professor>();
    }
    public void ClassStatus(string[] command)
    {
        var class_ = Classes.Find(c => c.ID == command[1]);        
        if (!IsClassExist(command[1]))
        {
            Console.WriteLine("invalid class");
            return;
        }
        if (class_.ClassProfessor == null)
        {
            Console.Write("None");
        }
        else
        {
            Console.Write($"{class_.ClassProfessor.Name}");
        }
        foreach (var student in class_.Students)
        {
            Console.Write($" {student.Name}");
        }
        Console.WriteLine();
    }
    public void ProfessorStatus(string[] command)
    {
        string identicalNum = command[1];
        if (!IsProfessorExist(identicalNum))
        {
            Console.WriteLine("invalid professor");
            return;
        }
        var prof = Professors.Find(x => x.IdenticalNum == identicalNum);
        Console.Write($"{prof.Name} {prof.Field}");
        foreach (var classesName in prof.NameOfRegisteredClasses)
        {
            Console.Write($" {classesName}");
        }
        Console.WriteLine();
    }
    public void StudentStatus(string[] command)
    {
        string identicalNum = command[1];
        if (!IsStudentExist(identicalNum))
        {
            Console.WriteLine("invalid student");
            return;
        }
        var student = Students.Find(s => s.IdenticalNum == identicalNum);
        Console.Write($"{student.Name} {student.EnteringYear} {student.Field}");
        foreach (var classesName in student.NameOfRegisteredClasses)
        {
            Console.Write($" {classesName}");
        }
        Console.WriteLine();
    }

    public void AddProfessor(string[] command)
    {
        string identicalNum = command[1];
        string classID = command[2];
        if (!IsProfessorExist(identicalNum))
        {
            Console.WriteLine("invalid professor");
            return;
        }
        else if (!IsClassExist(classID))
        {
            Console.WriteLine("invalid class");
            return;
        }
        else if (!IsProfessorFieldMatch(identicalNum, classID))
        {
            Console.WriteLine("professor field is not match");
            return;
        }
        else if (ClassHasProfessor(classID))
        {
            Console.WriteLine("this class has a professor");
            return;
        }
        else
        {
            var prof = Professors.Find(x => x.IdenticalNum == identicalNum);
            var class_ = Classes.Find(c => c.ID == classID);
            class_.ClassProfessor = prof;
            prof.NameOfRegisteredClasses.Add(class_.Name);
            Console.WriteLine("professor added successfully to the class");
        }

    }
    public void AddStudent(string[] command)
    {
        string identicalNum = command[1];
        string classID = command[2];
        if (!IsStudentExist(identicalNum))
        {
            Console.WriteLine("invalid student");
            return;
        }
        else if (!IsClassExist(classID))
        {
            Console.WriteLine("invalid class");
            return;
        }
        else if (!IsStudentFieldMatch(identicalNum, classID))
        {
            Console.WriteLine("student field is not match");
            return;
        }
        else if (IsStudentInClass(identicalNum, classID))
        {
            Console.WriteLine("student is already registered");
            return;
        }
        else
        {
            var student = Students.Find(s => s.IdenticalNum == identicalNum);
            var class_ = Classes.Find(c => c.ID == classID);
            class_.Students.Add(student);
            student.NameOfRegisteredClasses.Add(class_.Name);
            Console.WriteLine("student added successfully to the class");
        }
    }
    private bool HasProfessor(string classID)
    {
        return Classes.Find(c => c.ID == classID).ClassProfessor != null;
    }
    private bool ClassHasProfessor(string classID)
    {
        return Classes.Find(c => c.ID == classID).ClassProfessor != null;
    }
    private bool IsProfessorFieldMatch(string professorIdenticalNum, string classID)
    {
        return Classes.Find(c => c.ID == classID).Field == Professors.Find(s => s.IdenticalNum == professorIdenticalNum).Field;
    }
    private bool IsStudentFieldMatch(string studentIdenticalNum, string classID)
    {
        return Classes.Find(c => c.ID == classID).Field == Students.Find(s => s.IdenticalNum == studentIdenticalNum).Field;
    }
    private bool IsStudentInClass(string studentIdenticalNum, string classID)
    {
        return Classes.Find(c => c.ID == classID).Students.Any(s => s.IdenticalNum == studentIdenticalNum);
    }
    private bool IsClassExist(string classID)
    {
        return Classes.Any(c => c.ID == classID);
    }
    private bool IsStudentExist(string studentIdenticalNum)
    {
        return Students.Any(student => student.IdenticalNum == studentIdenticalNum);
    }
    private bool IsProfessorExist(string professorIdenticalNum)
    {
        return Professors.Any(professor => professor.IdenticalNum == professorIdenticalNum);
    }
    public void MakeClass(string[] command)
    {
        string name = command[1];
        string classID = command[2];
        string field = command[3];
        foreach (var class_ in Classes)
        {
            if (class_.ID == classID)
            {
                Console.WriteLine("this class id previously use");
                return;
            }
        }
        var newClass = new Class(name, classID, field);
        Classes.Add(newClass);
        Console.WriteLine("class added successfully");
    }
    public void RegisterProfessor(string[] command)
    {
        string name = command[1];
        string identicalNum = command[2];
        string field = command[3];
        if (IsIdenticalNumUnique(identicalNum))
        {
            var prof = new Professor(name, identicalNum, field);
            Professors.Add(prof);
            Console.WriteLine("welcome to golestan");
        }
        else
        {
            Console.WriteLine("this identical number previously registered");
        }
    }
    public void RegisterStudent(string[] command)
    {
        string name = command[1];
        string identicalNum = command[2];
        int enteringYear = int.Parse(command[3]);
        string field = command[4];

        if (IsIdenticalNumUnique(identicalNum))
        {
            var student = new Student(name, identicalNum, enteringYear, field);
            Students.Add(student);
            Console.WriteLine("welcome to golestan");
        }
        else
        {
            Console.WriteLine("this identical number previously registered");
        }
    }
    private bool IsIdenticalNumUnique(string idNum)
    {

        foreach (var tempStudent in Students)
        {
            if (tempStudent.IdenticalNum == idNum)
            {
                return false;
            }
        }
        foreach (var prof in Professors)
        {
            if (prof.IdenticalNum == idNum)
            {
                return false;
            }
        }
        return true;
    }
    List<Class> Classes { get; set; }
    List<Student> Students { get; set; }
    List<Professor> Professors { get; set; }
}

class Student : Person
{
    private int enteringYear;

    public Student(string name, string identicalNum, int enteringYear, string field)
        : base(name, identicalNum, field)
    {
        EnteringYear = enteringYear;
        NameOfRegisteredClasses = new List<string>();
        Grades = new Dictionary<string, string>();
    }
    public int EnteringYear
    {
        get
        {
            return enteringYear;
        }
        set
        {
            if (value >= 1300 && value <= 1500)
            {
                enteringYear = value;
            }
            else
            {
                Console.WriteLine("Invalid year");
            }

        }
    }
    public Dictionary<string, string> Grades { get; set; }
    public List<String> NameOfRegisteredClasses { get; set; }
}

class Professor : Person
{
    public Professor(string name, string identicalNum, string field)
        : base(name, identicalNum, field)
    {
        NameOfRegisteredClasses = new List<string>();
    }
    public List<String> NameOfRegisteredClasses { get; set; }
}

class Class
{
    private string name;
    private string id;
    private string field;
    public Class(string name, string classID, string field)
    {
        Name = name;
        ID = classID;
        Field = field;
        ClassProfessor = null;
        Students = new List<Student>();
    }

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value.Length <= 20 && value.Length >= 1)
            {
                name = value;
            }
            else
            {
                Console.WriteLine("Name must be between 1 and 20 characters");
            }

        }
    }
    public string ID
    {
        get
        {
            return id;
        }
        set
        {
            if (value.All(char.IsDigit) && value.Length == 10)
            {
                id = value;
            }
            else
            {
                Console.WriteLine("Invalid Class ID");
            }

        }
    }
    public string Field
    {
        get
        {
            return field;
        }
        set
        {
            if (value.Length <= 20 && value.Length >= 1 && value.All(char.IsLower))
            {
                field = value;
            }
            else
            {
                Console.WriteLine("Invalid field");
            }
        }
    }
    public Professor ClassProfessor { get; set; }
    public List<Student> Students { get; set; }
}

class Person
{
    private string name;
    private string identicalNum;
    private string field;
    public Person(string name, string identicalNum, string field)
    {
        Name = name;
        IdenticalNum = identicalNum;
        Field = field;
    }

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value.Length <= 20 && value.Length >= 1)
            {
                name = value;
            }
            else
            {
                Console.WriteLine("Name must be between 1 and 20 characters");
            }

        }
    }
    public string IdenticalNum
    {
        get
        {
            return identicalNum;
        }
        set
        {
            if (value.All(char.IsDigit) && value.Length == 10)
            {
                identicalNum = value;
            }
            else
            {
                Console.WriteLine("Invalid ID");
            }

        }
    }
    public string Field
    {
        get
        {
            return field;
        }
        set
        {
            if (value.Length <= 20 && value.Length >= 1 && value.All(char.IsLower))
            {
                field = value;
            }
            else
            {
                Console.WriteLine("Invalid field");
            }
        }
    }

}



