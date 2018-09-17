using System;

namespace personclasslibrary
{
    public class yearsException:Exception
    {
        public yearsException()
        {
        }

        public yearsException(int input) : base(input + " is before 1900 or above 2018")
        {
        }
    }
    public class Person
    {
       public string Fname;
       public string Sname;
       public int YearOfBirth;

        public string GetName()
        {
            return Fname + " " + Sname;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - YearOfBirth;
        }

        public class Student : Person
        {
            public int ID;

            public string GetInfo()
            {
                return ("FName: " + Fname + ", SName: " + Sname + ", YearOfBirth:" + YearOfBirth + ", ID:" + ID);
            }

            public Student(string f, string s, int y, int i)
            {
                Fname = f;
                Sname = s;
                YearOfBirth = y;
                ID = i;
            }
        }

        public class Staff : Person
        {
            public string Username;

            public string GetInfo()
            {
                return ("FName: " + Fname + ", SName: " + Sname + ", YearOfBirth:" + YearOfBirth + ", Username:" + Username);
            }
        }

        public class Teacher : Staff
        {
            public string Expertise;
            public Teacher(string f, string s, int y, string u, string e)
            {
                Fname = f;
                Sname = s;
                YearOfBirth = y;
                Username = u;
                Expertise = e;
            }
        }

        public class admin : Staff
        {
            public int OfficeNo;

            public admin(string f, string s, int y, string u, int o)
            {
                Fname = f;
                Sname = s;
                YearOfBirth = y;
                Username = u;
                OfficeNo = o;


            }
        }
    }
    }
