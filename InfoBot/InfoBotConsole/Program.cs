using System;
using InfoBotLibrary;

namespace InfoBotConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter player name or word");
            string name = Console.ReadLine();
            do
            {
                
                UserLookup lookup = new UserLookup();
                UserInfo info = new UserInfo();

                info = lookup.GetUserInfo(name);
                Console.WriteLine(info.Fact);
                Console.WriteLine(info.District);
                Console.WriteLine(info.ErrorMessage);
                name = Console.ReadLine();


            } while (name != "q");

            
            
        }

    }
}
