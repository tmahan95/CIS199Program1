// Program 1
// CIS 199-01/-75
// Due: 2/14/2016
// By: Andrew L. Wright

// This program calculates a quote for a painting job
// based on data entered by the user

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog1
{
    public partial class Prog1Form : Form
    {
        public Prog1Form()
        {
            InitializeComponent();
        }

        private void quoteBtn_Click(object sender, EventArgs e)
        {
            // Constants
            const double SQ_FEET_PER_GAL = 325.0; // Square feet covered per gallon of paint
            const double HOURS_PER_GAL = 8.0;     // Hours of labor per gallon of paint
            const double LABOR_HR_RATE = 10.50;   // Hourly pay rate for labor

            // Input variables
            double sqFt;     // Square feet to be painted
            byte coats;      // Number of coats of paint
            double galPrice; // Price of gallon of paint

            // Output variables
            double totalSqFt;  // Total square feet, including coats
            uint gallons;      // Whole number of gallons of paint needed
            double hoursLabor; // Hours of labor needed
            double paintCost;  // Cost of paint needed
            double laborCost;  // Cost of labor needed
            double totalCost;  // Total cost of job

            // Parse input data
            sqFt = double.Parse(sqFtInTxt.Text);
            coats = byte.Parse(coatsTxt.Text);
            galPrice = double.Parse(ppgTxt.Text);

            // Perform paint job calculations
            totalSqFt = sqFt * coats;
            gallons = (uint)Math.Ceiling(totalSqFt / SQ_FEET_PER_GAL); // Round up, cast as whole number
            hoursLabor = totalSqFt / SQ_FEET_PER_GAL * HOURS_PER_GAL;
            paintCost = gallons * galPrice;
            laborCost = hoursLabor * LABOR_HR_RATE;
            totalCost = paintCost + laborCost;

            // Display results
            totalSqFtOutLbl.Text = totalSqFt.ToString("N1");
            gallonsOutLbl.Text = gallons.ToString(); // Could also use format code "D"
            hoursOutLbl.Text = hoursLabor.ToString("N1");
            paintCostOutLbl.Text = paintCost.ToString("C");
            laborCostOutLbl.Text = laborCost.ToString("C");
            totalCostOutLbl.Text = totalCost.ToString("C");
        }
    }
}
