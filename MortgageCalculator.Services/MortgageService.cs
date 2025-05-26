using MortgageCalculator.Dto;
using MortgageCalculator.MortgageData.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator.Services
{
    public interface IMortgageService
    {
        List<Mortgage> GetAllMortgages();
        List<Mortgage> GetActiveMortgages();
        List<Mortgage> GetActiveMortgagesByType(string mortgageType);
        List<string> GetMortgageTypes();
        List<string> GetRepaymentTypes();
        decimal GetInterestRateByNameAndType(int mortgageId, string mortgageType);
        MortgageCalculationResult CalculateMortgage(Mortgage request);
        int MonthWiseEMICalculator(Mortgage request);
        List<MonthlyEMIDetails> GetMonthlyEmiDetailsById(int mortgageId);


    }

    public class MortgageService : IMortgageService
    {

        private readonly IMortgageRepo _mortgageRepo;
        public MortgageService() : this(new MortgageRepo())
        { }

        public MortgageService(IMortgageRepo mortgageRepo)
        {
            this._mortgageRepo = mortgageRepo;
        }

        public List<Mortgage> GetAllMortgages()
        {
            return _mortgageRepo.GetAllMortgages();
        }

        public List<Mortgage> GetActiveMortgages()
        {
            return _mortgageRepo.GetActiveMortgage().OrderBy(m => m.MortgageType).ThenBy(m => m.InterestRate).ToList();
        }

        public decimal GetInterestRateByNameAndType(int mortgageId, string mortgageType)
        {
            return _mortgageRepo.GetInterestRateByNameAndType(mortgageId, mortgageType).FirstOrDefault();
        }

        public List<Mortgage> GetActiveMortgagesByType(string mortgageType)
        {
            return _mortgageRepo.GetActiveMortgagesByType(mortgageType)
           .OrderBy(m => m.MortgageType)
           .ThenBy(m => m.InterestRate).ToList();
        }

        public List<string> GetMortgageTypes()
        {
            return _mortgageRepo.GetMortgageTypes();
        }
        public List<string> GetRepaymentTypes()
        {
            return _mortgageRepo.GetRepaymentTypes();
        }
        

        //calculation part for mortgages, interest
        public MortgageCalculationResult CalculateMortgage(Mortgage request)
        {
            try
            {


                if (request.InterestRate != 0 && request.TermsInYears != 0 && request.LoanAmount != 0)
                {


                    decimal monthlyRate = request.InterestRate / 12 / 100;
                    int totalMonths = request.TermsInYears * 12;
                    request.TermsInMonths = totalMonths;
                    decimal monthlyPayment;

                    if (monthlyRate == 0)
                    {
                        monthlyPayment = request.LoanAmount / totalMonths;
                    }
                    else
                    {
                        monthlyPayment = request.LoanAmount *
                            monthlyRate *
                            (decimal)Math.Pow(1 + (double)monthlyRate, totalMonths) /
                            ((decimal)Math.Pow(1 + (double)monthlyRate, totalMonths) - 1);
                    }
                    monthlyPayment =  Math.Round(monthlyPayment, 2);
                    decimal totalRepayment = Math.Round(monthlyPayment * totalMonths, 2);
                    decimal totalInterest = Math.Round(totalRepayment - request.LoanAmount, 2);

                    return new MortgageCalculationResult
                    {
                        MonthlyPayment = monthlyPayment,
                        TotalRepayment = totalRepayment,
                        TotalInterest = totalInterest
                    };
                }
                else
                {
                    return new MortgageCalculationResult
                    {
                        MonthlyPayment = 0,
                        TotalRepayment = 0,
                        TotalInterest = 0
                    };
                }
            }
            catch (Exception e)
            {
                return new MortgageCalculationResult
                {
                    MonthlyPayment = 0,
                    TotalRepayment = 0,
                    TotalInterest = 0
                };
            }

        }


        public int MonthWiseEMICalculator(Mortgage request)
        {
            if (request.TermsInYears != 0 && request.LoanAmount != 0 && request.InterestRate != 0)
            {
                var emi = CalculateEMI(request.InterestRate, request.TermsInYears, request.LoanAmount);
                decimal monthlyRate = request.InterestRate / 12 / 100;
                int totalMonths = request.TermsInYears * 12;
                request.TermsInMonths = totalMonths;

                decimal balance = request.LoanAmount;
                decimal totalPrincipalPaid = 0;
                List<MonthlyEMIDetails> lstEmiDetails = new List<MonthlyEMIDetails>();

                request.EffectiveStartDate = DateTime.Now; // or a user-supplied start date
                request.EffectiveEndDate = request.EffectiveStartDate.AddMonths(totalMonths - 1);
                DateTime startDate = request.EffectiveStartDate;
                DateTime currentDate = startDate;

                for (int month = 1; month <= totalMonths; month++)
                {
                    decimal interest = (decimal)(balance * monthlyRate);
                    decimal principal = emi - interest;
                    balance -= principal;
                    totalPrincipalPaid += principal;

                    lstEmiDetails.Add(new MonthlyEMIDetails
                    {
                        Year = currentDate.ToString("yyyy"),
                        Month = currentDate.ToString("MMM"),
                        Principal = Math.Round(principal, 2),
                        Interest = Math.Round(interest, 2),
                        RemainingBalance = Math.Round(balance < 0 ? 0 : balance, 2),
                        LoanPaidPercentage = Math.Round((totalPrincipalPaid / request.LoanAmount) * 100, 2)
                    });

                    currentDate = currentDate.AddMonths(1);
                }

                request.CancellationFee = 0;
                request.EstablishmentFee = 0;
                request.MonthlyEMIDetails = lstEmiDetails;

                var savedDetails = _mortgageRepo.AddMortgage(request);
                return savedDetails.Result.MortgageId;

            }
            else
            {
                return 0;
            }



        }

        public decimal CalculateEMI(decimal InterestRate, int DurationYears, decimal LoanAmount)
        {
            decimal monthlyRate = InterestRate / 12 / 100;
            int totalMonths = DurationYears * 12;


            decimal emi = LoanAmount *
                           monthlyRate *
                           (decimal)Math.Pow(1 + (double)monthlyRate, totalMonths) /
                           ((decimal)Math.Pow(1 + (double)monthlyRate, totalMonths) - 1);

            return (decimal)Math.Round(emi, 2);
        }

        public List<MonthlyEMIDetails> GetMonthlyEmiDetailsById(int mortgageId)
        {
            return _mortgageRepo.GetMonthlyEmiDetailsById().Where(m => m.MortgageId == mortgageId)
                .OrderBy(m => m.MonthlyEMIId).ToList();
        }
    }
}
