using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BuisnessLogic;
using Model;
using Ninject;


namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            IKernel ninjectKernel = new StandardKernel(new DapperConfigModule());
            Logic logic = ninjectKernel.Get<Logic>();
            GameSession gameSession = new GameSession(logic);
            ShowPrehistory();
            MenuView menuView = new MenuView(logic, gameSession);
            menuView.RenderScreen();
        }
        private static void ShowPrehistory()
        {
            string prehistory = "Грю устал считать своих приспешников, поэтому попросил вас составить учет всех миньонов";
            foreach (var c in prehistory)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Thread.Sleep(1000);
            while (Console.KeyAvailable) Console.ReadKey(true);
            Console.Clear();
        }
    }
}
