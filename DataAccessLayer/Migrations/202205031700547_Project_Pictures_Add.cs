﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Project_Pictures_Add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProjectPictures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Picture = c.String(maxLength: 500),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProjectPictures");
        }
    }
}
