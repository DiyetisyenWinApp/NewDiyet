namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V04 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserDetails", "acitvityLevel", c => c.Int());
            AlterColumn("dbo.UserDetails", "intention", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserDetails", "intention", c => c.Int(nullable: false));
            AlterColumn("dbo.UserDetails", "acitvityLevel", c => c.Int(nullable: false));
        }
    }
}
