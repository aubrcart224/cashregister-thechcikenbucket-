using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashregister
{
    public partial class Form1 : Form
    {
        //global variables 
        double chicken = 1.00;
        double drink = 2.00;
        double fries = 2.00;
        double chickenTotal;
        double drinkTotal;
        double friesTotal;
        double subTotal;
        double tax;
        double total;
        double change;
        double tendered;


        public Form1()
        {
            InitializeComponent();
            chnageButton.Enabled = false;
            print.Enabled = false;
            resetButton.Enabled = false;
        }

        private void titalLable_Click(object sender, EventArgs e)
        {

        }

        private void chickenLabel_Click(object sender, EventArgs e)
        {

        }

        private void friesLabel_Click(object sender, EventArgs e)
        {

        }

        private void chickenTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void calaculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // get inputs
                chickenTotal = Convert.ToDouble(chickenTextbox.Text);
                drinkTotal = Convert.ToDouble(drinkTextbox.Text);
                friesTotal = Convert.ToDouble(friesTextbox.Text);
                // do your calculations
                subTotal = chickenTotal + (drinkTotal * drink) + (friesTotal * fries);

                total = subTotal * 1.13;
                tax = total - subTotal;

                // show outputs
                subtotalLabel.Text = $"Sub Total:   ${subTotal.ToString("0.00")}";
                taxLabel.Text = $"Tax:  ${tax.ToString("0.00")}";
                totalLabel.Text = $"Total:  ${total.ToString("0.00")}";
                chnageButton.Enabled = true;
                
            }
            catch { printLabel.Text = "Only enter numbers."; }

        }

        private void chnageButton_Click(object sender, EventArgs e)
        {
            try
            {
                //get imput 
                tendered = Convert.ToDouble(tenderedText.Text);

                // math 
                change = tendered - total;

                //output 
                changeLabel.Text = $"Chnage:    ${change.ToString("0.00")}";
                print.Enabled = true;
            }
            catch { printLabel.Text = "Only enter numbers."; }

        }

        private void printLabel_Click(object sender, EventArgs e)
        {

        }

        private void print_Click(object sender, EventArgs e)
        {
            
            //calculations 

            double totalFriesPrice = friesTotal * fries;
            double totalDrinkPrice = drinkTotal * drink;

            //print
            printLabel.Text = $"Thank you for chosing The Chicken Bucket ";
            printLabel.Text += $"\nChicken:          x{chickenTotal} @   ${chickenTotal.ToString("0.00")}";
            printLabel.Text += $"\nFries:               x{friesTotal} @   ${totalFriesPrice.ToString("0.00")}";
            printLabel.Text += $"\nDrinks:             x{drinkTotal} @   ${totalDrinkPrice.ToString("0.00")}";
            printLabel.Text += $"\nSubtotal:                                ${subTotal.ToString("0.00")}";
            printLabel.Text += $"\nTax:                                         ${tax.ToString("0.00")}";
            printLabel.Text += $"\nTotal:                                      ${total.ToString("0.00")}";
            printLabel.Text += $"\nTendered:                               ${tendered.ToString("0.00")}";
            printLabel.Text += $"\nChange:                                  ${change.ToString("0.00")}";
            printLabel.Text += "\n\nThank you for chosing The Chciken Bucket";

            // enable new order button
            resetButton.Enabled = true;


        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //reset all (new order)
            chickenTotal = 0;
            drinkTotal = 0;
            friesTotal = 0;
            printLabel.Text = "";
            chickenTextbox.Text = "";
            friesTextbox.Text = "";
            drinkTextbox.Text = "";
            tenderedText.Text = "";
            subtotalLabel.Text = "Sub Total:";
            totalLabel.Text = "Total:";
            taxLabel.Text = "Tax:";
            changeLabel.Text = "Change:";
            resetButton.Enabled = false;
            chnageButton.Enabled = false;
            print.Enabled = false;


        }
    }
}
