using System;
using Ex04.Menus.Tests;
using Ex04.Menus.Events;

namespace Ex04.Menus.Test
{
    internal class EventMenu
    {
        private MainMenu m_EventsMainMenu = new MainMenu();
        internal void startEventeMenu()
        {
            // Events-based menu
            Methods methods = new Methods();
            Events.Menu EventsMainMenu = new Events.Menu("Main Menu:Events", 0, "Exit", "Invalid input, try again.", true);
            Events.Menu versionAndCapitalsMenuDelegate = new Events.Menu("Version and Capitals", EventsMainMenu.Level + 1, "back", "Invalid input, try again.", true);
            Events.Menu showDateAndTimeMenuDelegate = new Events.Menu("Show Date/Time", EventsMainMenu.Level + 1, "back", "Invalid input, try again.", true);
            Events.ActionItem showVersionItem = new Events.ActionItem("Show Version");
            Events.ActionItem countCapitalsItem = new Events.ActionItem("Count Capitals");
            Events.ActionItem showDateItem = new Events.ActionItem("Show Date");
            Events.ActionItem showTimeItem = new Events.ActionItem("Show Time");

            EventsMainMenu.Add(versionAndCapitalsMenuDelegate);
            EventsMainMenu.Add(showDateAndTimeMenuDelegate);
            showVersionItem.ItemSelected += ShowVersion_Operate;
            countCapitalsItem.ItemSelected += CountCapitals_Operate;
            showDateItem.ItemSelected += ShowDate_Operate;
            showTimeItem.ItemSelected += ShowTime_Operate;
            versionAndCapitalsMenuDelegate.Add(showVersionItem);
            versionAndCapitalsMenuDelegate.Add(countCapitalsItem);
            showDateAndTimeMenuDelegate.Add(showDateItem);
            showDateAndTimeMenuDelegate.Add(showTimeItem);
            m_EventsMainMenu.Add(EventsMainMenu);

            try
            {
                m_EventsMainMenu.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ShowDate_Operate()
        {
            Methods methods = new Methods();
            methods.ShowDate();
        }

        private void ShowTime_Operate()
        {
            Methods methods = new Methods();
            methods.ShowTime();
        }
        private void ShowVersion_Operate()
        {
            Methods methods = new Methods();
            methods.ShowVersion();
        }
        private void CountCapitals_Operate()
        {
            Methods methods = new Methods();
            methods.CountCapitals();
        }
    }
}
