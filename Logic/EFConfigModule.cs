using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Model;
using Ninject.Modules;

namespace BuisnessLogic
{

    public class EFConfigModule : NinjectModule
    {
        private const string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chuigo\source\repos\AISsemester3\DataAccessLayer\Database1.mdf;Integrated Security=True";
        public override void Load()
        {
            Bind<IRepository<Minion>>().To<EntityRepository<Minion>>().InSingletonScope().WithConstructorArgument("connectionstring", connectionstring);
            Bind<IBuisnessFunctionLogic>().To<BFLogic>().InSingletonScope();
        }
    }
}
