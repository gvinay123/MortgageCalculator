namespace MortgageCalculator.Windows
{
    partial class MonthlyEmiSplitForm
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
            this.dgvMonthlyEMISplit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyEMISplit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMonthlyEMISplit
            // 
            this.dgvMonthlyEMISplit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonthlyEMISplit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonthlyEMISplit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthlyEMISplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonthlyEMISplit.Location = new System.Drawing.Point(0, 0);
            this.dgvMonthlyEMISplit.Name = "dgvMonthlyEMISplit";
            this.dgvMonthlyEMISplit.RowHeadersWidth = 51;
            this.dgvMonthlyEMISplit.RowTemplate.Height = 24;
            this.dgvMonthlyEMISplit.Size = new System.Drawing.Size(800, 450);
            this.dgvMonthlyEMISplit.TabIndex = 0;
            // 
            // MonthlyEmiSplitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMonthlyEMISplit);
            this.Name = "MonthlyEmiSplitForm";
            this.Text = "MonthlyEmiSplitForm";
            this.Load += new System.EventHandler(this.MonthlyEmiSplitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyEMISplit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMonthlyEMISplit;
    }
}