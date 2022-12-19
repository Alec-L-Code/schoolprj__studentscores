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
    public partial class DialogFormUpdateStudentScores : Form
    {
        private Student tempStudent = new Student(); // Temporary student object used to make changes to currentStudent
        public DialogFormUpdateStudentScores(Student currentStudent)
        {
            InitializeComponent();
            
            // Coppies the data to be able to make changes without affecting the student passed in.
            tempStudent = new Student(currentStudent.Name, currentStudent.GetAllScores());
            this.Tag = tempStudent;
        }

        public void LoadStudentInfoOnFormLoad(object sender, EventArgs e)
        {
            StudentName_TextBox.Text = tempStudent.Name;
            int[] studentScores = tempStudent.GetAllScores();

            for(int i = 0; i < studentScores.Length; i++) // Not using for each to reinforce index integrity
            {
                StudentScores_ListBox.Items.Add(studentScores[i]);
            }
        }

        // Standard Form Button Clicks
        #region ButtonClicks

        // Removes a selected score from the student's score listbox
        private void RemoveScore_Button_Click(object sender, EventArgs e)
        {
            if(StudentScores_ListBox.SelectedIndex >= 0)
            {
                tempStudent.RemoveScore(StudentScores_ListBox.SelectedIndex);
                StudentScores_ListBox.Items.RemoveAt(StudentScores_ListBox.SelectedIndex);
            }
        }

        // Clears all the students scores.
        private void ClearScores_Button_Click(object sender, EventArgs e)
        {
            tempStudent.ClearScores();
            StudentScores_ListBox.Items.Clear();
        }
        #endregion


        // Button Clicks that Generate Sub Dialogs
        #region DialogFormButtonClicks

        // Adds a score to the student's scores
        private void AddScore_Button_Click(object sender, EventArgs e)
        {
            DialogFormAddScore addScoreForm = new DialogFormAddScore();
            if(addScoreForm.ShowDialog() == DialogResult.OK)
            {
                tempStudent.AddScore((int)addScoreForm.Tag);
                StudentScores_ListBox.Items.Add((int)addScoreForm.Tag);
            }
        }
        // Updates a score selected in the student's scores listbox
        private void UpdateScore_Button_Click(object sender, EventArgs e)
        {
            if(StudentScores_ListBox.SelectedIndex >= 0)
            {
                DialogFormUpdateScore updateScoreForm = new DialogFormUpdateScore(tempStudent.GetScore(StudentScores_ListBox.SelectedIndex));
                if (updateScoreForm.ShowDialog() == DialogResult.OK)
                {
                    tempStudent.UpdateScore(StudentScores_ListBox.SelectedIndex, (int)updateScoreForm.Tag);
                    StudentScores_ListBox.Items[StudentScores_ListBox.SelectedIndex] = (int)updateScoreForm.Tag;
                }
            }
        }
        #endregion
    }
}
