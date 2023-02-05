namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V10 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FoodInfoes", "Meal_MealID", "dbo.Meals");
            DropIndex("dbo.FoodInfoes", new[] { "Meal_MealID" });
            AddColumn("dbo.Meals", "FoodInfo_FoodInfoID", c => c.Int());
            CreateIndex("dbo.Meals", "FoodInfo_FoodInfoID");
            AddForeignKey("dbo.Meals", "FoodInfo_FoodInfoID", "dbo.FoodInfoes", "FoodInfoID");
            DropColumn("dbo.FoodInfoes", "Meal_MealID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FoodInfoes", "Meal_MealID", c => c.Int());
            DropForeignKey("dbo.Meals", "FoodInfo_FoodInfoID", "dbo.FoodInfoes");
            DropIndex("dbo.Meals", new[] { "FoodInfo_FoodInfoID" });
            DropColumn("dbo.Meals", "FoodInfo_FoodInfoID");
            CreateIndex("dbo.FoodInfoes", "Meal_MealID");
            AddForeignKey("dbo.FoodInfoes", "Meal_MealID", "dbo.Meals", "MealID");
        }
    }
}
