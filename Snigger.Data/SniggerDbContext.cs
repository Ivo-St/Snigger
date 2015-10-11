namespace Snigger.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SniggerDbContext : IdentityDbContext<User>
    {
        public SniggerDbContext()
            : base("name=SniggerDbContext")
        {
        }

        public static SniggerDbContext Create()
        {
            return new SniggerDbContext();
        }

        public IDbSet<Snicker> Snickers { get; set; }

    }
}