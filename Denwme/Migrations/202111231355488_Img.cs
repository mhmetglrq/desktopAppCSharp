namespace Denwme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Img : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Words", "ImgUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Words", "ImgUrl");
        }
    }
}
