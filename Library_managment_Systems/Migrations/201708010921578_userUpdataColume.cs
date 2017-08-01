namespace Library_managment_Systems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userUpdataColume : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Username", c => c.String(nullable: false));
            DropColumn("dbo.Users", "name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "name", c => c.String(nullable: false));
            DropColumn("dbo.Users", "Username");
        }
    }
}
