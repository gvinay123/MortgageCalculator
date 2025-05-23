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
        decimal GetInterestRateByNameAndType(int mortgageId, string mortgageType);
        MortgageCalculationResult CalculateMortgage(MortgageCalculationRequest request);


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

        //calculation part for mortgages, interest
        public MortgageCalculationResult CalculateMortgage(MortgageCalculationRequest request)
        {
            try
            {


                if (request.InterestRate != 0 && request.DurationYears != 0 && request.LoanAmount != 0)
                {


                    decimal monthlyRate = request.InterestRate / 12 / 100;
                    int totalMonths = request.DurationYears * 12;

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
    }
}
