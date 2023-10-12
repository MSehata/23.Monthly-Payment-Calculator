namespace _23.Monthly_Payment_Calculator
{
    partial class Form1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pp = new System.Windows.Forms.Label();
            this.dpa = new System.Windows.Forms.Label();
            this.IR = new System.Windows.Forms.Label();
            this.LT = new System.Windows.Forms.Label();
            this.MP = new System.Windows.Forms.Label();
            this.ATF = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtDownPaymentAmount = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtLoanTerm = new System.Windows.Forms.TextBox();
            this.txtAmountToFinance = new System.Windows.Forms.TextBox();
            this.txtMonthlyPayment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(45, 366);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 27);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(622, 366);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 27);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pp
            // 
            this.pp.AutoSize = true;
            this.pp.Location = new System.Drawing.Point(87, 93);
            this.pp.Name = "pp";
            this.pp.Size = new System.Drawing.Size(100, 16);
            this.pp.TabIndex = 1;
            this.pp.Text = "Puchace Price :";
            // 
            // dpa
            // 
            this.dpa.AutoSize = true;
            this.dpa.Location = new System.Drawing.Point(36, 144);
            this.dpa.Name = "dpa";
            this.dpa.Size = new System.Drawing.Size(151, 16);
            this.dpa.TabIndex = 1;
            this.dpa.Text = "Down Payment Amount :";
            // 
            // IR
            // 
            this.IR.AutoSize = true;
            this.IR.Location = new System.Drawing.Point(47, 193);
            this.IR.Name = "IR";
            this.IR.Size = new System.Drawing.Size(140, 16);
            this.IR.TabIndex = 1;
            this.IR.Text = "Interest Rate (Annual) :";
            // 
            // LT
            // 
            this.LT.AutoSize = true;
            this.LT.Location = new System.Drawing.Point(55, 245);
            this.LT.Name = "LT";
            this.LT.Size = new System.Drawing.Size(132, 16);
            this.LT.TabIndex = 1;
            this.LT.Text = "Loan Term (Months) :";
            // 
            // MP
            // 
            this.MP.AutoSize = true;
            this.MP.Location = new System.Drawing.Point(418, 131);
            this.MP.Name = "MP";
            this.MP.Size = new System.Drawing.Size(115, 16);
            this.MP.TabIndex = 1;
            this.MP.Text = "Monthly Payment :";
            // 
            // ATF
            // 
            this.ATF.AutoSize = true;
            this.ATF.Location = new System.Drawing.Point(404, 93);
            this.ATF.Name = "ATF";
            this.ATF.Size = new System.Drawing.Size(129, 16);
            this.ATF.TabIndex = 1;
            this.ATF.Text = "Amount To Finance :";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(213, 87);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(100, 22);
            this.txtPurchasePrice.TabIndex = 2;
            // 
            // txtDownPaymentAmount
            // 
            this.txtDownPaymentAmount.Location = new System.Drawing.Point(213, 138);
            this.txtDownPaymentAmount.Name = "txtDownPaymentAmount";
            this.txtDownPaymentAmount.Size = new System.Drawing.Size(100, 22);
            this.txtDownPaymentAmount.TabIndex = 2;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(213, 193);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 22);
            this.txtInterestRate.TabIndex = 2;
            // 
            // txtLoanTerm
            // 
            this.txtLoanTerm.Location = new System.Drawing.Point(213, 245);
            this.txtLoanTerm.Name = "txtLoanTerm";
            this.txtLoanTerm.Size = new System.Drawing.Size(100, 22);
            this.txtLoanTerm.TabIndex = 2;
            // 
            // txtAmountToFinance
            // 
            this.txtAmountToFinance.Location = new System.Drawing.Point(544, 87);
            this.txtAmountToFinance.Name = "txtAmountToFinance";
            this.txtAmountToFinance.Size = new System.Drawing.Size(100, 22);
            this.txtAmountToFinance.TabIndex = 2;
            // 
            // txtMonthlyPayment
            // 
            this.txtMonthlyPayment.Location = new System.Drawing.Point(544, 128);
            this.txtMonthlyPayment.Name = "txtMonthlyPayment";
            this.txtMonthlyPayment.Size = new System.Drawing.Size(100, 22);
            this.txtMonthlyPayment.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(0, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(748, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enter Purchace Price, Down Payment Amount, Interest rate and Loan Term";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(786, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonthlyPayment);
            this.Controls.Add(this.txtAmountToFinance);
            this.Controls.Add(this.txtLoanTerm);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtDownPaymentAmount);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.ATF);
            this.Controls.Add(this.MP);
            this.Controls.Add(this.LT);
            this.Controls.Add(this.IR);
            this.Controls.Add(this.dpa);
            this.Controls.Add(this.pp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Monthly Payment Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label pp;
        private System.Windows.Forms.Label dpa;
        private System.Windows.Forms.Label IR;
        private System.Windows.Forms.Label LT;
        private System.Windows.Forms.Label MP;
        private System.Windows.Forms.Label ATF;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtDownPaymentAmount;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtLoanTerm;
        private System.Windows.Forms.TextBox txtAmountToFinance;
        private System.Windows.Forms.TextBox txtMonthlyPayment;
        private System.Windows.Forms.Label label1;
    }
}

