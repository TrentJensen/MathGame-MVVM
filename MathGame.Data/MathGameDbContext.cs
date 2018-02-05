using MathGame.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MathGame.Data
{
    public class MathGameDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }

        public MathGameDbContext() : base("MathGameDb")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
