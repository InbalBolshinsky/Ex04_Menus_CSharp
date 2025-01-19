using System;
using Ex04.Menus.Test;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            InterfacesMenu interfacesMenu = new InterfacesMenu();
            EventsMenu eventMenus = new EventsMenu();

            interfacesMenu.StartInterfaceMenu();
            eventMenus.startEventeMenu();
        }
    }
}
