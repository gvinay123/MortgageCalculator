namespace MortgageCalculator.Windows
{
    partial class frmActiveList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCalculate = new System.Windows.Forms.Panel();
            this.pnlCalculationResult = new System.Windows.Forms.Panel();
            this.lblTotalInterestResult = new System.Windows.Forms.Label();
            this.lblToatlRePaymentResult = new System.Windows.Forms.Label();
            this.lblMonthlyRepaymentResult = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.lblTotalRepayment = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.pnlCalculation = new System.Windows.Forms.Panel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtInterestRate = new System.Windows.Forms.NumericUpDown();
            this.cmbMortgageName = new System.Windows.Forms.ComboBox();
            this.cmbMortgageType = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.txtDuration = new System.Windows.Forms.NumericUpDown();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblMortgageName = new System.Windows.Forms.Label();
            this.lblMortgageType = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCalculation = new System.Windows.Forms.Label();
            this.pnlActiveList = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMortgage = new System.Windows.Forms.DataGridView();
            this.lblActiveMortgage = new System.Windows.Forms.Label();
            this.pnlCalculate.SuspendLayout();
            this.pnlCalculationResult.SuspendLayout();
            this.pnlCalculation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuration)).BeginInit();
            this.pnlActiveList.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMortgage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCalculate
            // 
            this.pnlCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCalculate.BackColor = System.Drawing.Color.Azure;
            this.pnlCalculate.Controls.Add(this.pnlCalculationResult);
            this.pnlCalculate.Controls.Add(this.pnlCalculation);
            this.pnlCalculate.Controls.Add(this.lblCalculation);
            this.pnlCalculate.Location = new System.Drawing.Point(12, 12);
            this.pnlCalculate.Name = "pnlCalculate";
            this.pnlCalculate.Size = new System.Drawing.Size(1687, 268);
            this.pnlCalculate.TabIndex = 1;
            // 
            // pnlCalculationResult
            // 
            this.pnlCalculationResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCalculationResult.BackColor = System.Drawing.Color.SeaShell;
            this.pnlCalculationResult.Controls.Add(this.lblTotalInterestResult);
            this.pnlCalculationResult.Controls.Add(this.lblToatlRePaymentResult);
            this.pnlCalculationResult.Controls.Add(this.lblMonthlyRepaymentResult);
            this.pnlCalculationResult.Controls.Add(this.lblTotalInterest);
            this.pnlCalculationResult.Controls.Add(this.lblTotalRepayment);
            this.pnlCalculationResult.Controls.Add(this.lblTotalAmount);
            this.pnlCalculationResult.Location = new System.Drawing.Point(1201, 56);
            this.pnlCalculationResult.Name = "pnlCalculationResult";
            this.pnlCalculationResult.Size = new System.Drawing.Size(478, 169);
            this.pnlCalculationResult.TabIndex = 2;
            this.pnlCalculationResult.Visible = false;
            // 
            // lblTotalInterestResult
            // 
            this.lblTotalInterestResult.AutoSize = true;
            this.lblTotalInterestResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInterestResult.Location = new System.Drawing.Point(208, 103);
            this.lblTotalInterestResult.Name = "lblTotalInterestResult";
            this.lblTotalInterestResult.Size = new System.Drawing.Size(227, 20);
            this.lblTotalInterestResult.TabIndex = 9;
            this.lblTotalInterestResult.Text = "label Total Interest Result";
            // 
            // lblToatlRePaymentResult
            // 
            this.lblToatlRePaymentResult.AutoSize = true;
            this.lblToatlRePaymentResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToatlRePaymentResult.Location = new System.Drawing.Point(208, 65);
            this.lblToatlRePaymentResult.Name = "lblToatlRePaymentResult";
            this.lblToatlRePaymentResult.Size = new System.Drawing.Size(215, 20);
            this.lblToatlRePaymentResult.TabIndex = 8;
            this.lblToatlRePaymentResult.Text = "label Total Repay Result";
            // 
            // lblMonthlyRepaymentResult
            // 
            this.lblMonthlyRepaymentResult.AutoSize = true;
            this.lblMonthlyRepaymentResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyRepaymentResult.Location = new System.Drawing.Point(208, 28);
            this.lblMonthlyRepaymentResult.Name = "lblMonthlyRepaymentResult";
            this.lblMonthlyRepaymentResult.Size = new System.Drawing.Size(228, 20);
            this.lblMonthlyRepaymentResult.TabIndex = 7;
            this.lblMonthlyRepaymentResult.Text = "label Mothly Repay Result";
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Location = new System.Drawing.Point(79, 103);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(93, 16);
            this.lblTotalInterest.TabIndex = 6;
            this.lblTotalInterest.Text = "Total Interest  :";
            // 
            // lblTotalRepayment
            // 
            this.lblTotalRepayment.AutoSize = true;
            this.lblTotalRepayment.Location = new System.Drawing.Point(52, 65);
            this.lblTotalRepayment.Name = "lblTotalRepayment";
            this.lblTotalRepayment.Size = new System.Drawing.Size(120, 16);
            this.lblTotalRepayment.TabIndex = 5;
            this.lblTotalRepayment.Text = "Total Repayment  :";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(37, 29);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(135, 16);
            this.lblTotalAmount.TabIndex = 4;
            this.lblTotalAmount.Text = "Monthly Repayment  :";
            // 
            // pnlCalculation
            // 
            this.pnlCalculation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCalculation.BackColor = System.Drawing.Color.LightPink;
            this.pnlCalculation.Controls.Add(this.btnCalculate);
            this.pnlCalculation.Controls.Add(this.txtInterestRate);
            this.pnlCalculation.Controls.Add(this.cmbMortgageName);
            this.pnlCalculation.Controls.Add(this.cmbMortgageType);
            this.pnlCalculation.Controls.Add(this.txtAmount);
            this.pnlCalculation.Controls.Add(this.txtDuration);
            this.pnlCalculation.Controls.Add(this.lblInterestRate);
            this.pnlCalculation.Controls.Add(this.lblMortgageName);
            this.pnlCalculation.Controls.Add(this.lblMortgageType);
            this.pnlCalculation.Controls.Add(this.lblDuration);
            this.pnlCalculation.Controls.Add(this.lblAmount);
            this.pnlCalculation.Location = new System.Drawing.Point(13, 56);
            this.pnlCalculation.Name = "pnlCalculation";
            this.pnlCalculation.Size = new System.Drawing.Size(1182, 169);
            this.pnlCalculation.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalculate.Location = new System.Drawing.Point(884, 114);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(139, 35);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.DecimalPlaces = 2;
            this.txtInterestRate.Location = new System.Drawing.Point(778, 71);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(245, 22);
            this.txtInterestRate.TabIndex = 10;
            // 
            // cmbMortgageName
            // 
            this.cmbMortgageName.FormattingEnabled = true;
            this.cmbMortgageName.Location = new System.Drawing.Point(778, 22);
            this.cmbMortgageName.Name = "cmbMortgageName";
            this.cmbMortgageName.Size = new System.Drawing.Size(245, 24);
            this.cmbMortgageName.TabIndex = 9;
            this.cmbMortgageName.SelectedIndexChanged += new System.EventHandler(this.cmbMortgageName_SelectedIndexChanged);
            // 
            // cmbMortgageType
            // 
            this.cmbMortgageType.FormattingEnabled = true;
            this.cmbMortgageType.Location = new System.Drawing.Point(244, 120);
            this.cmbMortgageType.Name = "cmbMortgageType";
            this.cmbMortgageType.Size = new System.Drawing.Size(245, 24);
            this.cmbMortgageType.TabIndex = 8;
            this.cmbMortgageType.SelectedIndexChanged += new System.EventHandler(this.cmbMortgageType_SelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.DecimalPlaces = 2;
            this.txtAmount.Location = new System.Drawing.Point(244, 23);
            this.txtAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(245, 22);
            this.txtAmount.TabIndex = 7;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(244, 71);
            this.txtDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(245, 22);
            this.txtDuration.TabIndex = 6;
            this.txtDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(581, 73);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(105, 16);
            this.lblInterestRate.TabIndex = 4;
            this.lblInterestRate.Text = "Interest Rate (%)";
            // 
            // lblMortgageName
            // 
            this.lblMortgageName.AutoSize = true;
            this.lblMortgageName.Location = new System.Drawing.Point(581, 28);
            this.lblMortgageName.Name = "lblMortgageName";
            this.lblMortgageName.Size = new System.Drawing.Size(105, 16);
            this.lblMortgageName.TabIndex = 3;
            this.lblMortgageName.Text = "Mortgage Name";
            // 
            // lblMortgageType
            // 
            this.lblMortgageType.AutoSize = true;
            this.lblMortgageType.Location = new System.Drawing.Point(47, 120);
            this.lblMortgageType.Name = "lblMortgageType";
            this.lblMortgageType.Size = new System.Drawing.Size(100, 16);
            this.lblMortgageType.TabIndex = 2;
            this.lblMortgageType.Text = "Mortgage Type";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(47, 73);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(145, 16);
            this.lblDuration.TabIndex = 1;
            this.lblDuration.Text = "Loan Duration(in years)";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(47, 28);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(113, 16);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Borrowed Amount";
            // 
            // lblCalculation
            // 
            this.lblCalculation.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblCalculation.AutoSize = true;
            this.lblCalculation.BackColor = System.Drawing.Color.Azure;
            this.lblCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculation.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCalculation.Location = new System.Drawing.Point(15, 4);
            this.lblCalculation.Name = "lblCalculation";
            this.lblCalculation.Size = new System.Drawing.Size(279, 32);
            this.lblCalculation.TabIndex = 0;
            this.lblCalculation.Text = "Calculate Mortgage";
            this.lblCalculation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlActiveList
            // 
            this.pnlActiveList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActiveList.BackColor = System.Drawing.Color.Azure;
            this.pnlActiveList.Controls.Add(this.panel1);
            this.pnlActiveList.Controls.Add(this.lblActiveMortgage);
            this.pnlActiveList.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlActiveList.Location = new System.Drawing.Point(12, 243);
            this.pnlActiveList.Name = "pnlActiveList";
            this.pnlActiveList.Size = new System.Drawing.Size(1687, 399);
            this.pnlActiveList.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvMortgage);
            this.panel1.Location = new System.Drawing.Point(21, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1658, 326);
            this.panel1.TabIndex = 2;
            // 
            // dgvMortgage
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvMortgage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMortgage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMortgage.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMortgage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMortgage.ColumnHeadersHeight = 29;
            this.dgvMortgage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMortgage.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvMortgage.Location = new System.Drawing.Point(0, 0);
            this.dgvMortgage.Name = "dgvMortgage";
            this.dgvMortgage.RowHeadersWidth = 51;
            this.dgvMortgage.RowTemplate.Height = 24;
            this.dgvMortgage.Size = new System.Drawing.Size(1658, 326);
            this.dgvMortgage.TabIndex = 0;
            // 
            // lblActiveMortgage
            // 
            this.lblActiveMortgage.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblActiveMortgage.AutoSize = true;
            this.lblActiveMortgage.BackColor = System.Drawing.Color.Azure;
            this.lblActiveMortgage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveMortgage.ForeColor = System.Drawing.Color.IndianRed;
            this.lblActiveMortgage.Location = new System.Drawing.Point(15, 5);
            this.lblActiveMortgage.Name = "lblActiveMortgage";
            this.lblActiveMortgage.Size = new System.Drawing.Size(291, 32);
            this.lblActiveMortgage.TabIndex = 1;
            this.lblActiveMortgage.Text = "Active Mortgage List";
            this.lblActiveMortgage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmActiveList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 654);
            this.Controls.Add(this.pnlActiveList);
            this.Controls.Add(this.pnlCalculate);
            this.Name = "frmActiveList";
            this.Text = "Mortgage Calculator";
            this.Load += new System.EventHandler(this.frmActiveList_Load);
            this.pnlCalculate.ResumeLayout(false);
            this.pnlCalculate.PerformLayout();
            this.pnlCalculationResult.ResumeLayout(false);
            this.pnlCalculationResult.PerformLayout();
            this.pnlCalculation.ResumeLayout(false);
            this.pnlCalculation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuration)).EndInit();
            this.pnlActiveList.ResumeLayout(false);
            this.pnlActiveList.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMortgage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCalculate;
        private System.Windows.Forms.Panel pnlActiveList;
        private System.Windows.Forms.DataGridView dgvMortgage;
        private System.Windows.Forms.Label lblCalculation;
        private System.Windows.Forms.Label lblActiveMortgage;
        private System.Windows.Forms.Panel pnlCalculationResult;
        private System.Windows.Forms.Panel pnlCalculation;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblMortgageType;
        private System.Windows.Forms.Label lblMortgageName;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private System.Windows.Forms.NumericUpDown txtDuration;
        private System.Windows.Forms.ComboBox cmbMortgageType;
        private System.Windows.Forms.ComboBox cmbMortgageName;
        private System.Windows.Forms.NumericUpDown txtInterestRate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalRepayment;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Label lblTotalInterestResult;
        private System.Windows.Forms.Label lblToatlRePaymentResult;
        private System.Windows.Forms.Label lblMonthlyRepaymentResult;
        private System.Windows.Forms.Panel panel1;
    }
}

