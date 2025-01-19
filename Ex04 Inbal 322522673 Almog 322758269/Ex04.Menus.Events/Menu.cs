using System;
using System.Collections.Generic;

namespace Ex04.Menus.Events
{
    public class Menu : MenuItem
    {

        private const int k_FirstLevel = 1;
        private readonly int r_CurrentLevel;
        private readonly List<MenuItem> r_MenuItems = new List<MenuItem>();
        private readonly string r_returnMenuKeyword;
        private readonly string r_errorMenuKeyword;
        private readonly bool r_showLevel;

        public int Level
        {
            get { return r_CurrentLevel; }
        }
        public Menu(string title, int level, string returnMassage, string errorMassage, bool showLevel) : base(title)
        {
            r_returnMenuKeyword = returnMassage;
            r_errorMenuKeyword = errorMassage;
            r_showLevel = showLevel;

            if (level == 0)
            {
                r_CurrentLevel = k_FirstLevel;
            }
            else
            {
                r_CurrentLevel = level;
            }

        }
        public void Add(MenuItem I_MenuItem)
        {
            r_MenuItems.Add(I_MenuItem);
        }


        public override void Execute()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine(Title);
                if (r_showLevel == true)
                {
                    Console.WriteLine($"[current menu level: {Level}]");
                }
                Console.WriteLine(new string('=', Title.Length));
                for (int i = 0; i < r_MenuItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {r_MenuItems[i].Title}");
                }
                Console.WriteLine($"0. {r_returnMenuKeyword}");

                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 0 && choice <= r_MenuItems.Count)
                {
                    if (choice == 0)
                    {
                        isRunning = false;
                    }
                    else
                    {
                        r_MenuItems[choice - 1].Execute();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"{r_errorMenuKeyword}");
                    Console.ReadLine();
                }
            }
        }
    }
}
