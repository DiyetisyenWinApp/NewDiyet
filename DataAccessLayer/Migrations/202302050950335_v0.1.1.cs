namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v011 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Meals", "UserID", "dbo.Users");
            DropForeignKey("dbo.Meals", "FoodInfo_FoodInfoID", "dbo.FoodInfoes");
            DropIndex("dbo.Meals", new[] { "UserID" });
            DropIndex("dbo.Meals", new[] { "FoodInfo_FoodInfoID" });
            CreateTable(
                "dbo.MealFoodInfoes",
                c => new
                    {
                        Meal_MealID = c.Int(nullable: false),
                        FoodInfo_FoodInfoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Meal_MealID, t.FoodInfo_FoodInfoID })
                .ForeignKey("dbo.Meals", t => t.Meal_MealID, cascadeDelete: true)
                .ForeignKey("dbo.FoodInfoes", t => t.FoodInfo_FoodInfoID, cascadeDelete: true)
                .Index(t => t.Meal_MealID)
                .Index(t => t.FoodInfo_FoodInfoID);
            
            AddColumn("dbo.Meals", "UserDetailID", c => c.Int(nullable: false));
            CreateIndex("dbo.Meals", "UserDetailID");
            AddForeignKey("dbo.Meals", "UserDetailID", "dbo.UserDetails", "UserDetailID", cascadeDelete: true);
            DropColumn("dbo.Meals", "UserID");
            DropColumn("dbo.Meals", "FoodInfo_FoodInfoID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Meals", "FoodInfo_FoodInfoID", c => c.Int());
            AddColumn("dbo.Meals", "UserID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Meals", "UserDetailID", "dbo.UserDetails");
            DropForeignKey("dbo.MealFoodInfoes", "FoodInfo_FoodInfoID", "dbo.FoodInfoes");
            DropForeignKey("dbo.MealFoodInfoes", "Meal_MealID", "dbo.Meals");
            DropIndex("dbo.MealFoodInfoes", new[] { "FoodInfo_FoodInfoID" });
            DropIndex("dbo.MealFoodInfoes", new[] { "Meal_MealID" });
            DropIndex("dbo.Meals", new[] { "UserDetailID" });
            DropColumn("dbo.Meals", "UserDetailID");
            DropTable("dbo.MealFoodInfoes");
            CreateIndex("dbo.Meals", "FoodInfo_FoodInfoID");
            CreateIndex("dbo.Meals", "UserID");
            AddForeignKey("dbo.Meals", "FoodInfo_FoodInfoID", "dbo.FoodInfoes", "FoodInfoID");
            AddForeignKey("dbo.Meals", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
        }
    }
}
