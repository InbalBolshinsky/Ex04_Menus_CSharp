using System;
using Ex04.Menus.Test;

namespace Ex04.Menus.Tests
{
    public class Program
    {
        public static void Main()
        {
            InterfacesMenu interfacesMenu = new InterfacesMenu();
            EventMenu eventMenus = new EventMenu();

            interfacesMenu.StartInterfaceMenu();
            eventMenus.startEventeMenu();
        }
    }
}
