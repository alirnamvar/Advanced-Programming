using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Manager
    {
        private static Golestan _golestanManager;

        public static Golestan GolestanManager
        {
            get
            {
                if (_golestanManager == null)
                    _golestanManager = new Golestan();
                return _golestanManager;
            }
        }
    }

    public class Registor
    {
        public Registor(List<Student> students, List<Professor> professors)
        {
            Students = students;
            Professors = professors;
        }

        private List<Student> Students { get; set; }
        private List<Professor> Professors { get; set; }

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
        public string RegisterProfessor(string name, string identicalNum, int intField)
        {
            if (IsIdenticalNumUnique(identicalNum))
            {
                var prof = new Professor(name, identicalNum, intField);
                Professors.Add(prof);
                return "welcome to golestan";
            }
            else
            {
                return "this identical number previously registered";
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

        public string RegisterStudent(string name, string identicalNum, int enteringYear, int intField)
        {
            if (IsIdenticalNumUnique(identicalNum))
            {
                var student = new Student(name, identicalNum, enteringYear, intField);
                Students.Add(student);
                return "welcome to golestan";
            }
            else
            {
                return "this identical number previously registered";
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

        public string AddStudent(string identicalNum, string classID)
        {
            if (!IsStudentExist(identicalNum))
            {
                return "invalid student";
            }
            else if (!IsClassExist(classID))
            {
                return "invalid class";
            }
            else if (!IsStudentFieldMatch(identicalNum, classID))
            {
                return "student field is not match"; 
            }
            else if (IsStudentInClass(identicalNum, classID))
            {
                return "student is already registered";     
            }
            else
            {
                var student = Students.Find(s => s.IdenticalNum == identicalNum);
                var class_ = Classes.Find(c => c.ID == classID);
                class_.Students.Add(student);
                student.NameOfRegisteredClasses.Add(class_.Name);
                student.RegisteredClasses.Add(class_);
                return "student added successfully to the class";
            }
        }
        public string AddProfessor(string identicalNum, string classID)
        {
            if (!IsProfessorExist(identicalNum))
            {
                return "invalid professor";
            }
            else if (!IsClassExist(classID))
            {
                return "invalid class";
            }
            else if (!IsProfessorFieldMatch(identicalNum, classID))
            {
                return "professor field is not match";
            }
            else if (ClassHasProfessor(classID))
            {
                return "this class has a professor";
            }
            else
            {
                var prof = Professors.Find(x => x.IdenticalNum == identicalNum);
                var class_ = Classes.Find(c => c.ID == classID);
                class_.ClassProfessor = prof;
                prof.NameOfRegisteredClasses.Add(class_.Name);
                prof.RegisteredClasses.Add(class_);
                return "professor added successfully to the class";
            }

        }
        private bool ClassHasProfessor(string classID)
        {
            return Classes.Find(c => c.ID == classID).ClassProfessor != null;
        }
        private bool IsProfessorFieldMatch(string professorIdenticalNum, string classID)
        {
            return Classes.Find(c => c.ID == classID).IntField == Professors.Find(s => s.IdenticalNum == professorIdenticalNum).IntField;
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
            return Classes.Find(c => c.ID == classID).IntField == Students.Find(s => s.IdenticalNum == studentIdenticalNum).IntField;
        }

        private List<Class> Classes { get; }
        private List<Student> Students { get; }
        private List<Professor> Professors { get; }
    }

    public class Golestan
    {
        public List<Class> Classes { get; }
        public List<Student> Students { get; }
        public List<Professor> Professors { get; }
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
        public Student GetStudent(string identicalNum)
        {
            return Students.Find(s => s.IdenticalNum == identicalNum);
        }
        public Professor GetProfessor(string identicalNum)
        {
            return Professors.Find(p => p.IdenticalNum == identicalNum);
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
        public string ProfessorStatus(string identicalNum)
        {
            return IndividualAndClassStatus.ProfessorStatus(identicalNum, Professors);
        }
        public string StudentStatus(string identicalNum)
        {
            return IndividualAndClassStatus.StudentStatus(identicalNum, Students);
        }
        public string AddProfessor(string identicalNum, string classID)
        {
            return AddIndividual.AddProfessor(identicalNum, classID);
        }
        public string AddStudent(string identicalNum, string classID)
        {
            return AddIndividual.AddStudent(identicalNum, classID);
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

        public string MakeClass(string name, string classID, int intField)
        {
            if (Classes.Any(c => c.ID == classID))
            {
                return "this class id previously use";
            }
            else
            {
                Classes.Add(new Class(name, classID, intField));
                return "class added successfully";
            }
        }
        public void RegisterProfessor(string name, string identicalNum, string field)
        {
            Registor.RegisterProfessor(name, identicalNum, field);
        }
        public string RegisterProfessor(string name, string identicalNum, int intField)
        {
            return Registor.RegisterProfessor(name, identicalNum, intField);
        }
        public void RegisterStudent(string name, string identicalNum, int enteringYear, string field)
        {
            Registor.RegisterStudent(name, identicalNum, enteringYear, field);
        }

        public string RegisterStudent(string name, string identicalNum, int enteringYear, int intField)
        {
            return Registor.RegisterStudent(name, identicalNum, enteringYear, intField);
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
        public static string ProfessorStatus(string identicalNum, List<Professor> professors)
        {
            string output = "";
            if (!IsProfessorExist(identicalNum, professors))
            {
                return "invalid professor";
            }
            var prof = professors.Find(x => x.IdenticalNum == identicalNum);
            output += $"{prof.Name} {prof.Field}";
            foreach (var classesName in prof.NameOfRegisteredClasses)
            {
                output += $" {classesName}";
            }
            output += "\n";
            return output;
        }
        public static string StudentStatus(string identicalNum, List<Student> students)
        {
            string output = "";
            if (!IsStudentExist(identicalNum, students))
            {
                return "invalid student";
            }
            var student = students.Find(s => s.IdenticalNum == identicalNum);
            output += $"{student.Name} {student.EnteringYear} {student.Field}";
            foreach (var classesName in student.NameOfRegisteredClasses)
            {
                output += $" {classesName}";
            }
            output += "\n";
            return output;
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

    class MarkHandler
    {
        public MarkHandler(List<Class> classes, List<Student> students, List<Professor> professors)
        {
            Classes = classes;
            Students = students;
            Professors = professors;
        }

        public void SetFinalMark(string professorIdenticalNum, string studentIdenticalNum, string classID, string grade)
        {
            if (!IsProfessorExist(professorIdenticalNum))
            {
                Console.WriteLine("invalid professor");
                return;
            }
            else if (!IsStudentExist(studentIdenticalNum))
            {
                Console.WriteLine("invalid student");
                return;
            }
            else if (!IsClassExist(classID))
            {
                Console.WriteLine("invalid class");
                return;
            }
            else if (!IsProfessorInClass(professorIdenticalNum, classID))
            {
                Console.WriteLine("professor class is not match");
                return;
            }
            else if (!IsStudentInClass(studentIdenticalNum, classID))
            {
                Console.WriteLine("student did not registered");
                return;
            }
            else
            {
                var student = Students.Find(x => x.IdenticalNum == studentIdenticalNum);
                string garbage;
                if (student.Grades.TryGetValue(classID, out garbage))
                {
                    student.Grades[classID] = grade;
                }
                else
                {
                    student.Grades.Add(classID, grade);
                }
                Console.WriteLine("student final mark added or changed");
            }
        }
        public void MarkStudent(string identicalNum, string classID)
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
            else if (!IsStudentInClass(identicalNum, classID))
            {
                Console.WriteLine("student did not registered");
                return;
            }
            else
            {
                var student = Students.Find(x => x.IdenticalNum == identicalNum);
                var hasGrade = student.Grades.Keys.Contains(classID);
                if (!hasGrade)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    Console.WriteLine(student.Grades[classID]);
                }
            }
        }
        public void MarkList(string classID)
        {
            if (!IsClassExist(classID))
            {
                Console.WriteLine("invalid class");
                return;
            }
            else if (!ClassHasProfessor(classID))
            {
                Console.WriteLine("no professor");
                return;
            }
            else if (!ClassHasStudent(classID))
            {
                Console.WriteLine("no student");
                return;
            }
            else
            {
                var class_ = Classes.Find(x => x.ID == classID);
                bool firstTime = true;

                foreach (var student in class_.Students)
                {
                    string grade = GetGradeOfStudent(student, classID);
                    if (firstTime)
                    {
                        Console.Write($"{grade}");
                        firstTime = false;
                    }
                    else
                    {
                        Console.Write($" {grade}");
                    }
                }
                Console.WriteLine("");
            }
        }
        private string GetGradeOfStudent(Student student, string classID)
        {
            var hasGrade = student.Grades.Keys.Contains(classID);
            if (!hasGrade)
            {
                return "None";
            }
            else
            {
                return student.Grades[classID];
            }
        }
        private bool ClassHasStudent(string classID)
        {
            return Classes.Find(c => c.ID == classID).Students.Count > 0;
        }
        private bool ClassHasProfessor(string classID)
        {
            return Classes.Find(c => c.ID == classID).ClassProfessor != null;
        }
        private bool IsProfessorInClass(string professorIdenticalNum, string classID)
        {
            return Classes.Find(c => c.ID == classID).ClassProfessor.IdenticalNum == professorIdenticalNum;
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

        private List<Class> Classes { get; }
        private List<Student> Students { get; }
        private List<Professor> Professors { get; }
    }
}
