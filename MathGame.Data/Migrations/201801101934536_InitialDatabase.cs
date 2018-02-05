namespace MathGame.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Player",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        AddScore = c.Int(),
                        AddTime = c.Int(),
                        SubScore = c.Int(),
                        SubTime = c.Int(),
                        MultScore = c.Int(),
                        MultTime = c.Int(),
                        DivScore = c.Int(),
                        DivTime = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Player");
        }
    }
}
