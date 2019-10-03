using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseConversions
{
    public partial class Form1 : Form
    {
        int dec;
        string bin;
        string hex;
        string a;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dec = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(dec, 2);
                textBox3.Text = Convert.ToString(dec, 16);
                label4.Text = "Errors: None.";
            }
            catch
            {
                label4.Text = "Errors: Invalid input entered. (Field: Decimal - Not a 32bit int)";
            }
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bin = textBox2.Text;
                a = Convert.ToInt32(bin, 2).ToString();
                textBox1.Text = a;
                textBox3.Text = Convert.ToString(Convert.ToInt32(a), 16);
                label4.Text = "Errors: None.";
            }
            catch
            {
                label4.Text = "Errors: Invalid input entered. (Field: Binary - Not a binary number that can convert to 32bit int)";
            }
        }

        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                hex = textBox3.Text;
                a = Convert.ToString(int.Parse(hex, System.Globalization.NumberStyles.HexNumber));
                textBox1.Text = a;
                textBox2.Text = Convert.ToString(Convert.ToInt32(a), 2);
                label4.Text = "Errors: None.";
            }
            catch
            {
                label4.Text = "Errors: Invalid input entered. (Field: Hex - Not a hex number that can convert to 32bit int)";
            }
            
        }
        
    }
}
