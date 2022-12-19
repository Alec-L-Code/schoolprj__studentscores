using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Scores
{
    /**
     * Wanted to start off by saying that I've looked at my past projects and realized that I wasn't consistent in my naming 
     * conventions for some reason. I end up changing it each time. so I wanted to start being a little more consistent 
     * when it comes to naming conventions. For example I should
     * stick to Output_Label and Output_Label_Click for an event, and finally start my forms with form i.e. formStudentScores.
     * I just thought I would let you know that I'll try my hardest to stick to these conventions. Thanks.
     */


    public partial class FormStudentScores : Form
    {
        private OpenFileDialog ofd = new OpenFileDialog(); // Dialog for Opening Save FIles
        private FolderBrowserDialog fbd = new FolderBrowserDialog(); // Dialog for Saving Files (Saves to Students.txt)

        public FormStudentScores()
        {
            InitializeComponent();
        }




        // Updates each textbox with the student's score information when a student is clicked from the listbox.
        private void Students_ListBox_SelectedIndexChange(object sender, EventArgs e)
        {
            if (Students_ListBox.SelectedIndex >= 0)
            {
                Student selectedStudent = Students_ListBox.Items[Students_ListBox.SelectedIndex] as Student; // Gets the selected student from the listbox
                ScoreTotal_TextBox.Text = selectedStudent.GetScoreTotal().ToString();
                ScoreCount_TextBox.Text = selectedStudent.GetScoreCount().ToString();
                Average_TextBox.Text = selectedStudent.GetScoreAvg().ToString();
            }
            else
            {
                ScoreTotal_TextBox.Text = string.Empty;
                ScoreCount_TextBox.Text = string.Empty;
                Average_TextBox.Text = string.Empty;
            }
        }






        // Standard Button Click Events of the Main Form (StudentScores).
        #region ButtonClickEvents
        // Exits the application upon a final 
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?\nYou may or may not have unsaved data.",
                "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Deletes a student from the form and students list.
        private void DeleteStudent_Button_Click(object sender, EventArgs e)
        {
            if (Students_ListBox.SelectedIndex >= 0)
            {
                try
                {
                    Students_ListBox.Items.RemoveAt(Students_ListBox.SelectedIndex);
                }
                catch (ArgumentOutOfRangeException) { } // In theory this should never ever happen.
            }
        }
        #endregion
        // Buttons that include the handling and generating of dialog forms and their data.
        #region DialogFormButtonClicks

        // Adds a new student with its data to the listbox and into the students list.
        private void AddNewStudent_Button_Click(object sender, EventArgs e)
        {
            DialogFormAddStudent addStudentForm = new DialogFormAddStudent();
            if(addStudentForm.ShowDialog() == DialogResult.OK)
            {
                // Adds the student to the list of students and the listbox in the UI
                Students_ListBox.Items.Add(addStudentForm.Tag as Student);
            }
        }

        // Opens a dialog form that allows the user to update a student's scores accordingly.
        private void UpdateStudent_Button_Click(object sender, EventArgs e)
        {
            if(Students_ListBox.SelectedIndex >= 0)
            {
                // Creates a dialog form for updating an individual student's scores
                DialogFormUpdateStudentScores updateScoresForm = new DialogFormUpdateStudentScores(
                Students_ListBox.Items[Students_ListBox.SelectedIndex] as Student);

                if(updateScoresForm.ShowDialog() == DialogResult.OK)
                {
                    // Updates the student in the Students_ListBox appropriately
                    Students_ListBox.Items[Students_ListBox.SelectedIndex] = updateScoresForm.Tag as Student;
                }
            }
        }
        #endregion
        // Takes care of Inputting and Outputting Files (I thought this application was kind of pointless without this)
        #region FileIOHandling



        // Handles the opening of a previously saved text file of students.
        private void OpenFile_Button_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                if(!OpenStudentsFile(ofd.FileName))
                {
                    MessageBox.Show("There was an error opening the student score data.",
                        "Open File Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        // Returns true if a students text file was sucessfully opened and parsed
        // This will crash if not used on a text file. Please use properly formatted text files only!!!
        private bool OpenStudentsFile(string @path)
        {
            try
            {
                //students = new List<Student>();
                Students_ListBox.Items.Clear(); // Resets and clears all previous data.
                List<string> fileData = File.ReadAllLines(path).ToList(); // All the data in the file.
                foreach (string line in fileData)
                {
                    string[] student = line.Split(','); // Format:(Line 1)StudentA, 12, 13, 14, 15, 16 (Line 2)StudentB, 12, 13, 13
                    // Each line represents as student and their scores delimitted by commas.
                    Student newStudent = new Student(student[0]); // Creates a new student with element 0 of the string[] student which should be his or her name.
                    foreach (string segment in student)
                    {
                        if (int.TryParse(segment, out int parsedScore)) { newStudent.AddScore(parsedScore); }
                        else { continue; } // If the parse works, add it to the new student score, if not continue to next segment.
                    }
                    Students_ListBox.Items.Add(newStudent); // Add the new parsed student to the students list.
                }
                //Testing Code to see if formatted properly.
                //foreach (Student student in students)
                //{
                //    Console.WriteLine("{0} {1}", student.Name, string.Join(",", student.GetAllScores()));
                //}
                return true;
            } catch(Exception)
            {
                return false;
            }
        }


        // Handles the saving of a new text file of students. All saves will be named "Students.txt"
        private void SaveFile_Button_Click(object sender, EventArgs e)
        {
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                if(!SaveStudentsFile(@fbd.SelectedPath))
                {
                    MessageBox.Show("There was an error saving the student score data.",
                        "Save File Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        // Returns true if a students text file was sucessfully saved.
        private bool SaveStudentsFile(string @path)
        {
            try
            {
                List<string> outputLines = new List<string>();
                foreach(Student student in Students_ListBox.Items)
                {
                    outputLines.Add($"{student.Name},{string.Join(",", student.GetAllScores())}");
                }
                File.WriteAllLines(path + @"\Students.txt", outputLines, Encoding.UTF8);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        
        #endregion
    }
}