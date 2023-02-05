namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v11451 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Meals", name: "FoodInfo_FoodInfoID", newName: "FoodInfoID");
            RenameIndex(table: "dbo.Meals", name: "IX_FoodInfo_FoodInfoID", newName: "IX_FoodInfoID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Meals", name: "IX_FoodInfoID", newName: "IX_FoodInfo_FoodInfoID");
            RenameColumn(table: "dbo.Meals", name: "FoodInfoID", newName: "FoodInfo_FoodInfoID");
        }
    }
}
