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
    public partial class DialogFormUpdateScore : Form
    {
        private int scoreToChange = 0;
        public DialogFormUpdateScore(int score)
        {
            InitializeComponent();
            scoreToChange = score;
            this.Tag = scoreToChange;
            Score_TextBox.Text = score.ToString();
        }

        // Changes the OK availability based on if the score is in a valid format.
        public void Score_TextBox_Changed(Object sender, EventArgs e)
        {
            if (Score_TextBox.Text != string.Empty) // If the string isn't blank continue.
            {
                // Checks if the student's score contains all numbers
                if (Score_TextBox.Text.All(char.IsDigit))
                {
                    if (int.TryParse(Score_TextBox.Text, out scoreToChange))
                    {
                        if (scoreToChange >= 0 && scoreToChange <= 100)
                        {
                            this.Tag = scoreToChange;
                            UpdateScore_Button.Enabled = true; // Enables the use of the OK button
                        }
                        else { UpdateScore_Button.Enabled = false; }
                    }
                }
                else { UpdateScore_Button.Enabled = false; }
            }
            else { UpdateScore_Button.Enabled = false; }
        }
    }
}
