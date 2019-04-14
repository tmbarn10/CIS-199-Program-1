// Grading ID: B3049
// CIS 199-02
// Dute Date: 2/14/2017

// In short, this program is a paint job estimator that calculates the total cost of the painting project
// based on how many square feet the walls are, the amount of coats desired, and the price of paint per
// gallon. Given these three variables, the program is able to calculate the total square feet painted, the
// gallons required for the painting project, the required labor hours, the cost of the paint, the labor cost, 
// and the total cost. 




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e) // This event handler makes it to where if you press the calculate button, it calculates outputs based on the inputs.
        {
            try // checks if the input is the correct format for the outputs. If you put a letter in the box, it will bring up the error message that is in the catch line.
            {
                const double pricePerLaborHour = 10.50; // constant for the price per labor hours, which is $10.50.
                const int perGallonSquareFeet = 330; // constant that states that says for every gallon of paint, you get 330 square feet of wall space painted.
                const int perGallonLaborHoursRequired = 6; // constant that states that for every gallon, 6 hours of labor is required.

                float wallSpace; // Variable for Wall Space, uses float.
                int paintCoats; // Variable for amount of coats desired. Integer because you can't have half a coat of paint.
                float pricePPG; // Variable for price of paint per gallon, float.
                float totalSqFt; // Variable for total square feet, float.
                float gallonsReq; // Variable for gallons required, float.
                double gallonsRounded; // Variable for gallons required, but is rounded to the next whole number.
                float laborHours; // Variable for required labor hours, float.
                double paintCost; // Variable for cost of paint for project, double used for currency.
                double laborCost; // Variable for cost of labor for project, double used for currency.
                double totalCost; // Variable for the total cost of the paint project, double used for currency.

                wallSpace = float.Parse(wallSpaceInput.Text); // Identifies wallSpace as a float variable of the wallSpaceInput text box.
                paintCoats = int.Parse(coatsDesiredInput.Text); // Identifies paintCoats as an integer variable of the coatsDesiredInput text box.
                pricePPG = float.Parse(paintPPGInput.Text); // Identifies pricePPG as a float variable of the paintPPGInput text box.

                totalSqFt = wallSpace * paintCoats; // Calculates totalSqFt as wallSpace multiplied by the coats of paint desired.
                totalSquareFeetOutput.Text = totalSqFt.ToString("n1"); // Relays the totalSqFt string to the totalSquareFeetOutput label as text, rounded to 1 decimal of precision.

                gallonsReq = totalSqFt / perGallonSquareFeet; // Calculates gallonsReq as the totalSqFt divided by the square feet per gallon amount.
                gallonsRounded = Math.Ceiling(gallonsReq); // Rounds the gallons up to the nearest whole number, from 2.7 to 3 (You can't buy 2.7 gallons of paint).
                gallonsRequiredOutput.Text = gallonsRounded.ToString("#"); // Relays the gallonsRounded to the gallonsRequiredOutput label as text in a number.

                laborHours = perGallonLaborHoursRequired * gallonsReq; // Calculates laborHours by multiplying the amount of labor hours it takes for a gallon by the total gallons required for the project.
                requiredLaborHoursOutput.Text = laborHours.ToString("n1"); // Relays the laborHours to the requiredLaborHoursOutput label as text, rounded the the first decimal place.

                paintCost = gallonsRounded * pricePPG; // Calculates paintCost by multiplying the gallons needed for the project, rounded, by the price per gallon of paint.
                paintCostOutput.Text = paintCost.ToString("c"); // Relays the paintCost to the paintCostOutput label as currency text.

                laborCost = laborHours * pricePerLaborHour; // Calculates the laborCost by multiplying the required labor hours by the constant price per labor hour.
                laborCostOutput.Text = laborCost.ToString("c"); // Relays the laborCost to the laborCostOutput label as currency text.

                totalCost = paintCost + laborCost; // Calculates the total cost of the project by adding together the cost of the paint and cost of the labor.
                totalCostOutput.Text = totalCost.ToString("c"); // Relays the totalCost to the totalCostOutput label as currency text.


            }
            catch { MessageBox.Show("Wrong Input!"); } // Brings up the error message "Wrong Input!" if the input that was inserted is not the correct format (Using letters in this case would bring up the error message).

            

            






























        }
    }
}
