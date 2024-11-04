using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_12_13_Assignments
{
    public partial class Form1 : Form
    {
        Random rng = new Random();
        double calCost, extraCost;
        int editCount = 0;
        int size = 0, lettuce = 0, onion = 0, tomato = 0, cheese = 0, mustard = 0, mayo = 0;
        string Msize, Mlettuce, Monion, Mtomato, Mcheese, Mmustard, Mmayo;

        public Form1()
        {
            InitializeComponent();
        }


        //submit btn here
        private void button1_Click(object sender, EventArgs e)
        {

            calCost = 0;
            extraCost = 0;
            //price for like the first size options
            if (radSmall.Checked)
            {
                calCost = calCost + 2.50;
                size = 0;
            }
            else if (radLarge.Checked)
            {
                calCost = calCost + 4;
                size = 1;
            }

            //secnd part
            if (chkLettuce.Checked)
            {
                extraCost = extraCost + 0.10;
                lettuce = 1;
            }
            else
            {
                lettuce = 0;
            }
            if (chkOnion.Checked)
            {
                extraCost = extraCost + 0.10;
                onion = 1;

            }
            else
            {
                onion = 0;
            }
            if (chkTomato.Checked)
            {
                extraCost = extraCost + 0.10;
                tomato = 1;

            }
            else
            {
                tomato = 0;
            }
            if (chkCheese.Checked) //expensive
            {
                extraCost = extraCost + 0.50;
                cheese = 1;

            }
            else
            {
                cheese = 0;
            }
            if (chkMayonnaise.Checked)
            { 
                mayo = 1;
            }
            else
            {
                mayo = 0;
            }
            if (chkMustard.Checked)
            {
                mustard = 1;
            }
            else
            {
                mustard = 0;
            }

            //Final price and such things here
            lblTotal.Text = "Total: " + (calCost + extraCost).ToString("C");

            editCount++;
            lbleditCount.Text = "Order has been Changed: " + (editCount) + " times";

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (size == 0)
            {
                Msize = "Small";
            }
            else if (size == 1)
            {
                Msize = "Large";
            }


            if (mayo == 1)
            {
                Mmayo = "Mayonnaise";
            }
            if (mustard == 1)
            {
                Mmustard = "Mustard";
            }
            if (lettuce == 1)
            {
                Mlettuce = "Lettuce";
            }
            if (tomato == 1)
            {
                Mtomato = "Tomato";
            }
            if (onion == 1)
            {
                Monion = "Onion";
            }
            if (cheese == 1)
            {
                Mcheese = "Cheese";
            }

            string Purchase = Mmayo + Mmustard + Mlettuce + Mtomato + Monion + Mcheese;

            string message = "Your order is " + (calCost + extraCost).ToString("C") + Purchase;
                
            string title = "Order #" + rng.Next(500) + ", Thank you.";
            MessageBox.Show(message, title);
            editCount = 0;
        }
    }
}
