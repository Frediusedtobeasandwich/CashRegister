using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegister
    //Fred Hammerl
{
    public partial class mcdonaldsLite : Form // This is where all variables are set up
    {
        double burgerNumber;
        double friesNumber;
        double drinkNumber;
        double paidNumber;
        double burgerCost;
        double friesCost;
        double drinkCost;
        double subCost;
        double tax;
        double totalCost;
        double change;
        const double HST = 0.13;
        const double BURGER_COST = 2.49;
        const double FRIES_COST = 1.89;
        const double DRINKS_COST = 0.99;

        public mcdonaldsLite()
        {
            InitializeComponent();
        }

        private void calculateTotal_Click(object sender, EventArgs e) // This function is where we calculate the total
        {
            try
            {
                burgerNumber = Convert.ToInt16(numberOfBurger.Text); // converts the text into an actual number
                friesNumber = Convert.ToInt16(numberOfFries.Text);
                drinkNumber = Convert.ToInt16(numberOfDrinks.Text);
            }

            catch // if all values are set to zero, it makes sure it doesn't crash
            {
                subPrice.Text = "0";
                taxPrice.Text = "0";
                totalPrice.Text = "0";
                warning.Text = "Check Values";
            }

            burgerCost = burgerNumber * BURGER_COST; // does some math
            friesCost = friesNumber * FRIES_COST;
            drinkCost = drinkNumber * DRINKS_COST;
            subCost = burgerCost + friesCost + drinkCost;
            subPrice.Text = subCost.ToString("C");

            warning.Text = "";

            tax = subCost * HST;
            taxPrice.Text = tax.ToString("C"); // displays the tax total

            totalCost = subCost + tax;
            totalPrice.Text = totalCost.ToString("C"); // displays the entire total (tax plus subPrice)
        }

        private void calculateChange_Click(object sender, EventArgs e) // this bit reads how much you paid
        {
            try
            {
                paidNumber = Convert.ToInt16(paidAmount.Text);
            }

            catch
            {
                changeAmount.Text = ""; 
            }


            change = paidNumber - totalCost;
            changeAmount.Text = change.ToString("C"); // displays the change. Will put in brackets if you still owe me money
        }

        private void printReciept_Click(object sender, EventArgs e) // this function makes the reciept
        {
            Graphics g = this.CreateGraphics(); // sets up the graphics used to make the reciept
            Font reciept = new Font("Lucida Console", 8, FontStyle.Regular);
            SolidBrush penColor = new SolidBrush(Color.Black);
            SolidBrush recieptBackColor = new SolidBrush(Color.White);

            g.FillRectangle(penColor, 270, 10, 250, 300);
            g.FillRectangle(recieptBackColor, 275, 15, 240, 290);

            SoundPlayer register = new SoundPlayer(Properties.Resources.cash); // sets the sound as the one 

            register.Play(); // makes the sound
            Thread.Sleep(700); // waits
            register.Play();
            g.DrawString("McDonalds Lite", reciept, penColor, 340, 40); // writes the thing in the quotation marks with the selected pen at the selected location
            Thread.Sleep(700); // rinse and repeat
            register.Play();
            g.DrawString("Order Number 6488", reciept, penColor, 275, 70);
            Thread.Sleep(700);
            register.Play();
            g.DrawString("October 15th, 2018", reciept, penColor, 275, 85);
            Thread.Sleep(700);
            register.Play();
            Thread.Sleep(700);

            g.DrawString("Hamburgers: ", reciept, penColor, 275, 120);
            g.DrawString("x" + burgerNumber + " @ " + BURGER_COST + "", reciept, penColor, 380, 120);
            register.Play();
            Thread.Sleep(700);
            g.DrawString("Fries:", reciept, penColor, 275, 135);
            g.DrawString("x" + friesNumber + " @ " + FRIES_COST + "", reciept, penColor, 380, 135);
            register.Play();
            Thread.Sleep(700);
            g.DrawString("Drinks:", reciept, penColor, 275, 150);
            g.DrawString("x" + drinkNumber + " @ " + DRINKS_COST + "", reciept, penColor, 380, 150);
            register.Play();
            Thread.Sleep(700);
            register.Play();
            Thread.Sleep(700);

            g.DrawString("Sub Total:", reciept, penColor, 275, 180); // keep rinsing and repeating
            g.DrawString(subCost.ToString("C"), reciept, penColor, 380, 180);
            register.Play();
            Thread.Sleep(700);
            g.DrawString("Tax:", reciept, penColor, 275, 195);
            g.DrawString(tax.ToString("C"), reciept, penColor, 380, 195);
            register.Play();
            Thread.Sleep(700);
            g.DrawString("Total:", reciept, penColor, 275, 210);
            g.DrawString(totalCost.ToString("C"), reciept, penColor, 380, 210);
            register.Play();
            Thread.Sleep(700);

            g.DrawString("Tendered:", reciept, penColor, 275, 240);
            g.DrawString(paidNumber.ToString("C"), reciept, penColor, 380, 240);
            register.Play();
            Thread.Sleep(700);
            g.DrawString("Change:", reciept, penColor, 275, 255);
            g.DrawString(change.ToString("C"), reciept, penColor, 380, 255);
            register.Play();
            Thread.Sleep(700);
            register.Play();
            Thread.Sleep(700);

            g.DrawString("Have A Day :(", reciept, penColor, 275, 285);
            register.Play();
            Thread.Sleep(700); // now you're done with the rinsing and repeating
        }

        private void newOrder_Click(object sender, EventArgs e) // resets everything
        {
            Graphics g = this.CreateGraphics(); 
            SolidBrush backColor = new SolidBrush(Color.Red);
            backColor.Color = Color.FromArgb(160, 192, 0, 0); // makes a bit of red

            numberOfBurger.Text = ""; // resets all text
            burgerNumber = 0; // sets integers to zero
            numberOfDrinks.Text = "";
            drinkNumber = 0;
            numberOfFries.Text = "";
            friesNumber = 0;
            subPrice.Text = "";
            taxPrice.Text = "";
            totalPrice.Text = "";
            paidAmount.Text = "";
            change = 0;
            changeAmount.Text = "";
            g.FillRectangle(backColor, 270, 10, 250, 300); // puts that bit of red over the reciept
        }
    }
}
