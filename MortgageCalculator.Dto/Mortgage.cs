using System;

namespace MortgageCalculator.Dto
{
    public class Mortgage
    {
        public int MortgageId { get; set; }
        public string Name { get; set; }
        public MortgageType MortgageType { get; set; }
        public InterestRepayment InterestRepayment { get; set; }
        public DateTime EffectiveStartDate { get; set; }
        public DateTime EffectiveEndDate { get; set; }
        public int TermsInMonths { get; set; }
        public decimal CancellationFee { get; set; }
        public decimal EstablishmentFee { get; set; }
        public Guid SchemaIdentifier { get; internal set; }
        public decimal InterestRate { get; set; } 

    }

    public enum MortgageType
    {
        Variable,
        Fixed
    }

    public enum InterestRepayment
    {
        InterestOnly,
        PrincipalAndInterest
    }


    public class MortgageCalculationRequest
    {
        public decimal LoanAmount { get; set; }
        public decimal InterestRate { get; set; }
        public int DurationYears { get; set; }
    }

    // MortgageCalculationResult.cs
    public class MortgageCalculationResult
    {
        public decimal MonthlyPayment { get; set; }
        public decimal TotalRepayment { get; set; }
        public decimal TotalInterest { get; set; }
    }
}
