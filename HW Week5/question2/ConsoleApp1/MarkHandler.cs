using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
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