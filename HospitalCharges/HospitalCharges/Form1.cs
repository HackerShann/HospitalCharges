using System;
using System.Windows.Forms;

namespace HospitalCharges
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbltxtRehab_TextChanged(object sender, EventArgs e)
        {
            // Code to handle text change in lbltxtRehab (if needed)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialization code here if needed
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Validate and get user input
            if (!int.TryParse(txtDays.Text, out int days) || days < 0)
            {
                MessageBox.Show("Please enter a valid number of days.");
                return;
            }

            if (!decimal.TryParse(txtMedication.Text, out decimal medication) || medication < 0)
            {
                MessageBox.Show("Please enter valid medication charges.");
                return;
            }

            if (!decimal.TryParse(txtSurgical.Text, out decimal surgical) || surgical < 0)
            {
                MessageBox.Show("Please enter valid surgical charges.");
                return;
            }

            if (!decimal.TryParse(txtLab.Text, out decimal lab) || lab < 0)
            {
                MessageBox.Show("Please enter valid lab charges.");
                return;
            }

            if (!decimal.TryParse(txtRehab.Text, out decimal rehab) || rehab < 0)
            {
                MessageBox.Show("Please enter valid rehabilitation charges.");
                return;
            }

            // Calculate charges
            decimal baseCharges = CalcStayCharges(days);
            decimal additionalCharges = CalcMiscCharges(medication, surgical, lab, rehab);
            decimal totalCharges = CalculateTotalCharges(baseCharges, additionalCharges);

            // Display results
            lblBaseCharges.Text = $"Base Charges: ${baseCharges:F2}";
            lblAdditionalCharges.Text = $"Additional Charges: ${additionalCharges:F2}";
            lblTotalCharges.Text = $"Total Charges: ${totalCharges:F2}";
        }

        // Method to calculate base charges
        private decimal CalcStayCharges(int days)
        {
            const decimal dailyCharge = 350m;
            return dailyCharge * days;
        }

        // Method to calculate additional charges
        private decimal CalcMiscCharges(decimal medication, decimal surgical, decimal lab, decimal rehab)
        {
            return medication + surgical + lab + rehab;
        }

        // Method to calculate total charges
        private decimal CalculateTotalCharges(decimal baseCharges, decimal additionalCharges)
        {
            return baseCharges + additionalCharges;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all TextBox inputs
            txtDays.Text = "";
            txtMedication.Text = "";
            txtSurgical.Text = "";
            txtLab.Text = "";
            txtRehab.Text = "";

            // Clear all Labels showing results
            lblBaseCharges.Text = "Base Charges: ";
            lblAdditionalCharges.Text = "Additional Charges: ";
            lblTotalCharges.Text = "Total Charges: ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }
    }
}
