namespace LMS_model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newcolToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "User_address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "User_address");
        }
    }
}
