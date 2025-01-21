using System;
using System.Collections.Generic;
namespace Ex04.Menus.Events
{
    public class Menu : MenuItem
    {
        private const int k_FirstLevel = 1;
        private readonly int r_CurrentLevel;
        private readonly List<MenuItem> r_MenuItems = new List<MenuItem>();
        private readonly string r_ReturnMenuKeyword;
        private readonly string r_ErrorMenuKeyword;
        private readonly bool r_ShowLevel;
        public int Level
        {
            get { return r_CurrentLevel; }
        }

        public Menu(string i_Title, int i_Level, string i_ReturnMassage, string i_ErrorMassage, bool i_ShowLevel) : base(i_Title)
        {
            r_ReturnMenuKeyword = i_ReturnMassage;
            r_ErrorMenuKeyword = i_ErrorMassage;
            r_ShowLevel = i_ShowLevel;
            if (i_Level == 0)
            {
                r_CurrentLevel = k_FirstLevel;
            }
            else
            {
                r_CurrentLevel = i_Level;
            }
        }

        public void Add(MenuItem i_MenuItem)
        {
            r_MenuItems.Add(i_MenuItem);
        }

        public override void Execute()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine(Title);
                if (r_ShowLevel == true)
                {
                    Console.WriteLine($"[current menu level: {Level}]");
                }
                Console.WriteLine(new string('=', Title.Length));
                for (int i = 0; i < r_MenuItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {r_MenuItems[i].Title}");
                }
                Console.WriteLine($"0. {r_ReturnMenuKeyword}");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 0 && choice <= r_MenuItems.Count)
                {
                    if (choice == 0)
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.Clear();
                        r_MenuItems[choice - 1].Execute();
                    }
                }
                else
                {
                    Console.WriteLine($"{r_ErrorMenuKeyword}");
                    Console.ReadLine();
                }
            }
        }
    }
}