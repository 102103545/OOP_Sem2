using System;

namespace week01project01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Game game = new Game("Warframe",500.0,"Shooter Looter","Action");
            game.ReviewGame(10);

            Cookie cookie = new Cookie(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), DateTime.Parse(Console.ReadLine()));
            Console.WriteLine(cookie.ToString());
            if (cookie.isExpired())
            { Console.WriteLine("cookie is expired"); }
            Console.ReadLine();

        }
    }
}
