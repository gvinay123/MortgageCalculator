using MortgageCalculator.Dto;
using MortgageCalculator.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace MortgageCalculator.Windows
{
    public partial class MonthlyEmiSplitForm : Form
    {
        private int _mortgageId;
        private readonly IMortgageService _service;

        public MonthlyEmiSplitForm(int mortgageId, IMortgageService service)
        {
            InitializeComponent();
            _mortgageId = mortgageId;
            _service = service;

            
        }

        private void MonthlyEmiSplitForm_Load(object sender, EventArgs e)
        {
            var monthlySplit = _service.GetMonthlyEmiDetailsById(_mortgageId);
            // Load data into a DataGridView 
            dgvMonthlyEMISplit.DataSource = monthlySplit;


            // Add only required columns manually
            dgvMonthlyEMISplit.AutoGenerateColumns = false;
            dgvMonthlyEMISplit.Columns.Clear();
            dgvMonthlyEMISplit.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Year",
                HeaderText = "Year",
                Name = "colYear"
            });
            dgvMonthlyEMISplit.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Month",
                HeaderText = "Month",
                Name = "colMonth"
            });
            dgvMonthlyEMISplit.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Principal",
                HeaderText = "Principal",
                Name = "colPrincipal"
            });


            dgvMonthlyEMISplit.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Interest",
                HeaderText = "Interest",
                Name = "colInterest"
            });
            dgvMonthlyEMISplit.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalPayment",
                HeaderText = "Total Payment",
                Name = "colTotalPayment"
            });
            dgvMonthlyEMISplit.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RemainingBalance",
                HeaderText = "Remaining Balance",
                Name = "colRemainingBalance"
            });
            dgvMonthlyEMISplit.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LoanPaidPercentage",
                HeaderText = "Loan Paid Percentage",
                Name = "colLoanPaidPercentage"
            });




        }
    }
}
