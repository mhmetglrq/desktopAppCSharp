namespace Denwme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lale : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Synonmys", "SyName", c => c.String());
            DropColumn("dbo.Synonmys", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Synonmys", "Name", c => c.String());
            DropColumn("dbo.Synonmys", "SyName");
        }
    }
}
