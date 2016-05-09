namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correct2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TestPrefaces", "StudentGroups_Id", "dbo.StudentGroups");
            DropIndex("dbo.TestPrefaces", new[] { "StudentGroups_Id" });
            DropColumn("dbo.TestPrefaces", "StudentGroups_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TestPrefaces", "StudentGroups_Id", c => c.Int());
            CreateIndex("dbo.TestPrefaces", "StudentGroups_Id");
            AddForeignKey("dbo.TestPrefaces", "StudentGroups_Id", "dbo.StudentGroups", "Id");
        }
    }
}
