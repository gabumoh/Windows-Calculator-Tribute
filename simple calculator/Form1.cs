using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_Pressed = false;
        Boolean cleardisplay = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void digitclick(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_Pressed))
                result.Clear();

            operation_Pressed = false;

            Button b = (Button)sender;
            Boolean cleardisplay = false;
            if (cleardisplay == true)
            {
                result.Text = "";
            }


            result.Text = result.Text + b.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttnequal_Click(object sender, EventArgs e)
        {
            equation.Text = "";
           Select case(operation);

           // switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                   
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    cleardisplay = true;
                    break;
                    cleardisplay = true;
                default:
                    break;
            }//end switch
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_Pressed = true;
            equation.Text = value + " " + operation;
        }
    }
}
