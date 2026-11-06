using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessLogic;
using Model;
using Ninject;

namespace WinFormsApp
{
    internal static class Program
    {
        private static ILogic _logic;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IKernel ninjectKernel = new StandardKernel(new DapperConfigModule());
            _logic = ninjectKernel.Get<Logic>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(_logic));
        }
    }
}
