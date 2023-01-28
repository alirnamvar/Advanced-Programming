using System.Collections.Generic;

namespace WindowsFormsApp2
{
    public class Professor : Person
    {
        public Professor(string name, string identicalNum, string field)
            : base(name, identicalNum, field)
        {
            NameOfRegisteredClasses = new List<string>();
            RegisteredClasses = new List<Class>();
        }
        public Professor(string name, string identicalNum, int intField)
            : base(name, identicalNum, intField)
        {
            NameOfRegisteredClasses = new List<string>();
            RegisteredClasses = new List<Class>();
        }

        public override string ToString()
        {
            return Name + " (" + Field + ")";
        }

        public List<string> NameOfRegisteredClasses { get; }
        public List<Class> RegisteredClasses { get; }
    }

    

    
}
