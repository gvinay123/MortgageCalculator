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
    public partial class MothlyEMICalculatorForm : Form
    {
        private readonly IMortgageService _service;
        public MothlyEMICalculatorForm(IMortgageService service)
        {
            InitializeComponent();
            _service = service;

        }

        private void MothlyEMICalculatorForm_Load(object sender, EventArgs e)
        {
            // load the active mortgage list
            var mortgages = _service.GetActiveMortgages();

            dgvMortgageList.DataSource = mortgages;

            // Add only required columns manually
            dgvMortgageList.AutoGenerateColumns = false;
            dgvMortgageList.Columns.Clear();

            dgvMortgageList.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MortgageId", // Your model's ID property
                HeaderText = "MortgageId",
                Name = "colMortgageId",
                Visible = false  // Hide the column
            });

            dgvMortgageList.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Name",
                Name = "colName"
            });
            dgvMortgageList.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MortgageType",
                HeaderText = "Type",
                Name = "colType"
            });
            dgvMortgageList.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LoanAmount",
                HeaderText = "Loan Amount",
                Name = "colLoanAmount"
            });

            
            dgvMortgageList.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InterestRate",
                HeaderText = "Rate (%)",
                Name = "colInterestRate"
            });
            dgvMortgageList.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EffectiveStartDate",
                HeaderText = "Start Date",
                Name = "colStartDate",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "d" }  // Short date format

            });
            dgvMortgageList.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EffectiveEndDate",
                HeaderText = "End Date",
                Name = "colEndDate",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "d" }  // Short date format

            });

            // Hide it after all columns are added or after binding the DataSource
            dgvMortgageList.Columns["colMortgageId"].Visible = false;
           
            
            //button for view of each item 

            DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
            viewButtonColumn.HeaderText = "Action";
            viewButtonColumn.Text = "View";
            viewButtonColumn.UseColumnTextForButtonValue = true;
            viewButtonColumn.Name = "colView";
            dgvMortgageList.Columns.Add(viewButtonColumn);


            cmbMortgageType.DataSource = Enum.GetValues(typeof(MortgageType));
            cmbMortgageType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMortgageType.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbPaymentType.DataSource = Enum.GetValues(typeof(InterestRepayment));
            cmbPaymentType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPaymentType.AutoCompleteSource = AutoCompleteSource.ListItems;
        }


        



        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Mortgage request = new Mortgage();
            request.LoanAmount = Convert.ToDecimal(txtAmount.Value);
            request.InterestRate = Convert.ToDecimal(txtInterestRate.Value);
            request.TermsInYears =Convert.ToInt32(txtDuration.Value);
            request.Name = txtMortgageName.Text;
            request.InterestRepayment = (InterestRepayment)cmbPaymentType.SelectedItem;
            request.MortgageType = (MortgageType)cmbMortgageType.SelectedItem;
            var calculatedResult = _service.MonthWiseEMICalculator(request);

            // Show Form2 with result
            MonthlyEmiSplitForm resultForm = new MonthlyEmiSplitForm(calculatedResult,_service);
            resultForm.ShowDialog();

            // Reload the active mortgage list
            var mortgages = _service.GetActiveMortgages();
            dgvMortgageList.DataSource = mortgages;
        }

        private void dgvMortgageList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if it's the View button column
            if (e.RowIndex >= 0 && dgvMortgageList.Columns[e.ColumnIndex].Name == "colView")
            {
                // Get the hidden ID from the selected row
                var mortgageId = Convert.ToInt32(dgvMortgageList.Rows[e.RowIndex].Cells["colMortgageId"].Value);

                // Show Form2 with result
                MonthlyEmiSplitForm resultForm = new MonthlyEmiSplitForm(mortgageId, _service);
                resultForm.ShowDialog();
            }
        }
    }
}
