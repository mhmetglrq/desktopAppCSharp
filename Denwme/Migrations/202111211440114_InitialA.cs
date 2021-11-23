namespace Denwme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialA : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Words", "Sentences_Id", "dbo.Sentences");
            DropForeignKey("dbo.Words", "Synonmys_Id", "dbo.Synonmys");
            DropIndex("dbo.Words", new[] { "Sentences_Id" });
            DropIndex("dbo.Words", new[] { "Synonmys_Id" });
            AddColumn("dbo.Sentences", "Word_Id", c => c.Int());
            AddColumn("dbo.Synonmys", "Word_Id", c => c.Int());
            CreateIndex("dbo.Sentences", "Word_Id");
            CreateIndex("dbo.Synonmys", "Word_Id");
            AddForeignKey("dbo.Sentences", "Word_Id", "dbo.Words", "Id");
            AddForeignKey("dbo.Synonmys", "Word_Id", "dbo.Words", "Id");
            DropColumn("dbo.Words", "Sentences_Id");
            DropColumn("dbo.Words", "Synonmys_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Words", "Synonmys_Id", c => c.Int());
            AddColumn("dbo.Words", "Sentences_Id", c => c.Int());
            DropForeignKey("dbo.Synonmys", "Word_Id", "dbo.Words");
            DropForeignKey("dbo.Sentences", "Word_Id", "dbo.Words");
            DropIndex("dbo.Synonmys", new[] { "Word_Id" });
            DropIndex("dbo.Sentences", new[] { "Word_Id" });
            DropColumn("dbo.Synonmys", "Word_Id");
            DropColumn("dbo.Sentences", "Word_Id");
            CreateIndex("dbo.Words", "Synonmys_Id");
            CreateIndex("dbo.Words", "Sentences_Id");
            AddForeignKey("dbo.Words", "Synonmys_Id", "dbo.Synonmys", "Id");
            AddForeignKey("dbo.Words", "Sentences_Id", "dbo.Sentences", "Id");
        }
    }
}
