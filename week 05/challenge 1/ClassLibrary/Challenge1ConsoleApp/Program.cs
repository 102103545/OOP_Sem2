using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Challenge1ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Square> Squares = new List<Square>();
            List<Rectangle> Rectangles = new List<Rectangle>();
            List<RightAngleTriangle> RightAngles = new List<RightAngleTriangle>();
            List<EquilateralTriangle> Equilaterals = new List<EquilateralTriangle>();
            MainMenu();
            void MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Welcome\n1. Create Square\n2. Create Rectangle\n3. Create Right Angled Triangle\n4. Create Equilateral Triangle\n5. View Square\n6. View Rectangle\n7. View Right Angle Triangle\n8. View Equilateral Triangle\n9. Exit");
                char input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case '1':
                        CreateSquare();
                        break;
                    case '2':
                        CreateRectangle();
                        break;
                    case '3':
                        createRightAngle();
                        break;
                    case '4':
                        createEquilateral();
                        break;
                    case '5':
                        ViewSquare();
                        break;
                    case '6':
                        ViewRectangle();
                        break;
                    case '7':
                        ViewRightAngle();
                        break;
                    case '8':
                        ViewEquilateral();
                        break;
                    case '9':
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Entry");
                        anykey();
                        break;
                }
                void anykey()
                {
                    Console.WriteLine("Press any key to go back to the menu");
                    Console.ReadKey();
                    MainMenu();
                }
                void CreateSquare()
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("enter Colour");
                        string colour = Console.ReadLine();
                        Console.WriteLine("enter Side 1 Length");
                        int side1Length = int.Parse(Console.ReadLine());
                        CheckLength(side1Length);
                        Squares.Add(new Square(colour, side1Length));
                        Console.WriteLine("square created");
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }
                    anykey();
                }

                void CreateRectangle()
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("enter Colour");
                        string colour = Console.ReadLine();
                        Console.WriteLine("enter Side 1 Length");
                        int side1Length = int.Parse(Console.ReadLine());
                        CheckLength(side1Length);
                        Console.WriteLine("enter Side 2 Length");
                        int side2Length = int.Parse(Console.ReadLine());
                        CheckLength(side2Length);
                        Rectangles.Add(new Rectangle(colour, side1Length,side2Length));
                        Console.WriteLine("Rectangle created");
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }
                    anykey();
                }

                void createRightAngle()
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("enter Colour");
                        string colour = Console.ReadLine();
                        Console.WriteLine("enter Side 1 Length");
                        int side1Length = int.Parse(Console.ReadLine());
                        CheckLength(side1Length);
                        Console.WriteLine("enter Side 2 Length");
                        int side2Length = int.Parse(Console.ReadLine());
                        CheckLength(side2Length);
                        RightAngles.Add(new RightAngleTriangle(colour, side1Length,side2Length));
                        Console.WriteLine("Right Angle Triangle created");
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }
                    anykey();
                }

                void createEquilateral()
                {

                    try
                    {
                        Console.Clear();
                        Console.WriteLine("enter Colour");
                        string colour = Console.ReadLine();
                        Console.WriteLine("enter Side 1 Length");
                        int side1Length = int.Parse(Console.ReadLine());
                        CheckLength(side1Length);
                        Equilaterals.Add(new EquilateralTriangle(colour, side1Length));
                        Console.WriteLine("Equilateral Triangle created");
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }
                    anykey();
                }

                void ViewSquare()
                {
                    Console.Clear();
                    Console.WriteLine("Enter Index of Square");
                    try
                    {
                        int index = int.Parse(Console.ReadLine());
                        Console.WriteLine("colour: " + Squares[index].colour + "\nSide1:" + Squares[index].Side1Length + "\nSide2: " + Squares[index].Side2Length + "\nSide3: " + Squares[index].Side3Length + "\nSide4: " + Squares[index].Side4Length + "\nArea: " + Squares[index].GetArea());
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }
                    anykey();
                }

                void ViewRectangle()
                {
                    Console.Clear();
                    Console.WriteLine("Enter Index of Rectangle");
                    try
                    {
                        int index = int.Parse(Console.ReadLine());
                        Console.WriteLine("colour: "+Rectangles[index].colour + "\nSide1:" + Rectangles[index].Side1Length + "\nSide2: " + Rectangles[index].Side2Length + "\nSide3: " + Rectangles[index].Side3Length + "\nSide4: " + Rectangles[index].Side4Length+"\nArea: "+Rectangles[index].GetArea());
                        
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }
                    anykey();
                }

                void ViewRightAngle()
                {
                    Console.Clear();
                    Console.WriteLine("Enter Index of Right Angled Triangle");
                    try
                    {
                        int index = int.Parse(Console.ReadLine());
                        Console.WriteLine("Colour: " + RightAngles[index].colour + "\nSide1:" + RightAngles[index].Side1Length + "\nSide2: " + RightAngles[index].Side2Length + "\nSide3: " + RightAngles[index].Side3Length+"\nArea: "+RightAngles[index].GetArea());
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }
                    anykey();
                }

                void ViewEquilateral()
                {

                    Console.Clear();
                    Console.WriteLine("Enter Index of Equilateral Triangle");
                    try
                    {
                        int index = int.Parse(Console.ReadLine());
                        Console.WriteLine("Colour: " + Equilaterals[index].colour + "\nSide1:" + Equilaterals[index].Side1Length + "\nSide2: " + Equilaterals[index].Side2Length + "\nSide3: " + Equilaterals[index].Side3Length+"\nArea: "+Equilaterals[index].GetArea());
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }
                    anykey();
                }

                void CheckLength(int side)
                {
                    if (side < 1)
                    { throw new LengthException(side); }
                }
            }
        }
    }
}
