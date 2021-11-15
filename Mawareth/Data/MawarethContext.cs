using System;
using System.Data.Entity;
using System.Linq;

namespace Mawareth.Data
{
    public class MawarethContext : DbContext
    {
        public MawarethContext()
            : base("name=MawarethContext")
        {
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Issue> Issues { get; set; }
        public virtual DbSet<Dead> Deads { get; set; }
        public virtual DbSet<ContactUs> ContactUs { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
    }
}