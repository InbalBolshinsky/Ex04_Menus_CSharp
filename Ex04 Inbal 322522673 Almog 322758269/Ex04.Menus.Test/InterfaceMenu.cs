using System;
using Ex04.Menus.Interfaces;
using Ex04.Menus.Tests;

namespace Ex04.Menus.Test
{
    internal class InterfacesMenu
    {
        private MainMenu m_InterfacesMainMenu = new MainMenu();
        internal void StartInterfaceMenu()
        {
            Methods methods = new Methods();
            Interfaces.Menu InterfacesMainMenu = new Interfaces.Menu("Main Menu: Interfaces", 0, "Exit", "Invalid input, try again.", true);
            Interfaces.Menu versionAndCapitalsMenu = new Interfaces.Menu("Letters and Version", InterfacesMainMenu.Level + 1, "back", "Invalid input, try again.", true);
            Interfaces.Menu showDateAndTimeMenu = new Interfaces.Menu("Show Date/Time", InterfacesMainMenu.Level + 1, "back", "Invalid input, try again.", true);

            InterfacesMainMenu.Add(versionAndCapitalsMenu);
            InterfacesMainMenu.Add(showDateAndTimeMenu);
            versionAndCapitalsMenu.Add(new Interfaces.ActionItem("Show Version", new ShowVersionExecutable(methods)));
            versionAndCapitalsMenu.Add(new Interfaces.ActionItem("Count Lowercase Letters", new CountCapitalsExecutable(methods)));
            showDateAndTimeMenu.Add(new Interfaces.ActionItem("Show Current Date", new ShowDateExecutable(methods)));
            showDateAndTimeMenu.Add(new Interfaces.ActionItem("Show Current Time", new ShowTimeExecutable(methods)));
            m_InterfacesMainMenu.Add(InterfacesMainMenu);

            try
            {
                m_InterfacesMainMenu.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
