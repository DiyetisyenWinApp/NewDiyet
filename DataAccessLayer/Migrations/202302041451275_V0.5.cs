namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V05 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BodyAnalysis", "AGK", c => c.Single());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BodyAnalysis", "AGK", c => c.Single(nullable: false));
        }
    }
}
