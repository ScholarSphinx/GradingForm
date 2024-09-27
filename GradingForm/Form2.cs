using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingForm
{
    public partial class Form2 : Form
    {
        public Form2(double averageMark, int highestMark, char symbol)
        {
            InitializeComponent();

            // Display the values passed from Form1
            textBoxAverage.Text = averageMark.ToString();
            textBoxHighest.Text = highestMark.ToString();
            textBoxSymbol.Text = symbol.ToString() ;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // You can include any additional setup when the form loads here.
        }
    }

}
