namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V06 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BodyAnalysis", "VKE", c => c.Single());
            AlterColumn("dbo.BodyAnalysis", "UserHeight", c => c.Int());
            AlterColumn("dbo.BodyAnalysis", "UserWeight", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BodyAnalysis", "UserWeight", c => c.Int(nullable: false));
            AlterColumn("dbo.BodyAnalysis", "UserHeight", c => c.Int(nullable: false));
            AlterColumn("dbo.BodyAnalysis", "VKE", c => c.Single(nullable: false));
        }
    }
}
