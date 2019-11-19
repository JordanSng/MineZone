using System;
using  System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniBicks.Data.Models;

namespace MiniBicks.Data
{
    public class Context : DbContext
    {
        public Context()
            : base("data source=(localdb)\\mssqllocaldb;initial catalog=Minibicks;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }
        public  DbSet<Utilisateur> Utilisateurs { get; set; }
    }
}
