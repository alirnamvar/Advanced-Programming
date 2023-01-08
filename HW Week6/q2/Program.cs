using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "input.csv";
            var fileHandler = new PersonStreamWriterReader();
            
            List<Person> persons = fileHandler.GetPersonsFromFile(filePath);

            var list1 = from person in persons
                        orderby person.GoldenNumber descending
                        select new
                        {
                            person.Name,
                            person.FamilyName,
                            person.GoldenNumber
                        };
            string list1String = $"name, family_name, golden_number\n";
            foreach (var item in list1)
            {
                list1String += $"{item.Name}, {item.FamilyName}, {item.GoldenNumber}\n";
            }
            fileHandler.SaveStringToFile("1.csv", list1String);


            var list2 = from person in persons
                        where (person.NumberOfChildren >= 2
                            && person.IsMarried == "yes"
                            && person.WorkExperience >= 2)
                        orderby person.Salary descending, person.FamilyName descending
                        select new 
                        { 
                            person.Id,
                            person.Name,
                            person.FamilyName,
                            person.Salary,
                        };
            string list2String = $"id, name, family_name, salary\n";
            foreach (var item in list2)
            {
                list2String += $"{item.Id}, {item.Name}, {item.FamilyName}, {item.Salary}\n";
            }
            fileHandler.SaveStringToFile("2.csv", list2String);


            var list3 = new Dictionary<int, int>();
            foreach (var person in persons)
            {
                if (list3.ContainsKey(person.EmpYear))
                {
                    list3[person.EmpYear] += 1;
                }
                else
                {
                    list3.Add(person.EmpYear, 1);
                }
            }
            var sortedDict = from entry in list3
                             orderby entry.Value descending
                             select new { entry.Key, entry.Value };
            string list3String = $"epm_number, emp_year\n";
            foreach (var item in sortedDict)
            {
                list3String += $"{item.Value}, {item.Key}\n";
            }
            fileHandler.SaveStringToFile("3.csv", list3String);

        } 
    }

    public class PersonStreamWriterReader
    {
        public void SaveStringToFile(string filePath, string text)
        {
            File.WriteAllText(filePath, text);
        }

        public List<Person> GetPersonsFromFile(string filePath)
        {
            List<Person> personsList = new List<Person>();
            FileStream fs1 = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs1);

            string line = reader.ReadLine();

            while ((line = reader.ReadLine()) != null)
            {
                personsList.Add(Person.StringToPerson(line));
            }
            reader.Close();
            return personsList;
        }
    }

    public class Person
    {
        private readonly static int CurrentYear = 2022;
        public static Person StringToPerson(string line)
        {
            string[] a = Regex.Split(line, ", ", RegexOptions.IgnoreCase);
            var p = new Person(
                int.Parse(a[0]),
                a[1],
                a[2],
                int.Parse(a[3]),
                int.Parse(a[4]),
                a[5],
                int.Parse(a[6]),
                int.Parse(a[7]));
            return p;
        }
        public Person(int id, string name, string familyName, int birthYear, int salary, string isMarried, int numberOfChildren, int empYear)
        {
            Id = id;
            Name = name;
            FamilyName = familyName;
            BirthYear = birthYear;
            Salary = salary;
            IsMarried = isMarried;
            NumberOfChildren = numberOfChildren;
            EmpYear = empYear;
            WorkExperience = CurrentYear - empYear;
            if (isMarried == "yes")
            {
                GoldenNumber = salary / (WorkExperience + numberOfChildren + 2);
            }
            else if (isMarried == "no")
            {
                GoldenNumber = salary / (WorkExperience + 1);
            }
            
        }

        public int Id { get; }
        public string Name { get; }
        public string FamilyName { get; }
        public int BirthYear { get; }
        public int Salary { get; }
        public string IsMarried { get; }
        public int NumberOfChildren { get; }
        public int EmpYear { get; }
        public int WorkExperience { get; }
        public double GoldenNumber { get; }
    }
}
