namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BodyAnalysis",
                c => new
                    {
                        BodyAnalysisID = c.Int(nullable: false, identity: true),
                        VKE = c.Int(nullable: false),
                        AGK = c.Int(nullable: false),
                        UserHeight = c.Int(nullable: false),
                        UserWeight = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UserDetailID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BodyAnalysisID)
                .ForeignKey("dbo.UserDetails", t => t.UserDetailID, cascadeDelete: true)
                .Index(t => t.UserDetailID);
            
            CreateTable(
                "dbo.UserDetails",
                c => new
                    {
                        UserDetailID = c.Int(nullable: false, identity: true),
                        BirthDate = c.DateTime(nullable: false),
                        gender = c.Int(nullable: false),
                        acitvityLevel = c.Int(nullable: false),
                        intention = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserDetailID);
            
            CreateTable(
                "dbo.FoodInfoes",
                c => new
                    {
                        FoodInfoID = c.Int(nullable: false, identity: true),
                        FoodName = c.String(nullable: false, maxLength: 50),
                        Gram = c.Single(nullable: false),
                        Kalori = c.Single(nullable: false),
                        Karbonhidrat = c.Single(nullable: false),
                        Protein = c.Single(nullable: false),
                        Yag = c.Single(nullable: false),
                        Meal_MealID = c.Int(),
                    })
                .PrimaryKey(t => t.FoodInfoID)
                .ForeignKey("dbo.Meals", t => t.Meal_MealID)
                .Index(t => t.Meal_MealID);
            
            CreateTable(
                "dbo.Meals",
                c => new
                    {
                        MealID = c.Int(nullable: false, identity: true),
                        MealType = c.Int(nullable: false),
                        TopKcall = c.Single(nullable: false),
                        TüketimTarihi = c.DateTime(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MealID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50),
                        UserSurname = c.String(nullable: false, maxLength: 50),
                        E_Mail = c.String(nullable: false, maxLength: 70),
                        KullanıcıSifre = c.String(nullable: false, maxLength: 50),
                        CreatedDate = c.DateTime(nullable: false),
                        userType = c.Int(nullable: false),
                        ImageURL = c.String(),
                        UserDetailID = c.Int(),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.UserDetails", t => t.UserDetailID)
                .Index(t => t.UserDetailID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Meals", "UserID", "dbo.Users");
            DropForeignKey("dbo.Users", "UserDetailID", "dbo.UserDetails");
            DropForeignKey("dbo.FoodInfoes", "Meal_MealID", "dbo.Meals");
            DropForeignKey("dbo.BodyAnalysis", "UserDetailID", "dbo.UserDetails");
            DropIndex("dbo.Users", new[] { "UserDetailID" });
            DropIndex("dbo.Meals", new[] { "UserID" });
            DropIndex("dbo.FoodInfoes", new[] { "Meal_MealID" });
            DropIndex("dbo.BodyAnalysis", new[] { "UserDetailID" });
            DropTable("dbo.Users");
            DropTable("dbo.Meals");
            DropTable("dbo.FoodInfoes");
            DropTable("dbo.UserDetails");
            DropTable("dbo.BodyAnalysis");
        }
    }
}
