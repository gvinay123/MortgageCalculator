namespace MortgageCalculator.MortgageData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MonthlyEMIDetails",
                c => new
                    {
                        MonthlyEMIId = c.Int(nullable: false, identity: true),
                        MortgageId = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        Principal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Interest = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RemainingBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LoanPaidPercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MonthlyEMIId)
                .ForeignKey("dbo.Mortgages", t => t.MortgageId, cascadeDelete: true)
                .Index(t => t.MortgageId);
            
            CreateTable(
                "dbo.Mortgages",
                c => new
                    {
                        MortgageId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MortgageType = c.Int(nullable: false),
                        InterestRepayment = c.Int(nullable: false),
                        EffectiveStartDate = c.DateTime(nullable: false),
                        EffectiveEndDate = c.DateTime(nullable: false),
                        TermsInMonths = c.Int(nullable: false),
                        TermsInYears = c.Int(nullable: false),
                        LoanAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CancellationFee = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EstablishmentFee = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SchemaIdentifier = c.Guid(nullable: false),
                        InterestRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MortgageId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MonthlyEMIDetails", "MortgageId", "dbo.Mortgages");
            DropIndex("dbo.MonthlyEMIDetails", new[] { "MortgageId" });
            DropTable("dbo.Mortgages");
            DropTable("dbo.MonthlyEMIDetails");
        }
    }
}
