using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Person
    {
        public Person(string name, string identicalNum, string field)
        {
            Name = name;
            IdenticalNum = identicalNum;
            Field = field;
        }

        public Person(string name, string identicalNum, int intField)
        {
            Name = name;
            IdenticalNum = identicalNum;
            IntField = intField;
            Field = ((FieldEnum)intField).ToString();
        }

        public int IntField { get; set; }
        public string Name { get; set; }
        public string IdenticalNum { get; set; }
        public string Field { get; set; }
    }
}
