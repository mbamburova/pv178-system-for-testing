namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumberOfCorrectAnswers = c.Int(nullable: false),
                        Text = c.String(),
                        Answer = c.String(),
                        Points = c.Int(nullable: false),
                        Note = c.String(maxLength: 200),
                        ThematicField_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ThematicFields", t => t.ThematicField_Id)
                .Index(t => t.ThematicField_Id);
            
            CreateTable(
                "dbo.ThematicFields",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TestPreface_Id = c.Int(),
                        Teacher_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TestPrefaces", t => t.TestPreface_Id)
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id)
                .Index(t => t.TestPreface_Id)
                .Index(t => t.Teacher_Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Teacher_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id)
                .Index(t => t.Teacher_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Surname = c.String(maxLength: 30),
                        StudentGroup_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StudentGroups", t => t.StudentGroup_Id)
                .Index(t => t.StudentGroup_Id);
            
            CreateTable(
                "dbo.TestPrefaces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        TimeInMinutes = c.Int(nullable: false),
                        StudentGroups_Id = c.Int(),
                        Teacher_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StudentGroups", t => t.StudentGroups_Id)
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id)
                .Index(t => t.StudentGroups_Id)
                .Index(t => t.Teacher_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ThematicFields", "Teacher_Id", "dbo.Teachers");
            DropForeignKey("dbo.ThematicFields", "TestPreface_Id", "dbo.TestPrefaces");
            DropForeignKey("dbo.TestPrefaces", "Teacher_Id", "dbo.Teachers");
            DropForeignKey("dbo.TestPrefaces", "StudentGroups_Id", "dbo.StudentGroups");
            DropForeignKey("dbo.StudentGroups", "Teacher_Id", "dbo.Teachers");
            DropForeignKey("dbo.Students", "StudentGroup_Id", "dbo.StudentGroups");
            DropForeignKey("dbo.Questions", "ThematicField_Id", "dbo.ThematicFields");
            DropIndex("dbo.TestPrefaces", new[] { "Teacher_Id" });
            DropIndex("dbo.TestPrefaces", new[] { "StudentGroups_Id" });
            DropIndex("dbo.Students", new[] { "StudentGroup_Id" });
            DropIndex("dbo.StudentGroups", new[] { "Teacher_Id" });
            DropIndex("dbo.ThematicFields", new[] { "Teacher_Id" });
            DropIndex("dbo.ThematicFields", new[] { "TestPreface_Id" });
            DropIndex("dbo.Questions", new[] { "ThematicField_Id" });
            DropTable("dbo.TestPrefaces");
            DropTable("dbo.Students");
            DropTable("dbo.StudentGroups");
            DropTable("dbo.Teachers");
            DropTable("dbo.ThematicFields");
            DropTable("dbo.Questions");
        }
    }
}
