namespace LMS_model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropcolAddress : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "User_address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "User_address", c => c.String());
        }
    }
}
