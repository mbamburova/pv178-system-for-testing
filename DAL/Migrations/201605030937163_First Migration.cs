namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(maxLength: 255),
                        IsCorrect = c.Boolean(nullable: false),
                        Question_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.Question_Id)
                .Index(t => t.Question_Id);
            
            AddColumn("dbo.ThematicFields", "Parent_Id", c => c.Int());
            AddColumn("dbo.TestPrefaces", "NumberOfQuestions", c => c.Int(nullable: false));
            AlterColumn("dbo.Questions", "Text", c => c.String(nullable: false));
            AlterColumn("dbo.ThematicFields", "Name", c => c.String(nullable: false));
            CreateIndex("dbo.ThematicFields", "Parent_Id");
            AddForeignKey("dbo.ThematicFields", "Parent_Id", "dbo.ThematicFields", "Id");
            DropColumn("dbo.Questions", "NumberOfCorrectAnswers");
            DropColumn("dbo.Questions", "Answer");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questions", "Answer", c => c.String());
            AddColumn("dbo.Questions", "NumberOfCorrectAnswers", c => c.Int(nullable: false));
            DropForeignKey("dbo.ThematicFields", "Parent_Id", "dbo.ThematicFields");
            DropForeignKey("dbo.Answers", "Question_Id", "dbo.Questions");
            DropIndex("dbo.ThematicFields", new[] { "Parent_Id" });
            DropIndex("dbo.Answers", new[] { "Question_Id" });
            AlterColumn("dbo.ThematicFields", "Name", c => c.String());
            AlterColumn("dbo.Questions", "Text", c => c.String());
            DropColumn("dbo.TestPrefaces", "NumberOfQuestions");
            DropColumn("dbo.ThematicFields", "Parent_Id");
            DropTable("dbo.Answers");
        }
    }
}
