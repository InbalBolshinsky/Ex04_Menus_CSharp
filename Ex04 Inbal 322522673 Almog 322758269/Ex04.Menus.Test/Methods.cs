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
            int capitalsCount = 0;
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
                    capitalsCount++;
                }
            }
            string answer = string.Format("The sentence: \"{0}\" contains {1} lowercase letters.", userSentence, capitalsCount);
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

        public ShowTimeExecutable(Methods methods)
        {
            r_Methods = methods;
        }

        public void Execute()
        {
            r_Methods.ShowTime();
        }
    }
    internal class ShowVersionExecutable : IMenuAction
    {
        private readonly Methods r_Methods;

        public ShowVersionExecutable(Methods methods)
        {
            r_Methods = methods;
        }

        public void Execute()
        {
            r_Methods.ShowVersion();
        }
    }

    internal class CountCapitalsExecutable : IMenuAction
    {
        private readonly Methods r_Methods;

        public CountCapitalsExecutable(Methods methods)
        {
            r_Methods = methods;
        }

        public void Execute()
        {
            r_Methods.CountLowercase();
        }
    }
}

