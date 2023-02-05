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
                        VKE = c.Single(),
                        AGK = c.Single(),
                        UserHeight = c.Int(),
                        UserWeight = c.Int(),
                        CreatedDate = c.DateTime(nullable: false),
                        UserDetailID = c.Int(),
                    })
                .PrimaryKey(t => t.BodyAnalysisID)
                .ForeignKey("dbo.UserDetails", t => t.UserDetailID)
                .Index(t => t.UserDetailID);
            
            CreateTable(
                "dbo.UserDetails",
                c => new
                    {
                        UserDetailID = c.Int(nullable: false, identity: true),
                        BirthDate = c.DateTime(nullable: false),
                        gender = c.Int(nullable: false),
                        acitvityLevel = c.Int(),
                        intention = c.Int(),
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
                    })
                .PrimaryKey(t => t.FoodInfoID);
            
            CreateTable(
                "dbo.Meals",
                c => new
                    {
                        MealID = c.Int(nullable: false, identity: true),
                        MealType = c.Int(nullable: false),
                        TopKcall = c.Single(nullable: false),
                        TüketimTarihi = c.DateTime(nullable: false),
                        UserDetailID = c.Int(nullable: false),
                        FoodInfoID = c.Int(),
                    })
                .PrimaryKey(t => t.MealID)
                .ForeignKey("dbo.FoodInfoes", t => t.FoodInfoID)
                .ForeignKey("dbo.UserDetails", t => t.UserDetailID, cascadeDelete: true)
                .Index(t => t.UserDetailID)
                .Index(t => t.FoodInfoID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50),
                        UserSurname = c.String(nullable: false, maxLength: 50),
                        E_Mail = c.String(nullable: false, maxLength: 70),
                        KullanıcıSifre = c.String(nullable: false),
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
            DropForeignKey("dbo.Users", "UserDetailID", "dbo.UserDetails");
            DropForeignKey("dbo.Meals", "UserDetailID", "dbo.UserDetails");
            DropForeignKey("dbo.Meals", "FoodInfoID", "dbo.FoodInfoes");
            DropForeignKey("dbo.BodyAnalysis", "UserDetailID", "dbo.UserDetails");
            DropIndex("dbo.Users", new[] { "UserDetailID" });
            DropIndex("dbo.Meals", new[] { "FoodInfoID" });
            DropIndex("dbo.Meals", new[] { "UserDetailID" });
            DropIndex("dbo.BodyAnalysis", new[] { "UserDetailID" });
            DropTable("dbo.Users");
            DropTable("dbo.Meals");
            DropTable("dbo.FoodInfoes");
            DropTable("dbo.UserDetails");
            DropTable("dbo.BodyAnalysis");
        }
    }
}
