namespace AcunMedyaAkademiAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "CategoryName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "CategoryName", c => c.Int(nullable: false));
        }
    }
}
