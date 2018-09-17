using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using personclasslibrary;

namespace mini_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person.Student> Students = new List<Person.Student>();
            List<Person.Teacher> Teachers = new List<Person.Teacher>();
            List<Person.admin> admins = new List<Person.admin>();
            MainMenu();



            void MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Welcome\n1. Create Student\n2. Create Teacher\n3. Create Admin\n4. View People\n5. Exit");
                char input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case '1':
                        CreateStudent();
                        break;
                    case '2':
                        CreateTeacher();
                        break;
                    case '3':
                        CreateAdmin();
                        break;
                    case '4':
                        ViewPeople();
                        break;
                    case '5':
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Entry");
                        anykey();
                        break;
                }
            }

            void CreateStudent()
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("enter FirstName");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("enter Surname");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Enter Year Of Birth");
                    int year = int.Parse(Console.ReadLine());
                    CheckYear(year);
                    Console.WriteLine("Enter ID");
                    int ID = int.Parse(Console.ReadLine());
                    Students.Add(new Person.Student(firstname, surname, year, ID));
                    Console.WriteLine("student created");
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
                anykey();

            }

            void CreateTeacher()
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("enter FirstName");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("enter Surname");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Enter Year Of Birth");
                    int year = int.Parse(Console.ReadLine());
                    CheckYear(year);
                    Console.WriteLine("Enter Username");
                    string Username = Console.ReadLine();
                    Console.WriteLine("Enter Expertise");
                    string Expertise = Console.ReadLine();
                    Teachers.Add(new Person.Teacher(firstname, surname, year, Username, Expertise));
                    Console.WriteLine("Teacher created");
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
                anykey();
            }

            void CreateAdmin()
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("enter FirstName");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("enter Surname");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Enter Year Of Birth");
                    int year = int.Parse(Console.ReadLine());
                    CheckYear(year);

                    Console.WriteLine("Enter Username");
                    string Username = Console.ReadLine();
                    Console.WriteLine("Enter Username");
                    int officeNo = int.Parse(Console.ReadLine());
                    admins.Add(new Person.admin(firstname, surname, year, Username, officeNo));
                    Console.WriteLine("Teacher created");

                }
                catch (Exception e) { Console.WriteLine(e.Message); }
                anykey();
            }


                void ViewPeople()
                {
                    Console.Clear();
                    Console.WriteLine("VIEW PEOPLE:\n1. Students\n2. Teachers\n3. Admins");
                    char input = Console.ReadKey().KeyChar;
                    switch (input)
                    {
                        case '1':
                            Console.Clear();
                            Console.WriteLine("Enter Index of Student");
                            try { Console.WriteLine(Students[int.Parse(Console.ReadLine())].GetInfo()); }
                            catch (Exception e) { Console.WriteLine(e.Message); }
                            break;
                        case '2':
                            Console.Clear();
                            Console.WriteLine("Enter Index of Teacher");
                            try { Console.WriteLine(Teachers[int.Parse(Console.ReadLine())].GetInfo()); }
                            catch (Exception e) { Console.WriteLine(e.Message); }
                            break;
                        case '3':
                            Console.Clear();
                            Console.WriteLine("Enter Index of Admin");
                            try { Console.WriteLine(admins[int.Parse(Console.ReadLine())].GetInfo()); }
                            catch (Exception e) { Console.WriteLine(e.Message); }
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid Entry");
                            break;
                    }
                    anykey();
                }

                void anykey() {
                    Console.WriteLine("Press any key to go back to the menu");
                    Console.ReadKey();
                    MainMenu();
                }

                void CheckYear(int year)
                {
                if (year < 1900 || year > 2018)
                { throw new yearsException(year); }
                }
            
            }
        }
    }

