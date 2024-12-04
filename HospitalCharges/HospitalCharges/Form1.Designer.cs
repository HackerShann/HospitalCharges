namespace HospitalCharges
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
            this.lblDays = new System.Windows.Forms.Label();
            this.lblMedication = new System.Windows.Forms.Label();
            this.lblSurgical = new System.Windows.Forms.Label();
            this.lblLab = new System.Windows.Forms.Label();
            this.lblRehab = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblBaseCharges = new System.Windows.Forms.Label();
            this.lblAdditionalCharges = new System.Windows.Forms.Label();
            this.lblTotalCharges = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtMedication = new System.Windows.Forms.TextBox();
            this.txtSurgical = new System.Windows.Forms.TextBox();
            this.txtLab = new System.Windows.Forms.TextBox();
            this.txtRehab = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(63, 72);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(168, 25);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "Days in Hospital";
            // 
            // lblMedication
            // 
            this.lblMedication.AutoSize = true;
            this.lblMedication.Location = new System.Drawing.Point(63, 128);
            this.lblMedication.Name = "lblMedication";
            this.lblMedication.Size = new System.Drawing.Size(204, 25);
            this.lblMedication.TabIndex = 1;
            this.lblMedication.Text = "Medication Charges";
            // 
            // lblSurgical
            // 
            this.lblSurgical.AutoSize = true;
            this.lblSurgical.Location = new System.Drawing.Point(63, 185);
            this.lblSurgical.Name = "lblSurgical";
            this.lblSurgical.Size = new System.Drawing.Size(177, 25);
            this.lblSurgical.TabIndex = 2;
            this.lblSurgical.Text = "Surgical Charges";
            // 
            // lblLab
            // 
            this.lblLab.AutoSize = true;
            this.lblLab.Location = new System.Drawing.Point(63, 239);
            this.lblLab.Name = "lblLab";
            this.lblLab.Size = new System.Drawing.Size(135, 25);
            this.lblLab.TabIndex = 3;
            this.lblLab.Text = "Lab Charges";
            // 
            // lblRehab
            // 
            this.lblRehab.AutoSize = true;
            this.lblRehab.Location = new System.Drawing.Point(63, 296);
            this.lblRehab.Name = "lblRehab";
            this.lblRehab.Size = new System.Drawing.Size(230, 25);
            this.lblRehab.TabIndex = 4;
            this.lblRehab.Text = "Rehabilitation Charges";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(334, 542);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(214, 84);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblBaseCharges
            // 
            this.lblBaseCharges.AutoSize = true;
            this.lblBaseCharges.Location = new System.Drawing.Point(73, 433);
            this.lblBaseCharges.Name = "lblBaseCharges";
            this.lblBaseCharges.Size = new System.Drawing.Size(0, 25);
            this.lblBaseCharges.TabIndex = 9;
            // 
            // lblAdditionalCharges
            // 
            this.lblAdditionalCharges.AutoSize = true;
            this.lblAdditionalCharges.Location = new System.Drawing.Point(347, 432);
            this.lblAdditionalCharges.Name = "lblAdditionalCharges";
            this.lblAdditionalCharges.Size = new System.Drawing.Size(0, 25);
            this.lblAdditionalCharges.TabIndex = 10;
            // 
            // lblTotalCharges
            // 
            this.lblTotalCharges.AutoSize = true;
            this.lblTotalCharges.Location = new System.Drawing.Point(687, 444);
            this.lblTotalCharges.Name = "lblTotalCharges";
            this.lblTotalCharges.Size = new System.Drawing.Size(0, 25);
            this.lblTotalCharges.TabIndex = 11;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(334, 66);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 31);
            this.txtDays.TabIndex = 12;
            // 
            // txtMedication
            // 
            this.txtMedication.Location = new System.Drawing.Point(334, 128);
            this.txtMedication.Name = "txtMedication";
            this.txtMedication.Size = new System.Drawing.Size(100, 31);
            this.txtMedication.TabIndex = 13;
            // 
            // txtSurgical
            // 
            this.txtSurgical.Location = new System.Drawing.Point(334, 182);
            this.txtSurgical.Name = "txtSurgical";
            this.txtSurgical.Size = new System.Drawing.Size(100, 31);
            this.txtSurgical.TabIndex = 14;
            // 
            // txtLab
            // 
            this.txtLab.Location = new System.Drawing.Point(334, 233);
            this.txtLab.Name = "txtLab";
            this.txtLab.Size = new System.Drawing.Size(100, 31);
            this.txtLab.TabIndex = 15;
            // 
            // txtRehab
            // 
            this.txtRehab.Location = new System.Drawing.Point(334, 290);
            this.txtRehab.Name = "txtRehab";
            this.txtRehab.Size = new System.Drawing.Size(100, 31);
            this.txtRehab.TabIndex = 16;
            this.txtRehab.TextChanged += new System.EventHandler(this.lbltxtRehab_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(68, 542);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(199, 84);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = " Clear All ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(632, 542);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(197, 75);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 675);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtRehab);
            this.Controls.Add(this.txtLab);
            this.Controls.Add(this.txtSurgical);
            this.Controls.Add(this.txtMedication);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblTotalCharges);
            this.Controls.Add(this.lblAdditionalCharges);
            this.Controls.Add(this.lblBaseCharges);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblRehab);
            this.Controls.Add(this.lblLab);
            this.Controls.Add(this.lblSurgical);
            this.Controls.Add(this.lblMedication);
            this.Controls.Add(this.lblDays);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblMedication;
        private System.Windows.Forms.Label lblSurgical;
        private System.Windows.Forms.Label lblLab;
        private System.Windows.Forms.Label lblRehab;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblBaseCharges;
        private System.Windows.Forms.Label lblAdditionalCharges;
        private System.Windows.Forms.Label lblTotalCharges;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtMedication;
        private System.Windows.Forms.TextBox txtSurgical;
        private System.Windows.Forms.TextBox txtLab;
        private System.Windows.Forms.TextBox txtRehab;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

