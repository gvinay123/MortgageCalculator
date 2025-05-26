namespace MortgageCalculator.MortgageData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MonthlyEMIDetails", "Year", c => c.String());
            AlterColumn("dbo.MonthlyEMIDetails", "Month", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MonthlyEMIDetails", "Month", c => c.Int(nullable: false));
            AlterColumn("dbo.MonthlyEMIDetails", "Year", c => c.Int(nullable: false));
        }
    }
}
