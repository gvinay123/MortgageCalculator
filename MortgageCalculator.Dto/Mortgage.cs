using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MortgageCalculator.Dto
{
    public class Mortgage
    {
        [Key] 
        public int MortgageId { get; set; }
        public string Name { get; set; }
        public MortgageType MortgageType { get; set; }
        public InterestRepayment InterestRepayment { get; set; }
        public DateTime EffectiveStartDate { get; set; }
        public DateTime EffectiveEndDate { get; set; }
        public int TermsInMonths { get; set; }
        public int TermsInYears { get; set; }
        public decimal LoanAmount { get; set; }
        public decimal CancellationFee { get; set; }
        public decimal EstablishmentFee { get; set; }
        public Guid SchemaIdentifier { get; internal set; }
        public decimal InterestRate { get; set; }
        public ICollection<MonthlyEMIDetails> MonthlyEMIDetails { get; set; }

    }


    public class MonthlyEMIDetails
    {
        [Key] 
        public int MonthlyEMIId { get; set; }


        [ForeignKey(nameof(mortgageRef))]
        public int MortgageId { get; set; }
        public Mortgage mortgageRef { get; set; }

        public string Year { get; set; }
        public string Month { get; set; }
        public decimal Principal { get; set; }
        public decimal Interest { get; set; }
        public decimal RemainingBalance { get; set; }
        public decimal LoanPaidPercentage { get; set; }

        [NotMapped]
        public decimal TotalPayment => Principal + Interest;

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



    // MortgageCalculationResult.cs
    public class MortgageCalculationResult
    {
        public decimal MonthlyPayment { get; set; }
        public decimal TotalRepayment { get; set; }
        public decimal TotalInterest { get; set; }
    }
  

}
