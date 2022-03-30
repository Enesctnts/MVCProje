namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "AboutDetails1", c => c.String(maxLength: 1000));
            AddColumn("dbo.Abouts", "AboutDetails2", c => c.String(maxLength: 1000));
            AddColumn("dbo.Abouts", "Image2", c => c.String(maxLength: 100));
            AddColumn("dbo.Writers", "WriterImage", c => c.String(maxLength: 100));
            DropColumn("dbo.Abouts", "AboutDetails");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Abouts", "AboutDetails", c => c.String(maxLength: 1000));
            DropColumn("dbo.Writers", "WriterImage");
            DropColumn("dbo.Abouts", "Image2");
            DropColumn("dbo.Abouts", "AboutDetails2");
            DropColumn("dbo.Abouts", "AboutDetails1");
        }
    }
}
