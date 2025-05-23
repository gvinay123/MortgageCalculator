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
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace MortgageCalculator.Windows
{
    public partial class frmActiveList : Form
    {
        private readonly IMortgageService _service;


        public frmActiveList(IMortgageService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void frmActiveList_Load(object sender, EventArgs e)
        {
            // load the active mortgage list
            var mortgages = _service.GetActiveMortgages();
            dgvMortgage.DataSource = mortgages;

            dgvMortgage.AutoGenerateColumns = false; 
            dgvMortgage.Columns.Clear();

            // Add only required columns manually
           
            dgvMortgage.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Name",
                Name = "colName"
            });
            dgvMortgage.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MortgageType",
                HeaderText = "Type",
                Name = "colType"
            });
            dgvMortgage.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InterestRate",
                HeaderText = "Rate (%)",
                Name = "colInterestRate"
            });
            dgvMortgage.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EffectiveStartDate", 
                HeaderText = "Start Date",
                Name = "colStartDate"
            });
            dgvMortgage.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EffectiveEndDate",
                HeaderText = "End Date",
                Name = "colEndDate"
            });


            //load the mortgage tyepe combo box

            cmbMortgageType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMortgageType.AutoCompleteSource = AutoCompleteSource.ListItems;

            var mortgageTypes = _service.GetMortgageTypes();
            cmbMortgageType.Items.AddRange(mortgageTypes.ToArray());



        }

        private void cmbMortgageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMortgageType.SelectedItem != null)
            {
                // Get selected mortgage type
                string selectedType = cmbMortgageType.SelectedItem.ToString();

                // Call service to get plans for the selected type
                var mortgageItems = _service.GetActiveMortgagesByType(selectedType);
                cmbMortgageName.Items.AddRange(mortgageItems.ToArray());
                cmbMortgageName.DisplayMember = "Name"; // or whatever property you want to show
                cmbMortgageName.ValueMember = "MortgageId";     // optional, based on your data model
                cmbMortgageName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbMortgageName.AutoCompleteSource = AutoCompleteSource.ListItems;
            }

        }

        private void cmbMortgageName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMortgageType.SelectedItem != null && cmbMortgageName.SelectedItem != null)
            {
                string selectedMortgageType = cmbMortgageType.SelectedItem.ToString();

                // Cast to your mortgage object type
                var selectedMortgage = cmbMortgageName.SelectedItem as Mortgage;

                if (selectedMortgage != null)
                {
                    int mortgageId = selectedMortgage.MortgageId;

                    // Get interest rate based on ID and type
                    var mortgageInterestRate = _service.GetInterestRateByNameAndType(mortgageId, selectedMortgageType);
                    txtInterestRate.Value = mortgageInterestRate;
                    txtInterestRate.DecimalPlaces = 2;       // Allow 2 decimal places
                    txtInterestRate.ThousandsSeparator = true;
                    txtInterestRate.Maximum = 100;          // Set appropriate max
                    txtInterestRate.Minimum = 0;
                    btnCalculate.Enabled = true;
                }
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            MortgageCalculationRequest request = new MortgageCalculationRequest();
            request.LoanAmount = Convert.ToDecimal(txtAmount.Value);
            request.InterestRate = Convert.ToDecimal(txtInterestRate.Value);
            request.DurationYears =Convert.ToInt32(txtDuration.Value);

            var calculatedResult = _service.CalculateMortgage(request);
            pnlCalculationResult.Visible  =true;
            lblMonthlyRepaymentResult.Text  = calculatedResult.MonthlyPayment.ToString();
            lblToatlRePaymentResult.Text  = calculatedResult.TotalRepayment.ToString();
            lblTotalInterestResult.Text  = calculatedResult.TotalInterest.ToString();

        }
    }
}
