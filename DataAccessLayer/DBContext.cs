using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Model;

namespace DataAccessLayer
{
    public class DBContext : DbContext
    {
        public DbSet<Minion> Minions => Set<Minion>();
        public DBContext(string connectionstring) : base(new DbContextOptionsBuilder<DBContext>()
            .UseSqlServer(connectionstring).Options){}
    }
}
