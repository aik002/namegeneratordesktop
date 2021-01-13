using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace namegeneratordesktop
{
    public partial class Form1 : Form
    {
        string gender;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Figure out selections
            switch (gender)
            {
                case "f":
                    textBox1.Text = "fem";
                    break;

                case "m":
                    textBox1.Text = "masc";
                    break;

                case "a":
                    textBox1.Text = "and";
                    break;

                default:
                    textBox1.Text= "Unknown gender";
                    break;
            }

        }

        private void radioButtonF_CheckedChanged(object sender, EventArgs e)
        {
            gender = "f";
        }

        private void radioButtonM_CheckedChanged(object sender, EventArgs e)
        {
            gender = "m";
        }

        private void radioButtonA_CheckedChanged(object sender, EventArgs e)
        {
            gender = "a";
        }
    }
}
