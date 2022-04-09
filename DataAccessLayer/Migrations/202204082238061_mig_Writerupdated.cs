namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_Writerupdated : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Writers", "WriterAbout", c => c.String(maxLength: 250));
            AlterColumn("dbo.Writers", "Password", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Writers", "Password", c => c.String(maxLength: 200));
            AlterColumn("dbo.Writers", "WriterAbout", c => c.String(maxLength: 100));
        }
    }
}
