using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    internal class Context : DbContext
    {

        public Context() : base("DbConnection") { }

        public DbSet<User> Users { get; set; }

    }
}
