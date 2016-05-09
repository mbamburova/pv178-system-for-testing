namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class requiredTextofAnswer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Answers", "Question_Id", "dbo.Questions");
            DropIndex("dbo.Answers", new[] { "Question_Id" });
            AlterColumn("dbo.Answers", "Text", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Answers", "Question_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Answers", "Question_Id");
            AddForeignKey("dbo.Answers", "Question_Id", "dbo.Questions", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Answers", "Question_Id", "dbo.Questions");
            DropIndex("dbo.Answers", new[] { "Question_Id" });
            AlterColumn("dbo.Answers", "Question_Id", c => c.Int());
            AlterColumn("dbo.Answers", "Text", c => c.String(maxLength: 255));
            CreateIndex("dbo.Answers", "Question_Id");
            AddForeignKey("dbo.Answers", "Question_Id", "dbo.Questions", "Id");
        }
    }
}
