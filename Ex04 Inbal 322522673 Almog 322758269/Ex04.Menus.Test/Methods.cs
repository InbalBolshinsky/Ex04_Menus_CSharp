using System;
using Ex04.Menus.Interfaces;
namespace Ex04.Menus.Test
{
    public class Methods
    {
        public void ShowDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.ReadKey();
        }

        public void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.ReadKey();
        }

        public void ShowVersion()
        {
            Console.WriteLine("Version: 25.1.4.5480");
            Console.ReadKey();
        }

        public void CountLowercase()
        {
            int lowercaseCount = 0;
            string userSentence;

            Console.WriteLine("Please enter a sentence: ");
            userSentence = Console.ReadLine();

            while (userSentence == string.Empty)
            {
                Console.Clear();
                Console.WriteLine("Invalid input,Please enter a sentence:");
                userSentence = Console.ReadLine();
            }
            foreach (char letter in userSentence)
            {
                if (char.IsLower(letter))
                {
                    lowercaseCount++;
                }
            }
            string answer = string.Format("There are {0} lowercase letters in you text", lowercaseCount);
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }

    internal class ShowDateExecutable : IMenuAction
    {
        private readonly Methods r_Methods;

        public ShowDateExecutable(Methods i_Methods)
        {
            r_Methods = i_Methods;
        }
        public void Execute()
        {
            r_Methods.ShowDate();
        }
    }

    internal class ShowTimeExecutable : IMenuAction
    {
        private readonly Methods r_Methods;
        public ShowTimeExecutable(Methods i_Methods)
        {
            r_Methods = i_Methods;
        }

        public void Execute()
        {
            r_Methods.ShowTime();
        }
    }

    internal class ShowVersionExecutable : IMenuAction
    {
        private readonly Methods r_Methods;
        public ShowVersionExecutable(Methods i_Methods)
        {
            r_Methods = i_Methods;
        }

        public void Execute()
        {
            r_Methods.ShowVersion();
        }
    }

    internal class CountLowercasesExecutable : IMenuAction
    {
        private readonly Methods r_Methods;
        public CountLowercasesExecutable(Methods i_Methods)
        {
            r_Methods = i_Methods;
        }

        public void Execute()
        {
            r_Methods.CountLowercase();
        }
    }
}