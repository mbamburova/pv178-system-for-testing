namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correct3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TestPrefaces", "StudentGroups_Id", c => c.Int());
            CreateIndex("dbo.TestPrefaces", "StudentGroups_Id");
            AddForeignKey("dbo.TestPrefaces", "StudentGroups_Id", "dbo.StudentGroups", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TestPrefaces", "StudentGroups_Id", "dbo.StudentGroups");
            DropIndex("dbo.TestPrefaces", new[] { "StudentGroups_Id" });
            DropColumn("dbo.TestPrefaces", "StudentGroups_Id");
        }
    }
}
