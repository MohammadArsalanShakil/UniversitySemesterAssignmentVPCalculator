using System;
using System.Collections;
using TaxCalculatorLogic;

namespace VP_Project
{
    public partial class Calculator : MaterialSkin.Controls.MaterialForm
    {
        static Calculations cal;
        ArrayList operands = new ArrayList();
        ArrayList operators = new ArrayList();
        string data = "";
        public Calculator()
        {
            InitializeComponent();
            cal = new Calculations();
        }

        private void zerobtn_Click(object sender, EventArgs e)
        {
            data += "0";
            calrtb.Text = data;
        }

        private void plusbyminusbtn_Click(object sender, EventArgs e)
        {
            data = (int.Parse(data) * -1).ToString();
            calrtb.Text = data;
        }

        private void dotbtn_Click(object sender, EventArgs e)
        {
            data += ".";
            calrtb.Text = data;
        }

        private void threebtn_Click(object sender, EventArgs e)
        {
            data += "3";
            calrtb.Text = data;
        }

        private void twobtn_Click(object sender, EventArgs e)
        {
            data += "2";
            calrtb.Text = data;
        }

        private void onebtn_Click(object sender, EventArgs e)
        {
            data += "1";
            calrtb.Text = data;
        }

        private void sixbtn_Click(object sender, EventArgs e)
        {
            data += "6";
            calrtb.Text = data;
        }

        private void fivebtn_Click(object sender, EventArgs e)
        {
            data += "5";
            calrtb.Text = data;
        }

        private void fourbtn_Click(object sender, EventArgs e)
        {
            data += "4";
            calrtb.Text = data;
        }

        private void ninebtn_Click(object sender, EventArgs e)
        {
            data += "9";
            calrtb.Text = data;
        }

        private void eightbtn_Click(object sender, EventArgs e)
        {
            data += "8";
            calrtb.Text = data;
        }

        private void sevenbtn_Click(object sender, EventArgs e)
        {
            data += "7";
            calrtb.Text = data;
        }

        private void divbtn_Click(object sender, EventArgs e)
        {
            operands.Add(data);
            if (operands.Count == 2)
                equalbtn_Click(this, EventArgs.Empty);
            operators.Add("/");
            data += "/\n";
            calrtb.Text = data;
        }

        private void mulbtn_Click(object sender, EventArgs e)
        {
            operands.Add(data);
            if (operands.Count == 2)
                equalbtn_Click(this, EventArgs.Empty);
            operators.Add("*");
            data += "*\n";
            calrtb.Text = data;
        }

        private void minusbtn_Click(object sender, EventArgs e)
        {
            operands.Add(data);
            if (operands.Count == 2)
                equalbtn_Click(this, EventArgs.Empty);
            operators.Add("-");
            data += "-\n";
            calrtb.Text = data;
        }

        private void plusbtn_Click(object sender, EventArgs e)
        {
            operands.Add(data);
            operators.Add("+");
            data += "+\n";
            calrtb.Text = data;
        }

        private void equalbtn_Click(object sender, EventArgs e)
        {
            operands.Add(data.Substring(data.IndexOf("\n") + 1));
            string caldata = cal.calculate(operators, operands);
            data += "\n";
            data = caldata;
            calrtb.Text = data;
            historyrtb.Text += data + "\n";
            data = caldata;
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            calrtb.Text = "";
            data = "";
            historyrtb.Text = "";
        }

        private void sinbtn_Click(object sender, EventArgs e)
        {
            operators.Add("sin");
            data += "sin\n";
            calrtb.Text = data;
        }

        private void cosbtn_Click(object sender, EventArgs e)
        {
            operators.Add("cos");
            data += "cos\n";
            calrtb.Text = data;
        }

        private void tanbtn_Click(object sender, EventArgs e)
        {
            operators.Add("tan");
            data += "tan\n";
            calrtb.Text = data;
        }

        private void sqrtbtn_Click(object sender, EventArgs e)
        {
            operators.Add("sqrt");
            data += "sqrt\n";
            calrtb.Text = data;
        }

        private void filerbtn_Click(object sender, EventArgs e)
        {
            operators.Add("filer");
            data += "filer\n";
            calrtb.Text = data;
        }

        private void nfilerbtn_Click(object sender, EventArgs e)
        {
            operators.Add("nonfiler");
            data += "nonfiler\n";
            calrtb.Text = data;
        }
    }
}
