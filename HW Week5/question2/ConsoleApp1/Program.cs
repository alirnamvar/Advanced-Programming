using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var golestanConsole = new GolestanConsole();
            golestanConsole.Run();
        }

        class GolestanConsole
        {
            public void Run()
            {
                var golestan = new Golestan();

                while (true)
                {
                    string[] command = Console.ReadLine().Split(' ').ToArray();
                    if (command.Length == 0) continue;

                    if (command[0] == "register_student")
                    {
                        golestan.RegisterStudent(command[1], command[2], int.Parse(command[3]), command[4]);
                    }
                    else if (command[0] == "register_professor")
                    {
                        golestan.RegisterProfessor(command[1], command[2], command[3]);
                    }
                    else if (command[0] == "make_class")
                    {
                        golestan.MakeClass(command[1], command[2], command[3]);
                    }
                    else if (command[0] == "add_student")
                    {
                        golestan.AddStudent(command[1], command[2]);
                    }
                    else if (command[0] == "add_professor")
                    {
                        golestan.AddProfessor(command[1], command[2]);
                    }
                    else if (command[0] == "student_status")
                    {
                        golestan.StudentStatus(command[1]);
                    }
                    else if (command[0] == "professor_status")
                    {
                        golestan.ProfessorStatus(command[1]);
                    }
                    else if (command[0] == "class_status")
                    {
                        golestan.ClassStatus(command[1]);
                    }
                    else if (command[0] == "set_final_mark")
                    {
                        golestan.SetFinalMark(command[1], command[2], command[3], command[4]);
                    }
                    else if (command[0] == "mark_student")
                    {
                        golestan.MarkStudent(command[1], command[2]);
                    }
                    else if (command[0] == "mark_list")
                    {
                        golestan.MarkList(command[1]);
                    }
                    else if (command[0] == "average_mark_professor")
                    {
                        golestan.AverageMarkProfessor(command[1]);
                    }
                    else if (command[0] == "average_mark_student")
                    {
                        golestan.AverageMarkStudent(command[1]);
                    }
                    else if (command[0] == "top_student")
                    {
                        golestan.TopStudent(command[1], int.Parse(command[2]));
                    }
                    else if (command[0] == "top_mark")
                    {
                        golestan.TopMark(command[1]);
                    }
                    else if (command[0] == "end")
                    {
                        break;
                    }
                }
            }
        }
    }

    static class IndividualAndClassStatus
    {
        public static void ClassStatus(string classID, List<Class> classes)
        {
            var class_ = classes.Find(c => c.ID == classID);
            if (!IsClassExist(classID, classes))
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
        public static void ProfessorStatus(string identicalNum, List<Professor> professors)
        {
            if (!IsProfessorExist(identicalNum, professors))
            {
                Console.WriteLine("invalid professor");
                return;
            }
            var prof = professors.Find(x => x.IdenticalNum == identicalNum);
            Console.Write($"{prof.Name} {prof.Field}");
            foreach (var classesName in prof.NameOfRegisteredClasses)
            {
                Console.Write($" {classesName}");
            }
            Console.WriteLine();
        }
        public static void StudentStatus(string identicalNum, List<Student> students)
        {
            if (!IsStudentExist(identicalNum, students))
            {
                Console.WriteLine("invalid student");
                return;
            }
            var student = students.Find(s => s.IdenticalNum == identicalNum);
            Console.Write($"{student.Name} {student.EnteringYear} {student.Field}");
            foreach (var classesName in student.NameOfRegisteredClasses)
            {
                Console.Write($" {classesName}");
            }
            Console.WriteLine();
        }
        private static bool IsClassExist(string classID, List<Class> classes)
        {
            return classes.Any(c => c.ID == classID);
        }
        private static bool IsProfessorExist(string professorIdenticalNum, List<Professor> professors)
        {
            return professors.Any(professor => professor.IdenticalNum == professorIdenticalNum);
        }
        private static bool IsStudentExist(string studentIdenticalNum, List<Student> students)
        {
            return students.Any(student => student.IdenticalNum == studentIdenticalNum);
        }
    }

    static class FindToppest
    {
        public static void TopStudent(string field, int enteringYear, List<Student> students)
        {
            double maxAverage = 0;
            bool hasAStudent = false;
            List<Student> topStudents = new List<Student>();

            foreach (var student in students)
            {
                if (student.Field == field && student.EnteringYear == enteringYear)
                {
                    hasAStudent = true;
                    double sumOfMarks = 0.0;
                    double average = 0.0;
                    if (student.Grades.Count == 0)
                    {
                        Console.WriteLine("None");
                    }
                    else
                    {
                        foreach (var grade in student.Grades.Values)
                        {
                            sumOfMarks += double.Parse(grade);
                        }
                        average = sumOfMarks / (double)student.Grades.Count;
                    }
                    if (average > maxAverage)
                    {
                        maxAverage = average;
                        topStudents.Clear();
                        topStudents.Add(student);
                    }
                    else if (average == maxAverage)
                    {
                        topStudents.Add(student);
                    }
                }
            }
            if (!hasAStudent)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(topStudents[0].Name);
            }
        }
        public static void TopMark(string classID, List<Class> classes)
        {
            if (!IsClassExist(classID, classes))
            {
                Console.WriteLine("invalid class");
                return;
            }
            else if (!AtLeastOneStudentsHasGrade(classID, classes))
            {
                Console.WriteLine("None");
                return;
            }
            else
            {
                var class_ = classes.Find(x => x.ID == classID);
                int max = 0;
                foreach (var student in class_.Students)
                {
                    int grade = int.Parse(student.Grades[classID]);
                    if (grade > max)
                    {
                        max = grade;
                    }
                }
                Console.WriteLine(max);
            }
        }
        private static bool AtLeastOneStudentsHasGrade(string classId, List<Class> classes)
        {
            var class_ = classes.Find(c => c.ID == classId);
            foreach (var student in class_.Students)
            {
                if (student.Grades.ContainsKey(classId))
                {
                    return true;
                }
            }
            return false;
        }
        private static bool IsClassExist(string classID, List<Class> classes)
        {
            return classes.Any(c => c.ID == classID);
        }
    }

    static class FindAverage
    {
        public static void AverageMarkProfessor(string identicalNum, List<Professor> professors, List<Class> classes)
        {
            var professor = professors.Find(p => p.IdenticalNum == identicalNum);

            if (!IsProfessorExist(identicalNum, professors))
            {
                Console.WriteLine("invalid professor");
                return;
            }
            else
            {
                double sumOfMarks = 0.0;
                int numberOfClasses = 0;
                foreach (var class_ in classes)
                {
                    if (class_.ClassProfessor == professor)
                    {
                        numberOfClasses++;
                        foreach (var student in class_.Students)
                        {
                            string toAdd;
                            if (student.Grades.TryGetValue(class_.ID, out toAdd))
                            {
                                sumOfMarks += double.Parse(toAdd);
                            }
                            else
                            {
                                Console.WriteLine("Grade Not Found!");
                            }
                        }
                    }
                }
                if (numberOfClasses == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    double average = sumOfMarks / (double)numberOfClasses;
                    Console.WriteLine(String.Format("{0:0.00}", average));
                }
            }
        }
        public static void AverageMarkStudent(string identicalNum, List<Student> students)
        {
            var student = students.Find(p => p.IdenticalNum == identicalNum);

            if (!IsStudentExist(identicalNum, students))
            {
                Console.WriteLine("invalid student");
                return;
            }
            else
            {
                double sumOfMarks = 0.0;
                if (student.Grades.Count == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (var grade in student.Grades.Values)
                    {
                        sumOfMarks += double.Parse(grade);
                    }
                    double average = sumOfMarks / (double)student.Grades.Count;
                    Console.WriteLine(String.Format("{0:0.00}", average));
                }
            }
        }
        private static bool IsStudentExist(string studentIdenticalNum, List<Student> students)
        {
            return students.Any(student => student.IdenticalNum == studentIdenticalNum);
        }
        private static bool IsProfessorExist(string professorIdenticalNum, List<Professor> professors)
        {
            return professors.Any(professor => professor.IdenticalNum == professorIdenticalNum);
        }
    }

    class Registor
    {
        public Registor(List<Student> students, List<Professor> professors)
        {
            Students = students;
            Professors = professors;
        }

        private List<Student> Students { get; }
        private List<Professor> Professors { get; }

        public void RegisterProfessor(string name, string identicalNum, string field)
        {
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
        public void RegisterStudent(string name, string identicalNum, int enteringYear, string field)
        {
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
            var isStudentExist = Students.Any(student => student.IdenticalNum == idNum);
            var isProfessorExist = Professors.Any(professor => professor.IdenticalNum == idNum);
            return !isStudentExist && !isProfessorExist;
        }

    }

    class AddIndividual
    {
        public AddIndividual(List<Class> classes, List<Student> students, List<Professor> professors)
        {
            Classes = classes;
            Students = students;
            Professors = professors;
        }

        public void AddStudent(string identicalNum, string classID)
        {
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
        public void AddProfessor(string identicalNum, string classID)
        {
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
        private bool ClassHasProfessor(string classID)
        {
            return Classes.Find(c => c.ID == classID).ClassProfessor != null;
        }
        private bool IsProfessorFieldMatch(string professorIdenticalNum, string classID)
        {
            return Classes.Find(c => c.ID == classID).Field == Professors.Find(s => s.IdenticalNum == professorIdenticalNum).Field;
        }
        private bool IsProfessorExist(string professorIdenticalNum)
        {
            return Professors.Any(professor => professor.IdenticalNum == professorIdenticalNum);
        }
        private bool IsStudentExist(string studentIdenticalNum)
        {
            return Students.Any(student => student.IdenticalNum == studentIdenticalNum);
        }
        private bool IsStudentInClass(string studentIdenticalNum, string classID)
        {
            return Classes.Find(c => c.ID == classID).Students.Any(s => s.IdenticalNum == studentIdenticalNum);
        }
        private bool IsClassExist(string classID)
        {
            return Classes.Any(c => c.ID == classID);
        }
        private bool IsStudentFieldMatch(string studentIdenticalNum, string classID)
        {
            return Classes.Find(c => c.ID == classID).Field == Students.Find(s => s.IdenticalNum == studentIdenticalNum).Field;
        }

        private List<Class> Classes { get; }
        private List<Student> Students { get; }
        private List<Professor> Professors { get; }
    }

    class Golestan
    {
        private List<Class> Classes { get; }
        private List<Student> Students { get; }
        private List<Professor> Professors { get; }
        private Registor Registor { get; }
        private AddIndividual AddIndividual { get; }
        private MarkHandler MarkHandler { get; }
        public Golestan()
        {
            Classes = new List<Class>();
            Students = new List<Student>();
            Professors = new List<Professor>();
            Registor = new Registor(Students, Professors);
            AddIndividual = new AddIndividual(Classes, Students, Professors);
            MarkHandler = new MarkHandler(Classes, Students, Professors);
        }
        public void AverageMarkStudent(string identicalNum)
        {
            FindAverage.AverageMarkStudent(identicalNum, Students);
        }
        public void AverageMarkProfessor(string identicalNum)
        {
            FindAverage.AverageMarkProfessor(identicalNum, Professors, Classes);
        }
        public void TopStudent(string field, int enteringYear)
        {
            FindToppest.TopStudent(field, enteringYear, Students);
        }
        public void TopMark(string classID)
        {
            FindToppest.TopMark(classID, Classes);
        }
        public void MarkList(string classID)
        {
            MarkHandler.MarkList(classID);
        }
        public void MarkStudent(string identicalNum, string classID)
        {
            MarkHandler.MarkStudent(identicalNum, classID);
        }
        public void SetFinalMark(string professorIdenticalNum, string studentIdenticalNum, string classID, string grade)
        {
            MarkHandler.SetFinalMark(professorIdenticalNum, studentIdenticalNum, classID, grade);
        }
        public void ClassStatus(string classID)
        {
            IndividualAndClassStatus.ClassStatus(classID, Classes);
        }
        public void ProfessorStatus(string identicalNum)
        {
            IndividualAndClassStatus.ProfessorStatus(identicalNum, Professors);
        }
        public void StudentStatus(string identicalNum)
        {
            IndividualAndClassStatus.StudentStatus(identicalNum, Students);
        }
        public void AddProfessor(string identicalNum, string classID)
        {
            AddIndividual.AddProfessor(identicalNum, classID);
        }
        public void AddStudent(string identicalNum, string classID)
        {
            AddIndividual.AddStudent(identicalNum, classID);
        }
        public void MakeClass(string name, string classID, string field)
        {
            if (Classes.Any(c => c.ID == classID))
            {
                Console.WriteLine("this class id previously use");
            }
            else
            {
                Classes.Add(new Class(name, classID, field));
                Console.WriteLine("class added successfully");
            }
        }
        public void RegisterProfessor(string name, string identicalNum, string field)
        {
            Registor.RegisterProfessor(name, identicalNum, field);
        }
        public void RegisterStudent(string name, string identicalNum, int enteringYear, string field)
        {
            Registor.RegisterStudent(name, identicalNum, enteringYear, field);
        }
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
        public Dictionary<string, string> Grades { get; }
        public List<string> NameOfRegisteredClasses { get; }
    }

    class Professor : Person
    {
        public Professor(string name, string identicalNum, string field)
            : base(name, identicalNum, field)
        {
            NameOfRegisteredClasses = new List<string>();
        }
        public List<string> NameOfRegisteredClasses { get; }
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
        public List<Student> Students { get; }
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
}