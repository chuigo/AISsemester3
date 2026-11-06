using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Model;
using Ninject.Modules;

namespace BuisnessLogic
{

    public class DapperConfigModule : NinjectModule
    {
        private const string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jarri\source\repos\AISsemester3\DataAccessLayer\Database1.mdf;Integrated Security=True";
        public override void Load()
        {
           Bind<IRepository<Minion>>().To<DapperRepository<Minion>>().InSingletonScope().WithConstructorArgument("connectionstring", connectionstring);
            Bind<IBuisnessFunctionLogic>().To<BFLogic>().InSingletonScope();
            Bind<ILogic>().To<Logic>().InSingletonScope();
            
        }
    }
}
