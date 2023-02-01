namespace Assignment3
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
            this.BMICalc = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.Label();
            this.NameDisplay = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.Unit = new System.Windows.Forms.GroupBox();
            this.Imperial = new System.Windows.Forms.RadioButton();
            this.Metric = new System.Windows.Forms.RadioButton();
            this.CalculateBMI = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.WeightCatShown = new System.Windows.Forms.Label();
            this.BMIShown = new System.Windows.Forms.Label();
            this.WeightCategory = new System.Windows.Forms.Label();
            this.BMI = new System.Windows.Forms.Label();
            this.SavingPlan = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Period = new System.Windows.Forms.Label();
            this.MonthlyDep = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.FinalBalanceShown = new System.Windows.Forms.Label();
            this.AmountPaidShown = new System.Windows.Forms.Label();
            this.FinalBalance = new System.Windows.Forms.Label();
            this.AmountPaid = new System.Windows.Forms.Label();
            this.CalculateSaving = new System.Windows.Forms.Button();
            this.BMICalc.SuspendLayout();
            this.Unit.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SavingPlan.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMICalc
            // 
            this.BMICalc.Controls.Add(this.textBox1);
            this.BMICalc.Controls.Add(this.Weight);
            this.BMICalc.Controls.Add(this.Height);
            this.BMICalc.Controls.Add(this.NameDisplay);
            this.BMICalc.Controls.Add(this.textBox4);
            this.BMICalc.Controls.Add(this.textBox3);
            this.BMICalc.Controls.Add(this.NameInput);
            this.BMICalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMICalc.Location = new System.Drawing.Point(3, 12);
            this.BMICalc.Name = "BMICalc";
            this.BMICalc.Size = new System.Drawing.Size(278, 157);
            this.BMICalc.TabIndex = 0;
            this.BMICalc.TabStop = false;
            this.BMICalc.Text = "BMICalc";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 22);
            this.textBox1.TabIndex = 7;
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Location = new System.Drawing.Point(6, 96);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(49, 16);
            this.Weight.TabIndex = 6;
            this.Weight.Text = "Weight";
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Location = new System.Drawing.Point(6, 57);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(46, 16);
            this.Height.TabIndex = 5;
            this.Height.Text = "Height";
            // 
            // NameDisplay
            // 
            this.NameDisplay.AutoSize = true;
            this.NameDisplay.Location = new System.Drawing.Point(6, 22);
            this.NameDisplay.Name = "NameDisplay";
            this.NameDisplay.Size = new System.Drawing.Size(90, 16);
            this.NameDisplay.TabIndex = 4;
            this.NameDisplay.Text = "NameDisplay";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(190, 96);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(68, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(190, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 22);
            this.textBox3.TabIndex = 2;
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(115, 19);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(143, 22);
            this.NameInput.TabIndex = 0;
            // 
            // Unit
            // 
            this.Unit.Controls.Add(this.Imperial);
            this.Unit.Controls.Add(this.Metric);
            this.Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unit.Location = new System.Drawing.Point(304, 20);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(200, 70);
            this.Unit.TabIndex = 1;
            this.Unit.TabStop = false;
            this.Unit.Text = "Unit";
            // 
            // Imperial
            // 
            this.Imperial.AutoSize = true;
            this.Imperial.Location = new System.Drawing.Point(6, 43);
            this.Imperial.Name = "Imperial";
            this.Imperial.Size = new System.Drawing.Size(73, 20);
            this.Imperial.TabIndex = 1;
            this.Imperial.TabStop = true;
            this.Imperial.Text = "Imperial";
            this.Imperial.UseVisualStyleBackColor = true;
            this.Imperial.CheckedChanged += new System.EventHandler(this.Imperial_CheckedChanged);
            // 
            // Metric
            // 
            this.Metric.AutoSize = true;
            this.Metric.Location = new System.Drawing.Point(6, 20);
            this.Metric.Name = "Metric";
            this.Metric.Size = new System.Drawing.Size(61, 20);
            this.Metric.TabIndex = 0;
            this.Metric.TabStop = true;
            this.Metric.Text = "Metric";
            this.Metric.UseVisualStyleBackColor = true;
            this.Metric.CheckedChanged += new System.EventHandler(this.Metric_CheckedChanged);
            // 
            // CalculateBMI
            // 
            this.CalculateBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMI.Location = new System.Drawing.Point(42, 175);
            this.CalculateBMI.Name = "CalculateBMI";
            this.CalculateBMI.Size = new System.Drawing.Size(203, 43);
            this.CalculateBMI.TabIndex = 2;
            this.CalculateBMI.Text = "CalculateBMI";
            this.CalculateBMI.UseVisualStyleBackColor = true;
            this.CalculateBMI.Enter += new System.EventHandler(this.CalculateBMI_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.WeightCatShown);
            this.groupBox3.Controls.Add(this.BMIShown);
            this.groupBox3.Controls.Add(this.WeightCategory);
            this.groupBox3.Controls.Add(this.BMI);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 187);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // WeightCatShown
            // 
            this.WeightCatShown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WeightCatShown.Location = new System.Drawing.Point(196, 90);
            this.WeightCatShown.Name = "WeightCatShown";
            this.WeightCatShown.Size = new System.Drawing.Size(250, 27);
            this.WeightCatShown.TabIndex = 10;
            this.WeightCatShown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMIShown
            // 
            this.BMIShown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BMIShown.Location = new System.Drawing.Point(196, 38);
            this.BMIShown.Name = "BMIShown";
            this.BMIShown.Size = new System.Drawing.Size(250, 27);
            this.BMIShown.TabIndex = 9;
            this.BMIShown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightCategory
            // 
            this.WeightCategory.AutoSize = true;
            this.WeightCategory.Location = new System.Drawing.Point(6, 95);
            this.WeightCategory.Name = "WeightCategory";
            this.WeightCategory.Size = new System.Drawing.Size(104, 16);
            this.WeightCategory.TabIndex = 8;
            this.WeightCategory.Text = "WeightCategory";
            // 
            // BMI
            // 
            this.BMI.AutoSize = true;
            this.BMI.Location = new System.Drawing.Point(6, 38);
            this.BMI.Name = "BMI";
            this.BMI.Size = new System.Drawing.Size(30, 16);
            this.BMI.TabIndex = 7;
            this.BMI.Text = "BMI";
            // 
            // SavingPlan
            // 
            this.SavingPlan.Controls.Add(this.textBox6);
            this.SavingPlan.Controls.Add(this.textBox5);
            this.SavingPlan.Controls.Add(this.Period);
            this.SavingPlan.Controls.Add(this.MonthlyDep);
            this.SavingPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingPlan.Location = new System.Drawing.Point(510, 23);
            this.SavingPlan.Name = "SavingPlan";
            this.SavingPlan.Size = new System.Drawing.Size(293, 161);
            this.SavingPlan.TabIndex = 2;
            this.SavingPlan.TabStop = false;
            this.SavingPlan.Text = "SavingPlan";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(150, 74);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(128, 22);
            this.textBox6.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(150, 39);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(128, 22);
            this.textBox5.TabIndex = 7;
            // 
            // Period
            // 
            this.Period.AutoSize = true;
            this.Period.Location = new System.Drawing.Point(6, 74);
            this.Period.Name = "Period";
            this.Period.Size = new System.Drawing.Size(47, 16);
            this.Period.TabIndex = 12;
            this.Period.Text = "Period";
            // 
            // MonthlyDep
            // 
            this.MonthlyDep.AutoSize = true;
            this.MonthlyDep.Location = new System.Drawing.Point(6, 39);
            this.MonthlyDep.Name = "MonthlyDep";
            this.MonthlyDep.Size = new System.Drawing.Size(79, 16);
            this.MonthlyDep.TabIndex = 11;
            this.MonthlyDep.Text = "MonthlyDep";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.FinalBalanceShown);
            this.groupBox5.Controls.Add(this.AmountPaidShown);
            this.groupBox5.Controls.Add(this.FinalBalance);
            this.groupBox5.Controls.Add(this.AmountPaid);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(510, 262);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(293, 161);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // FinalBalanceShown
            // 
            this.FinalBalanceShown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FinalBalanceShown.Location = new System.Drawing.Point(140, 99);
            this.FinalBalanceShown.Name = "FinalBalanceShown";
            this.FinalBalanceShown.Size = new System.Drawing.Size(138, 27);
            this.FinalBalanceShown.TabIndex = 11;
            this.FinalBalanceShown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AmountPaidShown
            // 
            this.AmountPaidShown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AmountPaidShown.Location = new System.Drawing.Point(140, 40);
            this.AmountPaidShown.Name = "AmountPaidShown";
            this.AmountPaidShown.Size = new System.Drawing.Size(138, 27);
            this.AmountPaidShown.TabIndex = 11;
            this.AmountPaidShown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FinalBalance
            // 
            this.FinalBalance.AutoSize = true;
            this.FinalBalance.Location = new System.Drawing.Point(6, 104);
            this.FinalBalance.Name = "FinalBalance";
            this.FinalBalance.Size = new System.Drawing.Size(86, 16);
            this.FinalBalance.TabIndex = 10;
            this.FinalBalance.Text = "FinalBalance";
            // 
            // AmountPaid
            // 
            this.AmountPaid.AutoSize = true;
            this.AmountPaid.Location = new System.Drawing.Point(6, 45);
            this.AmountPaid.Name = "AmountPaid";
            this.AmountPaid.Size = new System.Drawing.Size(80, 16);
            this.AmountPaid.TabIndex = 9;
            this.AmountPaid.Text = "AmountPaid";
            this.AmountPaid.UseWaitCursor = true;
            // 
            // CalculateSaving
            // 
            this.CalculateSaving.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateSaving.Location = new System.Drawing.Point(555, 190);
            this.CalculateSaving.Name = "CalculateSaving";
            this.CalculateSaving.Size = new System.Drawing.Size(203, 43);
            this.CalculateSaving.TabIndex = 5;
            this.CalculateSaving.Text = "CalculateSaving";
            this.CalculateSaving.UseVisualStyleBackColor = true;
            this.CalculateSaving.Enter += new System.EventHandler(this.CalculateSaving_Enter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 453);
            this.Controls.Add(this.CalculateSaving);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.SavingPlan);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.CalculateBMI);
            this.Controls.Add(this.Unit);
            this.Controls.Add(this.BMICalc);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.BMICalc.ResumeLayout(false);
            this.BMICalc.PerformLayout();
            this.Unit.ResumeLayout(false);
            this.Unit.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.SavingPlan.ResumeLayout(false);
            this.SavingPlan.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BMICalc;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.GroupBox Unit;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label NameDisplay;
        private System.Windows.Forms.RadioButton Imperial;
        private System.Windows.Forms.RadioButton Metric;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Button CalculateBMI;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label WeightCategory;
        private System.Windows.Forms.Label BMI;
        private System.Windows.Forms.GroupBox SavingPlan;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button CalculateSaving;
        private System.Windows.Forms.Label FinalBalance;
        private System.Windows.Forms.Label AmountPaid;
        private System.Windows.Forms.Label Period;
        private System.Windows.Forms.Label MonthlyDep;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label BMIShown;
        private System.Windows.Forms.Label WeightCatShown;
        private System.Windows.Forms.Label FinalBalanceShown;
        private System.Windows.Forms.Label AmountPaidShown;
        private System.Windows.Forms.TextBox textBox1;
    }
}

