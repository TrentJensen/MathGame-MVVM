namespace MathGame.Data.Migrations
{
<<<<<<< HEAD
=======
    using MathGame.Model;
>>>>>>> 80ce56c67b33c8237d3d9cd8796ffabd6214e0f4
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MathGame.Data.MathGameDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MathGame.Data.MathGameDbContext context)
        {
<<<<<<< HEAD
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
=======
            context.Players.AddOrUpdate(f => f.FirstName,
                new Player { FirstName = "Trent", LastName = "Jensen" },
                new Player { FirstName = "Elizabeth", LastName = "Jensen" }
                );
>>>>>>> 80ce56c67b33c8237d3d9cd8796ffabd6214e0f4
        }
    }
}
