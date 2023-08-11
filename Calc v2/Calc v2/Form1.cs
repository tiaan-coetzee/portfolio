﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_v2
{
    public partial class Form1 : Form
    {
        // Variable declaration
        string ActiveNumber = "";
        int BackGroundCalc = 0;
        int Positive = 1;

        // Form Initialization
        public Form1()
        {
            InitializeComponent();
        }

        // Functions
        public void TestVariable()
        {
            MessageBox.Show(ActiveNumber);
        }

        public void Print()
        {
            LabelDisplay.Text = ActiveNumber;
        }


        // Clicking on labels
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Click on Buttons
        private void Num1_Click(object sender, EventArgs e)
        {
            ActiveNumber = string.Concat(ActiveNumber, "1");
            Print();
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            ActiveNumber = string.Concat(ActiveNumber, "2");
            Print();
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            ActiveNumber = string.Concat(ActiveNumber, "3");
            Print();
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            ActiveNumber = string.Concat(ActiveNumber, "4");
            Print();
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            ActiveNumber = string.Concat(ActiveNumber, "5");
            Print();
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            ActiveNumber = string.Concat(ActiveNumber, "6");
            Print();
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            ActiveNumber = string.Concat(ActiveNumber, "7");
            Print();
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            ActiveNumber = string.Concat(ActiveNumber, "8");
            Print();
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            ActiveNumber = string.Concat(ActiveNumber, "9");
            Print();
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            ActiveNumber = string.Concat(ActiveNumber, "0");
            Print();
        }

        // Click on controls

        private void CntrDel_Click(object sender, EventArgs e)
        {
            try
            {
                ActiveNumber = ActiveNumber.Remove(ActiveNumber.Length - 1);
                Print();
            }

            catch 
            { 
            
            }
        }

        private void CntrClear_Click(object sender, EventArgs e)
        {
            ActiveNumber = "";
            BackGroundCalc = 0;
            Print();
            LabelRunningTotal.Text = BackGroundCalc.ToString();
        }

        // Math operations buttons

        private void OpPlus_Click(object sender, EventArgs e)
        {
            try
            {
                BackGroundCalc += Int32.Parse(ActiveNumber);
                ActiveNumber = "";
                Print();
            }

            catch 
            {
                ActiveNumber = "";
                Print();
            }
        }

        private void OpEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if (Positive == 1)
                {
                    BackGroundCalc += Int32.Parse(ActiveNumber);
                    ActiveNumber = "";
                    Print();
                    LabelRunningTotal.Text = BackGroundCalc.ToString();
                }

                if (Positive == 0)
                {
                    BackGroundCalc -= Int32.Parse(ActiveNumber);
                    ActiveNumber = "";
                    Print();
                    LabelRunningTotal.Text = BackGroundCalc.ToString();
                    Positive = 1;

                }


            }

            catch
            {
            }

        }

        private void OpMinus_Click(object sender, EventArgs e)
        {
            try
            {
                BackGroundCalc -= Int32.Parse(ActiveNumber);
                ActiveNumber = "";
                Print();
                Positive = 0;
                
            }

            catch
            {
                Positive = 0;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
