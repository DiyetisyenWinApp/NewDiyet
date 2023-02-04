namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V02 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BodyAnalysis", "VKE", c => c.Single(nullable: false));
            AlterColumn("dbo.BodyAnalysis", "AGK", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BodyAnalysis", "AGK", c => c.Int(nullable: false));
            AlterColumn("dbo.BodyAnalysis", "VKE", c => c.Int(nullable: false));
        }
    }
}
