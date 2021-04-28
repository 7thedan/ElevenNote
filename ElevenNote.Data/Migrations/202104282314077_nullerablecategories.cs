namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullerablecategories : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Notes", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Notes", new[] { "CategoryID" });
            AlterColumn("dbo.Notes", "CategoryID", c => c.Int());
            CreateIndex("dbo.Notes", "CategoryID");
            AddForeignKey("dbo.Notes", "CategoryID", "dbo.Categories", "CategoryID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notes", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Notes", new[] { "CategoryID" });
            AlterColumn("dbo.Notes", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Notes", "CategoryID");
            AddForeignKey("dbo.Notes", "CategoryID", "dbo.Categories", "CategoryID", cascadeDelete: true);
        }
    }
}
