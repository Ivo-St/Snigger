namespace Snigger.Data
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SniggerDbContext : DbContext
    {
        public SniggerDbContext()
            : base("name=SniggerDbContext")
        {
        }

        public IDbSet<User> Users { get; set; }
        public IDbSet<Snicker> Snickers { get; set; }

    }
}