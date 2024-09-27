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
    public partial class Form1 : Form
    {
        private List<int> marks = new List<int>();

        // Global variables (class-level) for average, highest mark, and symbol
        private double averageMark = 0;
        private int highestMark = 0;
        private char symbol;

        public Form1()
        {
            InitializeComponent();
        }



       
        // Function to calculate symbol based on average
        private char CalculateSymbol(double average)
        {
            if (average >= 75)
                return 'A';
            else if (average >= 70)
                return 'B';
            else if (average >= 60)
                return 'C';
            else if (average >= 50)
                return 'D';
            else
                return 'E';
        }

       
        // TRANSFER MARKS BUTTON: Adds mark to the listbox
        private void transfer_Click_1(object sender, EventArgs e)
        {
            try
            {
                int mark = int.Parse(textBoxMark.Text); // Get the mark from the TextBox
                if (mark >= 0 && mark <= 100) // Validate mark between 0 and 100
                {
                    marks.Add(mark);
                    listBoxMarks.Items.Add(mark); // Add to ListBox
                    textBoxMark.Clear(); // Clear input box
                }
                else
                {
                    MessageBox.Show("Please enter a mark between 0 and 100.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please enter a valid integer.");
            }
        }
        // PROCESS MARKS BUTTON: Calculate average, highest mark, and determine symbol
        private void processmarks_Click_1(object sender, EventArgs e)
        {
            if (marks.Count > 0)
            {
                int total = 0;
                highestMark = marks[0]; // Start with the first mark as highest

                for (int i = 0; i < marks.Count; i++)
                {
                    total += marks[i];

                    if (marks[i] > highestMark) // Find highest mark
                    {
                        highestMark = marks[i];
                    }
                }

                // Calculate average and round it to two decimal places, then update the global variable
                averageMark = Math.Round((double)total / marks.Count, 2);

                // Get the symbol based on the average and update the global variable
                symbol = CalculateSymbol(averageMark);
            }
            else
            {
                MessageBox.Show("No marks to process. Please enter marks first.");
            }
        }
        // SUMMARY BUTTON: Open Form2 and pass data
        private void summary_Click_1(object sender, EventArgs e)
        {
            if (marks.Count > 0)
            {
                // Since processmarks_Click already computes the values, we just pass the global variables
                Form2 form2 = new Form2(averageMark, highestMark, symbol);
                form2.Show();
            }
            else
            {
                MessageBox.Show("No marks to summarize. Please process marks first.");
            }
        }
    }

}
