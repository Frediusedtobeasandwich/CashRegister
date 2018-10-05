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

namespace CashRegister
{
    public partial class mcdonaldsLite : Form
    {
        int burgerNumber;
        int friesNumber;
        int drinkNumber;
        int paidNumber;
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

        private void calculateTotal_Click(object sender, EventArgs e)
        {
            try
            {
                burgerNumber = Convert.ToInt16(numberOfBurger.Text);
                friesNumber = Convert.ToInt16(numberOfFries.Text);
                drinkNumber = Convert.ToInt16(numberOfDrinks.Text);
            }

            catch
            {
                subPrice.Text = "0";
                taxPrice.Text = "0";
                totalPrice.Text = "0";
            }

            burgerCost = burgerNumber * BURGER_COST;
            friesCost = friesNumber * FRIES_COST;
            drinkCost = drinkNumber * DRINKS_COST;
            subCost = burgerCost + friesCost + drinkCost;
            subPrice.Text = subCost.ToString("C");

            tax = subCost * HST;
            taxPrice.Text = tax.ToString("C");

            totalCost = subCost + tax;
            totalPrice.Text = totalCost.ToString("C");
        }

        private void burgerTim_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush backBrush = new SolidBrush(Color.Red);
            SolidBrush borderBrush = new SolidBrush(Color.Gold);
            Pen goldenArches = new Pen(Color.Gold, 10);

            g.FillRectangle(borderBrush, 240, 10, 20, 530);
            g.FillRectangle(borderBrush, 10, 300, 240, 20);
            g.DrawArc(goldenArches, 275, 300, 90, 180, 130, 280);
            g.DrawArc(goldenArches, 350, 300, 90, 180, 130, 280);
            g.FillRectangle(backBrush, 350, 330, 20, 530);
        }

        private void calculateChange_Click(object sender, EventArgs e)
        {
            try
            {
                paidNumber = Convert.ToInt16(paidAmount.Text);
            }

            catch
            {
                changeAmount.Text = "PAY!";
            }


            change = paidNumber - totalCost;
            changeAmount.Text = change.ToString("C");
        }

        private void printReciept_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Font reciept = new Font("Lucida Console", 8, FontStyle.Regular);
            SolidBrush penColor = new SolidBrush(Color.Black);
            SolidBrush recieptBackColor = new SolidBrush(Color.White);

            g.FillRectangle(penColor, 270, 10, 250, 300);
            g.FillRectangle(recieptBackColor, 275, 15, 240, 290);


            Thread.Sleep(500);
            g.DrawString("McDonalds Lite", reciept, penColor, 340, 40);
            Thread.Sleep(500);
            g.DrawString("Order Number 6943", reciept, penColor, 275, 70);
            Thread.Sleep(500);
            g.DrawString("October 15th, 2018", reciept, penColor, 275, 85);
            Thread.Sleep(1900);

            g.DrawString("Hamburgers: ", reciept, penColor, 275, 120);
            g.DrawString("x" + burgerNumber + " @ " + BURGER_COST + "", reciept, penColor, 380, 120);
            Thread.Sleep(500);
            g.DrawString("Fries:", reciept, penColor, 275, 135);
            g.DrawString("x" + friesNumber + " @ " + FRIES_COST + "", reciept, penColor, 380, 135);
            Thread.Sleep(500);
            g.DrawString("Drinks:", reciept, penColor, 275, 150);
            g.DrawString("x" + drinkNumber + " @ " + DRINKS_COST + "", reciept, penColor, 380, 150);
            Thread.Sleep(1000);

            g.DrawString("Sub Total:", reciept, penColor, 275, 180);
            g.DrawString(subCost.ToString("C"), reciept, penColor, 380, 180);
            Thread.Sleep(500);
            g.DrawString("Tax:", reciept, penColor, 275, 195);
            g.DrawString(tax.ToString("C"), reciept, penColor, 380, 195);
            Thread.Sleep(500);
            g.DrawString("Total:", reciept, penColor, 275, 210);
            g.DrawString(totalCost.ToString("C"), reciept, penColor, 380, 210);
            Thread.Sleep(1000);

            g.DrawString("Tendered:", reciept, penColor, 275, 240);
            g.DrawString(paidNumber.ToString("C"), reciept, penColor, 380, 240);
            Thread.Sleep(500);
            g.DrawString("Change:", reciept, penColor, 275, 255);
            g.DrawString(change.ToString("C"), reciept, penColor, 380, 255);
            Thread.Sleep(1000);

            g.DrawString("Have A Day :(", reciept, penColor, 275, 285);
            Thread.Sleep(1000);
        }
    }
}
