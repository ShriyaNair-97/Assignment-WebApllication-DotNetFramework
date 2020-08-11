using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorLibrary;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculate obj;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            obj = new Calculate();
            obj.FirstNumber = Convert.ToInt32(txtFirstNumber.Text);
            obj.SecondNumber= Convert.ToInt32(txtSecondNumber.Text);
            lblResult.Text = "Addition of Two numbers :" + obj.Add().ToString();
            txtFirstNumber.Text = "";
            txtSecondNumber.Text = "";
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            obj = new Calculate();
            obj.FirstNumber = Convert.ToInt32(txtFirstNumber.Text);
            obj.SecondNumber = Convert.ToInt32(txtSecondNumber.Text);
            lblResult.Text = "Substraction of Two numbers :" + obj.Substract().ToString();
            txtFirstNumber.Text = "";
            txtSecondNumber.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            obj = new Calculate();
            obj.FirstNumber = Convert.ToInt32(txtFirstNumber.Text);
            obj.SecondNumber = Convert.ToInt32(txtSecondNumber.Text);
            lblResult.Text = "Multiplication of Two numbers :" + obj.Multiply().ToString();
            txtFirstNumber.Text = "";
            txtSecondNumber.Text = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            obj = new Calculate();
            obj.FirstNumber = Convert.ToInt32(txtFirstNumber.Text);
            obj.SecondNumber = Convert.ToInt32(txtSecondNumber.Text);
            lblResult.Text = "Division of Two numbers :" + obj.Divide().ToString();
            txtFirstNumber.Text = "";
            txtSecondNumber.Text = "";
        }
    }
}
