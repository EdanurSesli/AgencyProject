namespace AcunMedyaAkademiAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_101 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "aboutDate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "aboutDate");
        }
    }
}
