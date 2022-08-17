/*
 Coded And Designed By Yigdo (https://github.com/yigdo)
 This project is under MIT License
 
 Date: 2022/08/17

 Copyright Yigdo 2022
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

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            try
            {
                // Empty Check
                if (txb_number_1.Text == "") { MessageBox.Show("Number 1 cannot be empty!", "Error"); return; };
                if (txb_number_2.Text == "") { MessageBox.Show("Number 2 cannot be empty", "Error"); return; };
                
                // Varible Declaretion
                double Number1 = double.Parse(txb_number_1.Text);
                double Number2 = double.Parse(txb_number_2.Text);
                double Total = 0;

                string OperationSymbol = string.Empty;
             
                // Get Checkbox
                if (chx_operation_add.Checked) { OperationSymbol = "+"; Total = Number1 + Number2; }
                else if (chx_operation_sub.Checked) { OperationSymbol = "-"; Total = Number1 - Number2; }
                else if (chx_operation_mult.Checked) { OperationSymbol = "*"; Total = Number1 * Number2; }
                else if (chx_operation_div.Checked) { OperationSymbol = "÷"; Total = Number1 / Number2; }

                lst_totals.Items.Add(
                    string.Format("{0}{1}{2} = {3}",Number1,OperationSymbol,Number2,Total)
                );
            }
            catch (Exception)
            {
                MessageBox.Show("There is a unexpected error!", "Error");
            }
        }

        private void chx_operation_div_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
