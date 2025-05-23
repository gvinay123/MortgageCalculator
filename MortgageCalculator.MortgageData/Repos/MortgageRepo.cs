using MortgageCalculator.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator.MortgageData.Repos
{
    public interface IMortgageRepo
    {
        List<Mortgage> GetAllMortgages();
        IQueryable<Mortgage> GetActiveMortgage();
        IQueryable<Mortgage> GetActiveMortgagesByType(string mortgageType);
        List<string> GetMortgageTypes();
        IQueryable<decimal> GetInterestRateByNameAndType(int mortgageId, string mortgageType);
    }

    public class MortgageRepo : IMortgageRepo
    {
        public List<Mortgage> GetAllMortgages()
        {
            List<Mortgage> result = new List<Mortgage>();

            using (var context = new MortgageData.MortgageDataContext())
            {

                var mortgages = context.Mortgages.ToList();

                foreach (var mortgage in mortgages)
                {
                    result.Add(new Mortgage()
                    {
                        Name = mortgage.Name,
                        EffectiveStartDate = mortgage.EffectiveStartDate,
                        EffectiveEndDate = mortgage.EffectiveEndDate,
                        CancellationFee = mortgage.CancellationFee,
                        EstablishmentFee = mortgage.CancellationFee,
                        InterestRepayment = (InterestRepayment)Enum.Parse(typeof(InterestRepayment), mortgage.InterestRepayment.ToString()),
                        MortgageId = mortgage.MortgageId,
                        MortgageType = (MortgageType)Enum.Parse(typeof(MortgageType), mortgage.MortgageType.ToString()),
                        TermsInMonths = mortgage.TermsInMonths,
                        InterestRate = mortgage.InterestRate
                    }
                    );
                }
            }

            return result;

        }
        
        //get all the active mortgage records
        public IQueryable<Mortgage> GetActiveMortgage()
        {
            var context = new MortgageData.MortgageDataContext();
            
            return context.Mortgages.Where(m => m.EffectiveStartDate <= DateTime.Now && m.EffectiveEndDate >= DateTime.Now);
            
        }
        
        //get interestrate by the type and interest name
        public IQueryable<decimal> GetInterestRateByNameAndType(int mortgageId, string mortgageType)
        {


            var context = new MortgageData.MortgageDataContext();

            return context.Mortgages
                .Where(m => m.MortgageId == mortgageId &&
                            m.MortgageType.ToString() == mortgageType)
                .OrderBy(m => m.InterestRate)
                .Select(m => m.InterestRate); 
          
            
        }

        //get the mortgages by type
        public IQueryable<Mortgage> GetActiveMortgagesByType(string mortgageType)
        {
            var context = new MortgageData.MortgageDataContext();
            
            return context.Mortgages.Where(m => m.MortgageType.ToString() == mortgageType && m.EffectiveStartDate <= DateTime.Now && m.EffectiveEndDate >= DateTime.Now);
            
        }

        //list mortgages type
        public List<string> GetMortgageTypes()
        {
            return Enum.GetNames(typeof(MortgageType)).ToList();
        }

    }
}
