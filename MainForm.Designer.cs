namespace BMICalculator
{
    partial class MainForm
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
            this.lblNormalBMI = new System.Windows.Forms.Label();
            this.grpUnit = new System.Windows.Forms.GroupBox();
            this.rbtnUS = new System.Windows.Forms.RadioButton();
            this.rbtnMetric = new System.Windows.Forms.RadioButton();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblWeightCat = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInch = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtCmFt = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grpSavingPlan = new System.Windows.Forms.GroupBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCalcSaving = new System.Windows.Forms.Button();
            this.grpSavingValue = new System.Windows.Forms.GroupBox();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.grpUnit.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpSavingPlan.SuspendLayout();
            this.grpSavingValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(141, 180);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(186, 51);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate BMI";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblNormalBMI
            // 
            this.lblNormalBMI.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblNormalBMI.Location = new System.Drawing.Point(75, 406);
            this.lblNormalBMI.Name = "lblNormalBMI";
            this.lblNormalBMI.Size = new System.Drawing.Size(407, 37);
            this.lblNormalBMI.TabIndex = 12;
            this.lblNormalBMI.Text = "label2";
            this.lblNormalBMI.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpUnit
            // 
            this.grpUnit.Controls.Add(this.rbtnUS);
            this.grpUnit.Controls.Add(this.rbtnMetric);
            this.grpUnit.Location = new System.Drawing.Point(368, 34);
            this.grpUnit.Name = "grpUnit";
            this.grpUnit.Size = new System.Drawing.Size(181, 100);
            this.grpUnit.TabIndex = 13;
            this.grpUnit.TabStop = false;
            this.grpUnit.Text = "Unit";
            // 
            // rbtnUS
            // 
            this.rbtnUS.AutoSize = true;
            this.rbtnUS.Location = new System.Drawing.Point(26, 59);
            this.rbtnUS.Name = "rbtnUS";
            this.rbtnUS.Size = new System.Drawing.Size(140, 20);
            this.rbtnUS.TabIndex = 1;
            this.rbtnUS.TabStop = true;
            this.rbtnUS.Text = "Imperial Unit (ft,lbs)";
            this.rbtnUS.UseVisualStyleBackColor = true;
            this.rbtnUS.CheckedChanged += new System.EventHandler(this.rbtnUS_CheckedChanged);
            // 
            // rbtnMetric
            // 
            this.rbtnMetric.AutoSize = true;
            this.rbtnMetric.Location = new System.Drawing.Point(26, 31);
            this.rbtnMetric.Name = "rbtnMetric";
            this.rbtnMetric.Size = new System.Drawing.Size(137, 20);
            this.rbtnMetric.TabIndex = 0;
            this.rbtnMetric.TabStop = true;
            this.rbtnMetric.Text = "Metric Unit (kg,cm)";
            this.rbtnMetric.UseVisualStyleBackColor = true;
            this.rbtnMetric.CheckedChanged += new System.EventHandler(this.rbtnMetric_CheckedChanged);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblWeightCat);
            this.grpResults.Controls.Add(this.lblBMI);
            this.grpResults.Controls.Add(this.label1);
            this.grpResults.Controls.Add(this.label8);
            this.grpResults.Location = new System.Drawing.Point(17, 260);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(532, 121);
            this.grpResults.TabIndex = 14;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results For";
            // 
            // lblWeightCat
            // 
            this.lblWeightCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeightCat.Location = new System.Drawing.Point(247, 78);
            this.lblWeightCat.Name = "lblWeightCat";
            this.lblWeightCat.Size = new System.Drawing.Size(270, 34);
            this.lblWeightCat.TabIndex = 15;
            this.lblWeightCat.Text = "label2";
            // 
            // lblBMI
            // 
            this.lblBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBMI.Location = new System.Drawing.Point(247, 31);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(128, 36);
            this.lblBMI.TabIndex = 14;
            this.lblBMI.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Weight Category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Your BMI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInch);
            this.groupBox1.Controls.Add(this.txtWeight);
            this.groupBox1.Controls.Add(this.txtCmFt);
            this.groupBox1.Controls.Add(this.lblWeight);
            this.groupBox1.Controls.Add(this.lblHeight);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(17, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 137);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BMI Calculator";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtInch
            // 
            this.txtInch.Location = new System.Drawing.Point(263, 69);
            this.txtInch.Name = "txtInch";
            this.txtInch.Size = new System.Drawing.Size(56, 22);
            this.txtInch.TabIndex = 22;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(133, 106);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 22);
            this.txtWeight.TabIndex = 21;
            // 
            // txtCmFt
            // 
            this.txtCmFt.Location = new System.Drawing.Point(133, 69);
            this.txtCmFt.Name = "txtCmFt";
            this.txtCmFt.Size = new System.Drawing.Size(100, 22);
            this.txtCmFt.TabIndex = 20;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(16, 106);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(75, 16);
            this.lblWeight.TabIndex = 19;
            this.lblWeight.Text = "Weight (kg)";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(16, 69);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(75, 16);
            this.lblHeight.TabIndex = 18;
            this.lblHeight.Text = "Height (cm)";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 22);
            this.txtName.TabIndex = 17;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 16);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Your Name";
            // 
            // grpSavingPlan
            // 
            this.grpSavingPlan.Controls.Add(this.textBox2);
            this.grpSavingPlan.Controls.Add(this.textBox1);
            this.grpSavingPlan.Controls.Add(this.lblPeriod);
            this.grpSavingPlan.Controls.Add(this.lblDeposit);
            this.grpSavingPlan.Location = new System.Drawing.Point(600, 34);
            this.grpSavingPlan.Name = "grpSavingPlan";
            this.grpSavingPlan.Size = new System.Drawing.Size(329, 212);
            this.grpSavingPlan.TabIndex = 17;
            this.grpSavingPlan.TabStop = false;
            this.grpSavingPlan.Text = "Saving plan";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(24, 59);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(101, 16);
            this.lblDeposit.TabIndex = 0;
            this.lblDeposit.Text = "Monthly deposit";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(24, 100);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(92, 16);
            this.lblPeriod.TabIndex = 1;
            this.lblPeriod.Text = "Period (years)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // btnCalcSaving
            // 
            this.btnCalcSaving.Location = new System.Drawing.Point(675, 260);
            this.btnCalcSaving.Name = "btnCalcSaving";
            this.btnCalcSaving.Size = new System.Drawing.Size(186, 51);
            this.btnCalcSaving.TabIndex = 18;
            this.btnCalcSaving.Text = "Calculate saving";
            this.btnCalcSaving.UseVisualStyleBackColor = true;
            // 
            // grpSavingValue
            // 
            this.grpSavingValue.Controls.Add(this.txtBalance);
            this.grpSavingValue.Controls.Add(this.txtAmountPaid);
            this.grpSavingValue.Controls.Add(this.lblBalance);
            this.grpSavingValue.Controls.Add(this.lblAmountPaid);
            this.grpSavingValue.Location = new System.Drawing.Point(600, 338);
            this.grpSavingValue.Name = "grpSavingValue";
            this.grpSavingValue.Size = new System.Drawing.Size(329, 146);
            this.grpSavingValue.TabIndex = 19;
            this.grpSavingValue.TabStop = false;
            this.grpSavingValue.Text = "Future value";
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Location = new System.Drawing.Point(6, 44);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(82, 16);
            this.lblAmountPaid.TabIndex = 1;
            this.lblAmountPaid.Text = "Amount paid";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(9, 89);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(88, 16);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Final balance";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Location = new System.Drawing.Point(168, 37);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(100, 22);
            this.txtAmountPaid.TabIndex = 3;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(168, 89);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 22);
            this.txtBalance.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 571);
            this.Controls.Add(this.grpSavingValue);
            this.Controls.Add(this.btnCalcSaving);
            this.Controls.Add(this.grpSavingPlan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpUnit);
            this.Controls.Add(this.lblNormalBMI);
            this.Controls.Add(this.btnCalculate);
            this.Name = "MainForm";
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpUnit.ResumeLayout(false);
            this.grpUnit.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSavingPlan.ResumeLayout(false);
            this.grpSavingPlan.PerformLayout();
            this.grpSavingValue.ResumeLayout(false);
            this.grpSavingValue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblNormalBMI;
        private System.Windows.Forms.GroupBox grpUnit;
        private System.Windows.Forms.RadioButton rbtnUS;
        private System.Windows.Forms.RadioButton rbtnMetric;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label lblWeightCat;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInch;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtCmFt;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpSavingPlan;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Button btnCalcSaving;
        private System.Windows.Forms.GroupBox grpSavingValue;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAmountPaid;
    }
}

