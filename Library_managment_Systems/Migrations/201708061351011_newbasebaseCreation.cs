namespace Library_managment_Systems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newbasebaseCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.Books",
               c => new
               {
                   id = c.Int(nullable: false, identity: true),
                   title = c.String(),
                   SBIN = c.Int(nullable: false),
                   NumberOfCopied = c.Int(nullable: false),
                   describtion = c.String(),
               })
               .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.Users",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Username = c.String(nullable: false),
                    password = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Books");
        }
    }
}
