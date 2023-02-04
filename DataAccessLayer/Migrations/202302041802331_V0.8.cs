namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V08 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BodyAnalysis", "UserDetailID", "dbo.UserDetails");
            DropIndex("dbo.BodyAnalysis", new[] { "UserDetailID" });
            AlterColumn("dbo.BodyAnalysis", "UserDetailID", c => c.Int());
            CreateIndex("dbo.BodyAnalysis", "UserDetailID");
            AddForeignKey("dbo.BodyAnalysis", "UserDetailID", "dbo.UserDetails", "UserDetailID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BodyAnalysis", "UserDetailID", "dbo.UserDetails");
            DropIndex("dbo.BodyAnalysis", new[] { "UserDetailID" });
            AlterColumn("dbo.BodyAnalysis", "UserDetailID", c => c.Int(nullable: false));
            CreateIndex("dbo.BodyAnalysis", "UserDetailID");
            AddForeignKey("dbo.BodyAnalysis", "UserDetailID", "dbo.UserDetails", "UserDetailID", cascadeDelete: true);
        }
    }
}
