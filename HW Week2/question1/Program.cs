using System;
using System.Linq;

namespace question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] personList = new Person[n];

            Person.SetPersonsName(personList);
            Person.SetMoneyAndPrefrencess(personList);
            Person.Donate(personList);

            foreach (var person in personList)
            {
                Console.WriteLine(person.Name + " " + (person.Money + person.DonationRecived - person.MoneyAtBeggining));
            }

        }

    }

    class Person
    {
        public static void Donate(Person[] personList)
        {
            foreach (var person in personList)
            {
                if (person.NumberOfFrieds == 0) continue;
                int remaining = person.Money % person.NumberOfFrieds;
                int moneyForFriends = (person.Money - remaining) / person.NumberOfFrieds;
                foreach (var friend in person.Friends)
                {
                    friend.DonationRecived += moneyForFriends;
                }
                person.Money = remaining;
            }
        }

        private string[] friendsName;
        private Person[] friends;
        public string Name { get; set; }
        public int Money { get; set; }
        public int NumberOfFrieds { get; set; }
        public int DonationRecived { get; set; }
        public int MoneyAtBeggining { get; set; }
        public Person GetFriends(int i)
        {
            return friends[i];
        }
        public Person[] Friends
        {
            get
            {
                return friends;
            }
        }


        public Person(string name)
        {
            Name = name;
            Money = 0;
            NumberOfFrieds = 0;
        }

        public static void SetPersonsName(Person[] personList)
        {
            for (int i = 0; i < personList.Length; i++)
            {
                personList[i] = new Person(Console.ReadLine());
            }
        }

        public static void SetMoneyAndPrefrencess(Person[] personList)
        {
            int indexOfPerson = 0;
            string inputName;
            for (int i = 0; i < personList.Length; i++)
            {
                inputName = Console.ReadLine();
                foreach (var person in personList)
                {
                    if (person.Name == inputName)
                    {
                        SetMoneyAndFriends(person);
                        break;
                    }
                    indexOfPerson++;
                }
                indexOfPerson = 0;
            }


            int friendsCounter = 0;
            foreach (var person in personList)
            {
                person.friends = new Person[person.NumberOfFrieds];
                foreach (var name in person.friendsName)
                {
                    int friendsIndex = GetIndexOfPerson(personList, name);
                    if (friendsIndex >= 0)
                    {
                        person.friends[friendsCounter] = personList[friendsIndex];
                        friendsCounter++;
                    }
                }
                friendsCounter = 0;
            }
        }

        private static int GetIndexOfPerson(Person[] personList, string name)
        {
            int index = 0;
            foreach (var person in personList)
            {
                if (person.Name == name)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        private static void SetMoneyAndFriends(Person person)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int money = inputs[0];
            person.MoneyAtBeggining = money;
            int numberOfFriends = inputs[1];
            string[] friendsNameArray = new string[numberOfFriends];

            person.Money = money;
            person.NumberOfFrieds = numberOfFriends;

            for (int i = 0; i < numberOfFriends; i++)
            {
                friendsNameArray[i] = Console.ReadLine();
            }
            person.friendsName = friendsNameArray;
        }
    }
}
