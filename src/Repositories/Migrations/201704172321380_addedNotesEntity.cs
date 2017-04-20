namespace EDeviceClaims.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedNotesEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "App.notes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ClaimEntity_ID = c.Guid(nullable: false),
                        AuthorizedUser_Id = c.String(maxLength: 128),
                        Content = c.String(),
                        WhenCreated = c.DateTime(nullable: false),
                        WhenLastModified = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("app.claims", t => t.ClaimEntity_ID, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.AuthorizedUser_Id)
                .Index(t => t.ClaimEntity_ID)
                .Index(t => t.AuthorizedUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("App.notes", "AuthorizedUser_Id", "dbo.AspNetUsers");
            DropForeignKey("App.notes", "ClaimEntity_ID", "app.claims");
            DropIndex("App.notes", new[] { "AuthorizedUser_Id" });
            DropIndex("App.notes", new[] { "ClaimEntity_ID" });
            DropTable("App.notes");
        }
    }
}
