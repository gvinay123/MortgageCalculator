using MortgageCalculator.Dto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator.MortgageData
{
    public class MortgageDataContext : DbContext
    {
        public MortgageDataContext()
            : base("name=MortgageDbConnection") { }

        public DbSet<Mortgage> Mortgage { get; set; }
        public DbSet<MonthlyEMIDetails> MonthlyEMIDetails { get; set; }





    }


}