using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantBillingProject
{
    public partial class frmRestaurantBilling : Form
    {
        public frmRestaurantBilling()
        {
            InitializeComponent();
        }       
        
        //Declarations and Assignments

        const double dblBURGER_PRICE = 3.27, //Sets Price for Burgers
                     dblFRIES_PRICE = 1.57, //Sets Prices for Fries
                     dblDRINK_PRICE = 0.94, //Sets Prices for Drinks
                     dblTAX_RATE = 0.07; //Sets Tax Rate

        int intBurger = 0, //Integer Count for Burges, Fries, and Drinks (starts at 0)
            intFries = 0, //Integer Count for Burges, Fries, and Drinks (starts at 0)
            intDrink = 0; //Integer Count for Burges, Fries, and Drinks (starts at 0)

        double dblSubtotal = 0, //Subtotal (starts at 0)
               dblTax = 0, //Tax (starts at 0)
               dblTotal = 0, //Total (starts at 0)
               dblTip = 0; //Tip (starts at 0)

        //Click on Burger Pic

        private void picBurger_Click(object sender, EventArgs e)
        {
            intBurger = intBurger + 1; //Add 1 to Burger Count
            lblBurgerTotal.Text = intBurger.ToString(); //Display New Burger Count

            //Calculate Sub-total, Tax, and Total using updated Burger Count

            dblSubtotal = dblSubtotal + dblBURGER_PRICE; //Updates Sub-total
            lblSubtotal.Text = dblSubtotal.ToString("c"); //Display Updated Subtotal Label 

            dblTax = dblSubtotal * dblTAX_RATE; //Updates Tax
            lblTax.Text = dblTax.ToString("c"); //Display Updated Tax Label

            dblTotal = dblSubtotal + dblTax +dblTip; //Updates Total
            lblTotal.Text = dblTotal.ToString("c"); //Display Updated Total Label
        }

        //Burger Pic Animations

        private void picBurger_MouseDown(object sender, MouseEventArgs e)
        {
            //Resizes Burger Pic so it appears to have been pressed down on MouseDown
            picBurger.Size = new Size(70, 70);
            picBurger.Location = new Point(18, 35);
        }

        private void picBurger_MouseUp(object sender, MouseEventArgs e)
        {
            //Return Burger Pic to original size on MouseUp
            picBurger.Size = new Size(80, 80);
            picBurger.Location = new Point(12, 31);
        }

        private void picBurger_MouseHover(object sender, EventArgs e)
        {
            //Slightly Enlarge Burger Pic on MouseHover
            picBurger.Size = new Size(85, 85);
            picBurger.Location = new Point(10, 30);
        }

        private void picBurger_MouseLeave(object sender, EventArgs e)
        {
            //Return Burger Pic to original size on MouseLeave
            picBurger.Size = new Size(80, 80);
            picBurger.Location = new Point(12, 31);
        }

        //Click on Fries Pic

        private void picFries_Click(object sender, EventArgs e)
        {
            intFries = intFries + 1; //Add 1 to Fries Count
            lblFriesTotal.Text = intFries.ToString(); //Display New Fries Count

            //Calculate Sub-total, Tax, and Total using updated Fries Count

            dblSubtotal = dblSubtotal + dblFRIES_PRICE; //Updates Sub-total
            lblSubtotal.Text = dblSubtotal.ToString("c"); //Display Updated Subtotal Label 

            dblTax = dblSubtotal * dblTAX_RATE; //Updates Tax
            lblTax.Text = dblTax.ToString("c"); //Display Updated Tax Label

            dblTotal = dblSubtotal + dblTax + dblTip; //Updates Total
            lblTotal.Text = dblTotal.ToString("c"); //Display Updated Total Label
        }

        //Fries Pic Animations

        private void picFries_MouseDown(object sender, MouseEventArgs e)
        {
            //Resizes Fries Pic so it appears to have been pressed down on MouseDown
            picFries.Size = new Size(70, 70);
            picFries.Location = new Point(117, 35);
        }

        private void picFries_MouseUp(object sender, MouseEventArgs e)
        {
            //Return Fries Pic to original size on MouseUp
            picFries.Size = new Size(80, 80);
            picFries.Location = new Point(111, 31);
        }

        private void picFries_MouseHover(object sender, EventArgs e)
        {
            //Slightly Enlarge Fries Pic on MouseHover
            picFries.Size = new Size(85, 85);
            picFries.Location = new Point(109, 30);
        }

        private void picFries_MouseLeave(object sender, EventArgs e)
        {
            //Return Fries Pic to original size on MouseLeave
            picFries.Size = new Size(80, 80);
            picFries.Location = new Point(111, 31);
        }

        //Click on Drink Pic

        private void picDrink_Click(object sender, EventArgs e)
        {
            intDrink = intDrink + 1; //Add 1 to Fries Count
            lblDrinkTotal.Text = intDrink.ToString(); //Display New Drink Count

            //Calculate Sub-total, Tax, and Total using updated Drink Count

            dblSubtotal = dblSubtotal + dblDRINK_PRICE; //Updates Sub-total
            lblSubtotal.Text = dblSubtotal.ToString("c"); //Display Updated Subtotal Label 

            dblTax = dblSubtotal * dblTAX_RATE; //Updates Tax
            lblTax.Text = dblTax.ToString("c"); //Display Updated Tax Label

            dblTotal = dblSubtotal + dblTax + dblTip; //Updates Total
            lblTotal.Text = dblTotal.ToString("c"); //Display Updated Total Label
        }

        //Drink Pic Animations
        
        private void picDrink_MouseDown(object sender, MouseEventArgs e)
        {
            //Resizes Drink Pic so it appears to have been pressed down on MouseDown
            picDrink.Size = new Size(70, 70);
            picDrink.Location = new Point(216, 33);
        }

        private void picDrink_MouseUp(object sender, MouseEventArgs e)
        {
            //Return Drink Pic to original size on MouseUp
            picDrink.Size = new Size(80, 80);
            picDrink.Location = new Point(210, 29);
        }
        
        private void picDrink_MouseHover(object sender, EventArgs e)
        {
            //Slightly Enlarge Drink Pic on MouseHover
            picDrink.Size = new Size(85, 85);
            picDrink.Location = new Point(208, 28);
        }

        private void picDrink_MouseLeave(object sender, EventArgs e)
        {
            //Return Drink Pic to original size on MouseLeave
            picDrink.Size = new Size(80, 80);
            picDrink.Location = new Point(210, 29);
        }

        //Click on Add Tip Button

        private void btnTip_Click(object sender, EventArgs e)
        {
            try
            {

                dblTotal = dblTotal - dblTip; //Remove Previous Tip Amount

                dblTip = 0; //Resets Tip Back to Zero

                dblTip = double.Parse(txtTip.Text); //Pulls User Input from txtTip 

                dblTotal = dblTotal + dblTip; //Updates Total with Tip
                lblTotal.Text = dblTotal.ToString("c"); //Display Updated Total Label

                lblTipIncluded.Text = "Total includes a " + dblTip.ToString("c") + " tip!"; //Display Tip Total with Message

                btnTip.Enabled = false; //Disables Add Tip Button
            }
            catch
            {
                //Display Error Message
                MessageBox.Show("Amount entered must be a number!");
            }
        }

        //Click on Clear Button

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Resets All Variables to Zero

            intBurger = 0;
            intFries = 0;
            intDrink = 0;

            dblSubtotal = 0;
            dblTax = 0;
            dblTotal = 0;
            
            dblTip = 0;

            //Resets Labels to Default

            lblBurgerTotal.Text = intBurger.ToString();
            lblFriesTotal.Text = intFries.ToString();
            lblDrinkTotal.Text = intDrink.ToString();

            lblSubtotal.Text = dblSubtotal.ToString("c");
            lblTax.Text = dblTax.ToString("c");
            lblTotal.Text = dblTotal.ToString("c");

            lblTipIncluded.Text = "";
            txtTip.Text = "";

            btnTip.Enabled = true; //Enables Add Tip Button

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Exit Program
        }   
    }
}
