using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CALAPP : Form
    {
        private StringBuilder currentExpression;
        private double result;

        public CALAPP()
        {
            InitializeComponent();
            currentExpression = new StringBuilder();
            result = 0;
        }

        private void CALAPP_Load(object sender, EventArgs e)
        {

        }

        private void output_TextChanged(object sender, EventArgs e)
        {
        }

        private void clear_Click(object sender, EventArgs e)
        {
            currentExpression.Clear();
            output.Text = "0";
        }
        private void percent_Click(object sender, EventArgs e)
        {
            AppendToExpression("%");
        }

        private void divide_Click(object sender, EventArgs e)
        {
            AppendToExpression("/");
        }

        private void seven_Click(object sender, EventArgs e)
        {
            AppendToExpression("7");
        }

        private void eight_Click(object sender, EventArgs e)
        {
            AppendToExpression("8");
        }

        private void nine_Click(object sender, EventArgs e)
        {
            AppendToExpression("9");
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            AppendToExpression("*");
        }

        private void four_Click(object sender, EventArgs e)
        {
            AppendToExpression("4");
        }

        private void five_Click(object sender, EventArgs e)
        {
            AppendToExpression("5");
        }

        private void six_Click(object sender, EventArgs e)
        {
            AppendToExpression("6");
        }

        private void minus_Click(object sender, EventArgs e)
        {
            AppendToExpression("-");
        }

        private void one_Click(object sender, EventArgs e)
        {
            AppendToExpression("1");
        }

        private void two_Click(object sender, EventArgs e)
        {
            AppendToExpression("2");
        }

        private void three_Click(object sender, EventArgs e)
        {
            AppendToExpression("3");
        }

        private void plus_Click(object sender, EventArgs e)
        {
            AppendToExpression("+");
        }

        private void zero_Click(object sender, EventArgs e)
        {
            AppendToExpression("0");
        }

        private void dot_Click(object sender, EventArgs e)
        {
            AppendToExpression(".");
        }

        private void equal_Click(object sender, EventArgs e)
        {
            try
            {
                var expression = currentExpression.ToString();
                result = EvaluateExpression(expression);
                output.Text = result.ToString();
                currentExpression.Clear();
            }
            catch (Exception ex)
            {
                output.Text = "Error";
            }
        }
        
        private void AppendToExpression(string text)
        {
            currentExpression.Append(text);
            output.Text = currentExpression.ToString();
        }
        
        private double EvaluateExpression(string expression)
        {
            var dataTable = new DataTable();
            return Convert.ToDouble(dataTable.Compute(expression, string.Empty));
        }
    }
}
