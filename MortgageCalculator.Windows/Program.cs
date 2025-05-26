using MortgageCalculator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace MortgageCalculator.Windows
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var services = new ServiceCollection();

            // Register interfaces and implementations
            services.AddSingleton<IMortgageService, MortgageService>();
            services.AddTransient<MothlyEMICalculatorForm>();

            // Build service provider
            var serviceProvider = services.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(serviceProvider.GetRequiredService<MothlyEMICalculatorForm>());
        }
    }
}
