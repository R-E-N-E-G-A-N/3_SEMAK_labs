using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class Context : DbContext
    {

        public Context() : base("DBConnection") { }

        public DbSet<Quest> quests { get; set; }

    }
}
