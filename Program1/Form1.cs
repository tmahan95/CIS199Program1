//Timothy Mahan
//Program 1
//Due: 2/14/16
//Course Section: 01
/*This program take the area you are going to paint in square feet, the number of coats you are going to apply, 
and calculates the cost of paint, labor, total cost, number of hours, gallons and total area you are going to paint.
This information is then displayed for the use to see. I also added a clear button so you can calculate more
jobs without opening and closing the program.
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clcJobButton_Click(object sender, EventArgs e)
        {
            //inputs from user
            double area = 0; //Hold square footage of area to paint from areaTxtBox
            int coats = 0; //Hold number of coats from coatsTxtBox
            double priceGallon = 0; //Hold price per gallon of paint from priceGallonTxtBox

            //outputs and other variables/constants
            double totalGallons = 0; //Hold total gallons needed, always rounded up to next int. 
            double totalPaintCost = 0; //Hold total cost of paint to nearest $.01
            double totalArea = 0; //Hold total area to paint * number of coats.
            double laborCost = 0; //Hold total cost of labor to nearest $.01
            double totalCost = 0; //Hold total cost of gallon of paint and labor.
            double totalHours = 0; //Hold total hours needed to complete job.
            const double COST_LABOR_HOUR = 10.50; //Cost of labor per hour company charges.
            const double AREA_PER_GALLON = 325.0; //Area covered by 1 gallon of paint.
            const double HOURS_PER_GALLON = 8; //Hours needed to paint 325 SqFt of space.


            if (double.TryParse(areaTxtBox.Text, out area))
            {
                if (int.TryParse(coatsTxtBox.Text, out coats))
                {
                    if (double.TryParse(priceGallonTxtBox.Text, out priceGallon))
                    {
                        totalArea = area * coats; //Calculates the total area that will be painted and puts it in the Total SqFt label Text property
                        ttlSqFtDispLbl.Text = totalArea.ToString();

                        totalHours = (totalArea * (HOURS_PER_GALLON / AREA_PER_GALLON));//Calculates the hours needed to paint and sends result to ttlHours label Text property
                        ttlHoursDispLbl.Text = Math.Round(totalHours,1).ToString();

                        totalGallons = Math.Ceiling(totalArea / AREA_PER_GALLON); //Calculates total gallons needed to complete paint job and stores it in ttlGallons label Test property
                        ttlGallonsDispLbl.Text = totalGallons.ToString();

                        totalPaintCost = priceGallon * totalGallons; //Calculates Total cost of paint and store result in costPaint label Text Property
                        costPaintDispLbl.Text = totalPaintCost.ToString("c");

                        laborCost = COST_LABOR_HOUR * totalHours; //Calculates total cost of labor and stores it in laborCost label Text propert
                        laborCostDispLbl.Text = laborCost.ToString("c");

                        totalCost = laborCost + totalPaintCost; // Calculates total cost and displays it in the ttlCost label Text property
                        ttlCostDispLbl.Text = totalCost.ToString("c");

                    }
                    else 
                    {
                        MessageBox.Show("Invalid data entered in the Gallons box, please only enter numbers"); //Informs the user that invalid data was entered into the Gallons box
                    }
                    
                    }
                else 
                    {
                        MessageBox.Show("Invalid data entered in the Coats box, please only enter whole numbers"); //Informs the user that invalid data was entered into the Coats box
                }
                }
            else
            {
            MessageBox.Show("Invalid data entered in the Area box, please only enter numbers"); //Informs the user that invalid data was entered into the Area box
            }
            }

        private void clearBttn_Click(object sender, EventArgs e) //Clears text from all text boxes and labels.
        {
            areaTxtBox.Text = "";
            coatsTxtBox.Text = "";
            priceGallonTxtBox.Text = "";
            ttlSqFtDispLbl.Text = "";
            ttlGallonsDispLbl.Text = "";
            ttlHoursDispLbl.Text = "";
            costPaintDispLbl.Text = "";
            laborCostDispLbl.Text = "";
            ttlCostDispLbl.Text = "";


        }



        }
    }
