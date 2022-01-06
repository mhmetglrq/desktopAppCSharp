namespace Denwme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sentences", "Word_Id", "dbo.Words");
            DropForeignKey("dbo.Synonmys", "Word_Id", "dbo.Words");
            DropIndex("dbo.Sentences", new[] { "Word_Id" });
            DropIndex("dbo.Synonmys", new[] { "Word_Id" });
            RenameColumn(table: "dbo.Sentences", name: "Word_Id", newName: "WordId");
            RenameColumn(table: "dbo.Synonmys", name: "Word_Id", newName: "WordId");
            AlterColumn("dbo.Sentences", "WordId", c => c.Int(nullable: false));
            AlterColumn("dbo.Synonmys", "WordId", c => c.Int(nullable: false));
            CreateIndex("dbo.Sentences", "WordId");
            CreateIndex("dbo.Synonmys", "WordId");
            AddForeignKey("dbo.Sentences", "WordId", "dbo.Words", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Synonmys", "WordId", "dbo.Words", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Synonmys", "WordId", "dbo.Words");
            DropForeignKey("dbo.Sentences", "WordId", "dbo.Words");
            DropIndex("dbo.Synonmys", new[] { "WordId" });
            DropIndex("dbo.Sentences", new[] { "WordId" });
            AlterColumn("dbo.Synonmys", "WordId", c => c.Int());
            AlterColumn("dbo.Sentences", "WordId", c => c.Int());
            RenameColumn(table: "dbo.Synonmys", name: "WordId", newName: "Word_Id");
            RenameColumn(table: "dbo.Sentences", name: "WordId", newName: "Word_Id");
            CreateIndex("dbo.Synonmys", "Word_Id");
            CreateIndex("dbo.Sentences", "Word_Id");
            AddForeignKey("dbo.Synonmys", "Word_Id", "dbo.Words", "Id");
            AddForeignKey("dbo.Sentences", "Word_Id", "dbo.Words", "Id");
        }
    }
}
