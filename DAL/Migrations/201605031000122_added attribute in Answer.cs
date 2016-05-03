namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedattributeinAnswer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Answers", "IsCorrect", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Answers", "IsCorrect");
        }
    }
}
