using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp2
{
    public enum FieldEnum { Computer = 1, Mechanic = 2, ElectricalEngineering = 3, Robotics = 4 }
    public class Class
    {

        public Class(string name, string classID, string field)
        {
            Name = name;
            ID = classID;
            Field = field;
            ClassProfessor = null;
            Students = new List<Student>();
        }

        public Class(string name, string classID, int intField)
        {
            Name = name;
            ID = classID;
            IntField = intField;
            Field = ((FieldEnum)intField).ToString();
            ClassProfessor = null;
            Students = new List<Student>();
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public string Field { get; set; }
        public int IntField { get; set; }
        public Professor ClassProfessor { get; set; }
        public List<Student> Students { get; }
    }

    
}
