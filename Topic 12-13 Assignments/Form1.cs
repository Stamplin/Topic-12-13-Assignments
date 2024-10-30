using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        //submit btn here
        private void button1_Click(object sender, EventArgs e)
        {
            
            double calCost, extraCost;
            int editCount;
            calCost = 0;
            extraCost = 0;
            //price for like the first size options
            if (radSmall.Checked)
            {
                calCost = calCost + 2.50;
            }
            else if (radLarge.Checked)
            {
                calCost = calCost + 4;
            }
            
            //secnd part
            if (chkLettuce.Checked)
            {
                extraCost = extraCost + 0.10;
            }
            if (chkOnion.Checked)
            {
                extraCost = extraCost + 0.10;
            }
            if (chkTomato.Checked)
            {
                extraCost = extraCost + 0.10;
            }
            if (chkCheese.Checked) //expensive
            {
                extraCost = extraCost + 0.50;
            }

            //Final price and such things here
            lblTotal.Text = "Total: " + (calCost + extraCost).ToString("C");
            
            editCount = ;
            editCount++;
            lbleditCount.Text = "Order has been Changed: " + (editCount) + " times";
            
            

        }










        private void lbleditCount_Click(object sender, EventArgs e)
        {

        }
    }
}
