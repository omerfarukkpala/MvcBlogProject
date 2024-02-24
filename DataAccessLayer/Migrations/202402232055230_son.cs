namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class son : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutID = c.Int(nullable: false, identity: true),
                        AboutContent1 = c.String(maxLength: 500),
                        AboutContent2 = c.String(maxLength: 500),
                        AboutImage1 = c.String(maxLength: 250),
                        AboutImage2 = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.AboutID);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 20),
                        AdminRole = c.String(maxLength: 1),
                        Password = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(maxLength: 50),
                        AuthorImage = c.String(maxLength: 250),
                        AuthorAbout = c.String(maxLength: 250),
                        AuthorTitle = c.String(maxLength: 50),
                        AuthorAboutShort = c.String(maxLength: 100),
                        AuthorMail = c.String(maxLength: 50),
                        AuthorPassword = c.String(maxLength: 50),
                        AuthorPhoneNumber = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuthorID);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogID = c.Int(nullable: false, identity: true),
                        BlogTitle = c.String(maxLength: 100),
                        BlogImage = c.String(maxLength: 250),
                        BlogImage2 = c.String(maxLength: 250),
                        BlogImage3 = c.String(maxLength: 250),
                        BlogDate = c.DateTime(nullable: false),
                        BlogContent = c.String(),
                        BlogRating = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        AuthorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BlogID)
                .ForeignKey("dbo.Authors", t => t.AuthorID, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID)
                .Index(t => t.AuthorID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 30),
                        CategoryDescription = c.String(maxLength: 500),
                        CategoryStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 50),
                        Mail = c.String(maxLength: 50),
                        CommentText = c.String(maxLength: 500),
                        CommentDate = c.DateTime(nullable: false),
                        CommentStatus = c.Boolean(nullable: false),
                        BlogRating = c.Int(nullable: false),
                        BlogID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommentID)
                .ForeignKey("dbo.Blogs", t => t.BlogID, cascadeDelete: true)
                .Index(t => t.BlogID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Surname = c.String(maxLength: 50),
                        Mail = c.String(maxLength: 50),
                        Subject = c.String(maxLength: 50),
                        Message = c.String(),
                        MessageDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ContactID);
            
            CreateTable(
                "dbo.SubscribeMails",
                c => new
                    {
                        MailID = c.Int(nullable: false, identity: true),
                        Mail = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MailID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "BlogID", "dbo.Blogs");
            DropForeignKey("dbo.Blogs", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Blogs", "AuthorID", "dbo.Authors");
            DropIndex("dbo.Comments", new[] { "BlogID" });
            DropIndex("dbo.Blogs", new[] { "AuthorID" });
            DropIndex("dbo.Blogs", new[] { "CategoryID" });
            DropTable("dbo.SubscribeMails");
            DropTable("dbo.Contacts");
            DropTable("dbo.Comments");
            DropTable("dbo.Categories");
            DropTable("dbo.Blogs");
            DropTable("dbo.Authors");
            DropTable("dbo.Admins");
            DropTable("dbo.Abouts");
        }
    }
}
