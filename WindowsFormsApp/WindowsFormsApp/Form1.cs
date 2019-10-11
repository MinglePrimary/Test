using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        ComplexNumber x = new ComplexNumber();
        ComplexNumber y = new ComplexNumber();

        public Form1()
        {
            InitializeComponent();

        }
       
        // thao tac click nut 1
        private void FirstButton_Click(object sender, EventArgs e)
        {
            x.Real = Int32.Parse(RealTextBox.Text);
            x.Imaginary = Int32.Parse(ImaginaryTextBox.Text);
            RealTextBox.Clear();
            ImaginaryTextBox.Clear();
            NoticeLabel.Text = "First Complex Number is..." + x.toString();
        }

        // thao tac click nut 2
        private void SecondButton_Click(object sender, EventArgs e)
        {
            y.Real = Int32.Parse(RealTextBox.Text);
            y.Imaginary = Int32.Parse(ImaginaryTextBox.Text);
            RealTextBox.Clear();
            ImaginaryTextBox.Clear();
            NoticeLabel.Text = "Second Complex Number is..." + y.toString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            NoticeLabel.Text = x.toString() + " + " +y.toString() + " = " + (x + y).toString();
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            NoticeLabel.Text = x.toString() + " - " + y.toString() + " = " + (x - y).toString();

        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            NoticeLabel.Text = x.toString() + " * " + y.toString() + " = " + (x * y).toString();
        }
    }

}

