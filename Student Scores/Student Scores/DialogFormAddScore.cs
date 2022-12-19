using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Scores
{
    public partial class DialogFormAddScore : Form
    {
        private int scoreToAdd = 0;

        public DialogFormAddScore()
        {
            InitializeComponent();
            this.Tag = scoreToAdd;
        }

        // Changes the OK availability based on if the score is in a valid format.
        public void Score_TextBox_Changed(Object sender, EventArgs e)
        {
            if (Score_TextBox.Text != string.Empty) // If the string isn't blank continue.
            {
                // Checks if the student's score contains all numbers
                if (Score_TextBox.Text.All(char.IsDigit))
                {
                    if(int.TryParse(Score_TextBox.Text, out scoreToAdd))
                    {
                        if(scoreToAdd >= 0 && scoreToAdd <= 100)
                        {
                            this.Tag = scoreToAdd;
                            AddScore_Button.Enabled = true; // Enables the use of the OK button
                        }
                        else { AddScore_Button.Enabled = false; }
                    }
                }
                else { AddScore_Button.Enabled = false; }
            }
            else { AddScore_Button.Enabled = false; }
        }
    }
}
