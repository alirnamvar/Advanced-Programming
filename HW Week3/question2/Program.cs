using System;
using System.Globalization;

namespace question2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Suggestion: a very good corner case is 29/2/2000
            
            Console.Write("Day: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDate:");
            var date = new Date(year, month, day);
            date.Print();
            
            Console.WriteLine("\nPrevious day");
            date = date.PreviousDay();
            date.Print();
            
            Console.WriteLine("\nNext month");
            date = date.NextMonth();
            date.Print();
            
            Console.WriteLine("\nNext year");
            date = date.NextYear();
            date.Print();
            
            Console.WriteLine("\nNext day");
            date = date.NextDay();
            date.Print();

            Console.WriteLine("\nPrevious month");
            date = date.PreviousMonth();
            date.Print();

            Console.WriteLine("\nPrevious year");
            date = date.PreviousYear();
            date.Print();

            Console.WriteLine("\nSet date to 29/2/2000");
            date.SetDate(2022, 12, 31);
            date.Print();

            Console.WriteLine("\nPrint day of week");
            date.PrintDayOfWeek(date.Year, date.Month, date.Day);

            Console.WriteLine("\nIs 29/2/2001 a valid date?");
            Console.WriteLine(date.IsValidDate(2001, 2, 29));

            Console.WriteLine("\nIs 29/2/2000 a valid date?");
            Console.WriteLine(date.IsValidDate(2000, 2, 29));
        }
    }
    
    public class Date
    {
        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public enum EMonth
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
        private readonly int[] maxDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private readonly string[] monthNames = 
            { "January", "February", "March", "April", "May", "June", "July",
            "August", "September", "October", "November", "December" };
        private int year;
        private int month;
        private int day;
        public int Day
        {
            get { return day; }
            set { SetDay(value); }
        }
        public int Month
        {
            get { return month; }
            set { SetMonth(value); }
        }
        public int Year
        {
            get { return year; }
            set { SetYear(value); }
        }
        public bool IsValidDate(int year, int month, int day)
        {
            if (year <= 9999 && year >= 1973)
            {
                if (month <= 12 && month >= 1)
                {
                    if (IsLeapYear(year) && month == (int)EMonth.February)
                    {
                        if (day <= 29 && day >= 1)
                        {
                            return true;
                        }
                        return false;
                    }
                    else if (day <= maxDays[month - 1] && day >= 1)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }
        public void SetYear(int year)
        {
            if (year <= 9999 && year >= 1973)
            {
                this.year = year;
            }
            else
            {
                Console.WriteLine("Year must be between 1973 and 9999");
            }
        }
        public void SetMonth(int month)
        {
            if (month <= 12 && month >= 1)
            {
                this.month = month;
            }
            else
            {
                Console.WriteLine("Month must be between 1 and 12");
            }
        }
        public void SetDay(int day)
        {
            if (IsLeapYear(Year) && Month == (int)EMonth.February)
            {
                if (day <= 29 && day >= 1)
                {
                    this.day = day;
                }
                else
                {
                    Console.WriteLine(
                        "This is a February day in leap year so Day must be between 1 and 29");
                }
            }
            else if (day <= maxDays[Month - 1] && day >= 1)
            {
                this.day = day;
            }
            else
            {
                Console.WriteLine("Day must be between 1 and " + maxDays[Month - 1]);
            }
        }
        public bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }
            return false;
        }
        public void SetDate(int year, int month, int day)
        {
            SetYear(year);
            SetMonth(month);
            SetDay(day);
        }
        public void Print()
        {
            Console.WriteLine($"{Day}/{Month}/{Year} is a {DayOfWeek()} in {MonthName()}.");
        }
        public void PrintDayOfWeek(int year, int month, int day)
        {
            DateTime dateValue = new DateTime(year, month, day);
            Console.WriteLine(dateValue.ToString("dddd", new CultureInfo("en-EN")));
        }
        private string DayOfWeek()
        {
            DateTime dateValue = new DateTime(Year, Month, Day);
            return dateValue.ToString("dddd",
                        new CultureInfo("en-EN"));
        }
        private string MonthName()
        {
            return monthNames[Month - 1];
        }
        public Date NextDay()
        {
            int day = Day;
            int month = Month;
            int year = Year;
            if (IsLeapYear(year) && month == (int)EMonth.February)
            {
                if (day < 29)
                {
                    day++;
                }
                else
                {
                    day = 1;
                    month++;
                }
            }
            else
            {
                if (day < maxDays[month - 1])
                {
                    day++;
                }
                else
                {
                    if (month < 12)
                    {
                        month++;
                        day = 1;
                    }
                    else
                    {
                        year++;
                        month = 1;
                        day = 1;
                    }
                }
            }
            this.SetDate(year, month, day);
            return this;
        }
        public Date PreviousDay()
        {
            int day = Day;
            int month = Month;
            int year = Year;
            if (IsLeapYear(year) && month == (int)EMonth.March)
            {
                if (day > 1)
                {
                    day--;
                }
                else
                {
                    month = (int)EMonth.February;
                    day = 29;
                }
            }
            else
            {
                if (day > 1)
                {
                    day--;
                }
                else
                {
                    if (month > 1)
                    {
                        month--;
                        day = maxDays[month - 1];
                    }
                    else
                    {
                        year--;
                        month = 12;
                        day = 31;
                    }
                }
            }
            this.SetDate(year, month, day);
            return this;
        }
        public Date NextMonth()
        {
            int day = Day;
            int month = Month;
            int year = Year;
            if (month < 12)
            {
                month++;
            }
            else
            {
                year++;
                month = 1;
            }
            if (IsLeapYear(year) && month == (int)EMonth.February)
            {
                if (day > 29)
                {
                    day = 29;
                }
            }
            else if (day > maxDays[month - 1])
            {
                day = maxDays[month - 1];
            }
            this.SetDate(year, month, day);
            return this;
        }
        public Date PreviousMonth()
        {
            int day = Day;
            int month = Month;
            int year = Year;
            if (month > 1)
            {
                month--;
            }
            else
            {
                year--;
                month = 12;
            }
            if (IsLeapYear(year) && month == (int)EMonth.February)
            {
                if (day >= 29)
                {
                    day = 29;
                }
            }
            else if (day > maxDays[month - 1])
            {
                day = maxDays[month - 1];
            }
            this.SetDate(year, month, day);
            return this;
        }
        public Date NextYear()
        {
            int day = Day;
            int month = Month;
            int year = Year;
            if (IsLeapYear(year) && month == (int)EMonth.February && day == 29)
            {
                day = 28;
            }
            year++;
            this.SetDate(year, month, day);
            return this;
        }
        public Date PreviousYear()
        {
            int day = Day;
            int month = Month;
            int year = Year; 
            if (IsLeapYear(year) && month == (int)EMonth.February && day == 29)
            {
                day = 28;
            }
            year--;
            this.SetDate(year, month, day);
            return this;
        }     
    }
}   
    
