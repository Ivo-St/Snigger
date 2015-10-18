namespace Snigger.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using Migrations;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SniggerDbContext : IdentityDbContext<User>
    {
        public SniggerDbContext()
            : base("name=SniggerDbContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SniggerDbContext, Configuration>());
        }

        public static SniggerDbContext Create()
        {
            return new SniggerDbContext();
        }

        public IDbSet<Snicker> Snigger { get; set; }

    }
}