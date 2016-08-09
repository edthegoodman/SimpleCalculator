using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class SimpleCalculator : Form
    {

        private MyCalculator mc;
        public SimpleCalculator()
        {
            InitializeComponent();
            mc = new MyCalculator();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    mc.FirstValue = Convert.ToDouble(firstValueTextBox.Text);
            //    mc.SecondValue = Convert.ToDouble(secondValueTextBox.Text);
            //} catch (FormatException)
            //{
            //    errorDisplay.Text = "Please enter Numberical Values Only!";
            //    errorDisplay.Visible = true;
            //} finally
            //{
            //    mc.FirstValue = 0;
            //    mc.SecondValue = 0;
            //    errorDisplay.Visible = false;
            //}

            mc.FirstValue = Convert.ToDouble(firstValueTextBox.Text);
            mc.SecondValue = Convert.ToDouble(secondValueTextBox.Text);
            resultTextBox.Text = mc.Add().ToString("F");
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            mc.FirstValue = Convert.ToDouble(firstValueTextBox.Text);
            mc.SecondValue = Convert.ToDouble(secondValueTextBox.Text);
            resultTextBox.Text = mc.Subtract().ToString("F");
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            mc.FirstValue = Convert.ToDouble(firstValueTextBox.Text);
            mc.SecondValue = Convert.ToDouble(secondValueTextBox.Text);
            resultTextBox.Text = mc.Multiply().ToString("F");
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            mc.FirstValue = Convert.ToDouble(firstValueTextBox.Text);
            mc.SecondValue = Convert.ToDouble(secondValueTextBox.Text);
            resultTextBox.Text = mc.Divide().ToString("F");

        }
    }

    public class MyCalculator
    {

        public double FirstValue { get; set; }
        public double SecondValue { get; set; }

        public double Add()
        {
            return (FirstValue + SecondValue);
        }

        public double Subtract()
        {
            return (FirstValue - SecondValue);
        }

        public double Multiply()
        {
            return (FirstValue * SecondValue);
        }

        public double Divide()
        {
            return (FirstValue / SecondValue);
        }
    }
}
