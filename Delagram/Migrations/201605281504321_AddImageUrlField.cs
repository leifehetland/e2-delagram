namespace Delagram.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImageUrlField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "ImageUrl");
        }
    }
}
