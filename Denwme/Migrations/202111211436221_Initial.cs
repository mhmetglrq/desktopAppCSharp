namespace Denwme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sentences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sentences = c.String(),
                        Meaning = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Synonmys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Meaning = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Words",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Meaning = c.String(),
                        Sentences_Id = c.Int(),
                        Synonmys_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sentences", t => t.Sentences_Id)
                .ForeignKey("dbo.Synonmys", t => t.Synonmys_Id)
                .Index(t => t.Sentences_Id)
                .Index(t => t.Synonmys_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Words", "Synonmys_Id", "dbo.Synonmys");
            DropForeignKey("dbo.Words", "Sentences_Id", "dbo.Sentences");
            DropIndex("dbo.Words", new[] { "Synonmys_Id" });
            DropIndex("dbo.Words", new[] { "Sentences_Id" });
            DropTable("dbo.Words");
            DropTable("dbo.Synonmys");
            DropTable("dbo.Sentences");
        }
    }
}
