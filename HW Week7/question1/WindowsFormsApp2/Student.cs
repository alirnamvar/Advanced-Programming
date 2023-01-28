using System;
using System.Collections.Generic;

namespace WindowsFormsApp2
{
    public class Student : Person
    {
        //private int enteringYear;

        public Student(string name, string identicalNum, int enteringYear, string field)
            : base(name, identicalNum, field)
        {
            EnteringYear = enteringYear;
            NameOfRegisteredClasses = new List<string>();
            RegisteredClasses = new List<Class> { };
            Grades = new Dictionary<string, string>();
        }

        public Student(string name, string identicalNum, int enteringYear, int intField)
            : base(name, identicalNum, intField)
        {
            //Name = name;
            //IdenticalNum = identicalNum;
            //IntField = intField;
            //Field = ((FieldEnum)intField).ToString();
            EnteringYear = enteringYear;
            NameOfRegisteredClasses = new List<string>();
            RegisteredClasses = new List<Class> { };
            Grades = new Dictionary<string, string>();
        }

        public int EnteringYear { get; set; }
        public Dictionary<string, string> Grades { get; }
        public List<string> NameOfRegisteredClasses { get; }
        public List<Class> RegisteredClasses { get; }
    }

    
}
