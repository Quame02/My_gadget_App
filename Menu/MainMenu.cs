using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A_Gadget_Store_App.Entities;
using A_Gadget_Store_App.Enum;
using A_Gadget_Store_App.Menu;
using A_Gadget_Store_App.Repo;

namespace A_Gadget_Store_App.Menu
{
    public class MainMenu
    { 
        public Iinterface infoService = new InfoService();
        public static void Main_Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Welcome to ---ELIBASH COLLECTIBLES--- your number one gadget plug in Nigeria.n(**hot deals,best price**)");
            Console.WriteLine("1. to create an account\n2. to login\n0. to exit");
        }
        public void Login_Page()
        {
            MainMenu.Main_Menu();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter your option: ");
            string opt = Console.ReadLine();

            switch (opt)
            {
               case "1":
               var info =  infoService.Create();
               Console.WriteLine(info);
               Order.OrderMethod();
               break;
               case "2":
               Console.WriteLine("Enter code: ");
               string code = Console.ReadLine();
               Console.WriteLine("Enter code: ");
               string password = Console.ReadLine();
               var login = infoService.Login(code, password);
               Console.WriteLine(login);
               Order.OrderMethod();
               break;
               case "0":
               Console.ForegroundColor = ConsoleColor.White;
               Console.WriteLine("Thanks for Shopping from us...We are looking forward to serve you better some other time.");
               break;
            }
        }
    }
    
}