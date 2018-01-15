namespace MathGame.Data.Migrations
{
    using MathGame.Model;
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
            context.Players.AddOrUpdate(f => f.FirstName,
                new Player { FirstName = "Trent", LastName = "Jensen" },
                new Player { FirstName = "Elizabeth", LastName = "Jensen" }
                );
        }
    }
}
