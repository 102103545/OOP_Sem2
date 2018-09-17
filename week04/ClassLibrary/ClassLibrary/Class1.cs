using System;

namespace ClassLibrary
{
    public class Person
    {
        string Fname;
        string Sname;
        int YearOfBirth;

        public string GetName()
        {
            return Fname + " " + Sname;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - YearOfBirth;
        }

        public class Student:Person
        {
            int ID;

            public string GetInfo()
            {
                return ("FName: " + Fname + ", SName: " + Sname + ", YearOfBirth:" + YearOfBirth + ", ID:" + ID);
            }
        }

        public class Staff : Person
        {
            string Username;

            public string GetInfo()
            {
                return ("FName: " + Fname + ", SName: " + Sname + ", YearOfBirth:" + YearOfBirth + ", Username:" + Username);
            }
        }

        public class Teacher : Staff
        {
            string Expertise;
        }

        public class admin : Staff
        {
            int OfficeNo;
        }
    }
}
