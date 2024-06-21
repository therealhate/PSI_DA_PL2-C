using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICantina_v1.Models
{
    internal class CantinaContext : DbContext
    {
        public CantinaContext() : base("name=CantinaDB")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Clients)
                .WithRequired(c => c.User)
                .HasForeignKey(c => c.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
