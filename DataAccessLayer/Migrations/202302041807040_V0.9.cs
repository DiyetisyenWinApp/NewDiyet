﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V09 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "KullanıcıSifre", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "KullanıcıSifre", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
