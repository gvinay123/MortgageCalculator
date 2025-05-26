namespace MortgageCalculator.Windows
{
    partial class MothlyEMICalculatorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.txtMortgageName = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtInterestRate = new System.Windows.Forms.NumericUpDown();
            this.cmbMortgageType = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.txtDuration = new System.Windows.Forms.NumericUpDown();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblMortgageName = new System.Windows.Forms.Label();
            this.lblMortgageType = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvMortgageList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuration)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMortgageList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbPaymentType);
            this.panel1.Controls.Add(this.txtMortgageName);
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Controls.Add(this.txtInterestRate);
            this.panel1.Controls.Add(this.cmbMortgageType);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.txtDuration);
            this.panel1.Controls.Add(this.lblInterestRate);
            this.panel1.Controls.Add(this.lblMortgageName);
            this.panel1.Controls.Add(this.lblMortgageType);
            this.panel1.Controls.Add(this.lblDuration);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1541, 208);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "Calculator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(982, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Payment Type";
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Location = new System.Drawing.Point(1116, 76);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(212, 24);
            this.cmbPaymentType.TabIndex = 24;
            // 
            // txtMortgageName
            // 
            this.txtMortgageName.Location = new System.Drawing.Point(197, 71);
            this.txtMortgageName.Name = "txtMortgageName";
            this.txtMortgageName.Size = new System.Drawing.Size(215, 22);
            this.txtMortgageName.TabIndex = 23;
            // 
            // btnCalculate
            // 
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalculate.Location = new System.Drawing.Point(1384, 94);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(139, 50);
            this.btnCalculate.TabIndex = 22;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.DecimalPlaces = 2;
            this.txtInterestRate.Location = new System.Drawing.Point(1121, 142);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(207, 22);
            this.txtInterestRate.TabIndex = 21;
            // 
            // cmbMortgageType
            // 
            this.cmbMortgageType.FormattingEnabled = true;
            this.cmbMortgageType.Location = new System.Drawing.Point(669, 142);
            this.cmbMortgageType.Name = "cmbMortgageType";
            this.cmbMortgageType.Size = new System.Drawing.Size(243, 24);
            this.cmbMortgageType.TabIndex = 19;
            // 
            // txtAmount
            // 
            this.txtAmount.DecimalPlaces = 2;
            this.txtAmount.Location = new System.Drawing.Point(197, 148);
            this.txtAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(206, 22);
            this.txtAmount.TabIndex = 18;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(669, 78);
            this.txtDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(243, 22);
            this.txtDuration.TabIndex = 17;
            this.txtDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(972, 148);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(105, 16);
            this.lblInterestRate.TabIndex = 16;
            this.lblInterestRate.Text = "Interest Rate (%)";
            // 
            // lblMortgageName
            // 
            this.lblMortgageName.AutoSize = true;
            this.lblMortgageName.Location = new System.Drawing.Point(57, 71);
            this.lblMortgageName.Name = "lblMortgageName";
            this.lblMortgageName.Size = new System.Drawing.Size(105, 16);
            this.lblMortgageName.TabIndex = 15;
            this.lblMortgageName.Text = "Mortgage Name";
            // 
            // lblMortgageType
            // 
            this.lblMortgageType.AutoSize = true;
            this.lblMortgageType.Location = new System.Drawing.Point(541, 150);
            this.lblMortgageType.Name = "lblMortgageType";
            this.lblMortgageType.Size = new System.Drawing.Size(100, 16);
            this.lblMortgageType.TabIndex = 14;
            this.lblMortgageType.Text = "Mortgage Type";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(496, 80);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(145, 16);
            this.lblDuration.TabIndex = 13;
            this.lblDuration.Text = "Loan Duration(in years)";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(49, 154);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(113, 16);
            this.lblAmount.TabIndex = 12;
            this.lblAmount.Text = "Borrowed Amount";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Pink;
            this.panel2.Controls.Add(this.dgvMortgageList);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1541, 375);
            this.panel2.TabIndex = 1;
            // 
            // dgvMortgageList
            // 
            this.dgvMortgageList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMortgageList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMortgageList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMortgageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMortgageList.Location = new System.Drawing.Point(21, 62);
            this.dgvMortgageList.Name = "dgvMortgageList";
            this.dgvMortgageList.RowHeadersWidth = 51;
            this.dgvMortgageList.RowTemplate.Height = 24;
            this.dgvMortgageList.Size = new System.Drawing.Size(1502, 287);
            this.dgvMortgageList.TabIndex = 29;
            this.dgvMortgageList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMortgageList_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mortgage List";
            // 
            // MothlyEMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1565, 589);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MothlyEMICalculatorForm";
            this.Text = "MothlyEMICalculatorForm";
            this.Load += new System.EventHandler(this.MothlyEMICalculatorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuration)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMortgageList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown txtInterestRate;
        private System.Windows.Forms.ComboBox cmbMortgageType;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private System.Windows.Forms.NumericUpDown txtDuration;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblMortgageName;
        private System.Windows.Forms.Label lblMortgageType;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtMortgageName;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMortgageList;
    }
}