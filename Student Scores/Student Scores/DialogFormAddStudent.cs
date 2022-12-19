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
    public partial class DialogFormAddStudent : Form
    {
        private Student student = new Student(); // This new Student will be sent to the Student Scores form to be processed


        public DialogFormAddStudent()
        {
            InitializeComponent();
            this.Tag = student;
        }


        // Add a score to the student's scores
        private void AddScore_Button_Click(object sender, EventArgs e)
        {
            // Parse the score in the score textbox.
            if(int.TryParse(AddScore_TextBox.Text, out int score))
            {
                if(student.AddScore(score))
                {
                    ScoresList_TextBox.Text = string.Join(" ", student.GetAllScores());
                    AddScore_TextBox.Text = string.Empty;
                }
                // Don't add the score to the form if it's an invalid score.
                else { MessageBox.Show("Valid scores must be between 0 and 100", "Add Score Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Please enter a valid score.", "Add Score Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // Removes all the scores from the new student.
        private void ClearScores_Button_Click(object sender, EventArgs e)
        {
            student.ClearScores();
            ScoresList_TextBox.Text = string.Empty;
        }

        // Validates the name of the student. Allows the OK button to be pressed if the name is valid.
        private void StudentName_TextBox_TextChanged(object sender, EventArgs e)
        {
            if(StudentName_TextBox.Text != string.Empty) // If the string isn't blank continue.
            {
                // Checks if the student's name contains all letters or whitespace.
                if (StudentName_TextBox.Text.All(c => char.IsWhiteSpace(c) || char.IsLetter(c))) 
                { 
                    FormSubmitOK_Button.Enabled = true; // Enables the use of the OK button and sets the students name to this.
                    student.Name = StudentName_TextBox.Text;
                }
                else { FormSubmitOK_Button.Enabled = false; }
            }
            else { FormSubmitOK_Button.Enabled = false; }
        }
    }
}
