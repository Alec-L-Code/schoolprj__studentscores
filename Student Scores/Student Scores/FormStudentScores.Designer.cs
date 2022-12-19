namespace Student_Scores
{
    partial class FormStudentScores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenFile_Button = new System.Windows.Forms.Button();
            this.SaveFile_Button = new System.Windows.Forms.Button();
            this.Students_ListBox = new System.Windows.Forms.ListBox();
            this.Students_Label = new System.Windows.Forms.Label();
            this.ScoreTotal_Label = new System.Windows.Forms.Label();
            this.ScoreCount_Label = new System.Windows.Forms.Label();
            this.Average_Label = new System.Windows.Forms.Label();
            this.ScoreTotal_TextBox = new System.Windows.Forms.TextBox();
            this.ScoreCount_TextBox = new System.Windows.Forms.TextBox();
            this.Average_TextBox = new System.Windows.Forms.TextBox();
            this.AddNewStudent_Button = new System.Windows.Forms.Button();
            this.UpdateStudent_Button = new System.Windows.Forms.Button();
            this.DeleteStudent_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenFile_Button
            // 
            this.OpenFile_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OpenFile_Button.Location = new System.Drawing.Point(12, 297);
            this.OpenFile_Button.Name = "OpenFile_Button";
            this.OpenFile_Button.Size = new System.Drawing.Size(116, 33);
            this.OpenFile_Button.TabIndex = 0;
            this.OpenFile_Button.Text = "Open";
            this.OpenFile_Button.UseVisualStyleBackColor = true;
            this.OpenFile_Button.Click += new System.EventHandler(this.OpenFile_Button_Click);
            // 
            // SaveFile_Button
            // 
            this.SaveFile_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SaveFile_Button.Location = new System.Drawing.Point(12, 354);
            this.SaveFile_Button.Name = "SaveFile_Button";
            this.SaveFile_Button.Size = new System.Drawing.Size(116, 34);
            this.SaveFile_Button.TabIndex = 1;
            this.SaveFile_Button.Text = "Save";
            this.SaveFile_Button.UseVisualStyleBackColor = true;
            this.SaveFile_Button.Click += new System.EventHandler(this.SaveFile_Button_Click);
            // 
            // Students_ListBox
            // 
            this.Students_ListBox.FormattingEnabled = true;
            this.Students_ListBox.Location = new System.Drawing.Point(12, 60);
            this.Students_ListBox.Name = "Students_ListBox";
            this.Students_ListBox.Size = new System.Drawing.Size(433, 212);
            this.Students_ListBox.TabIndex = 3;
            this.Students_ListBox.SelectedIndexChanged += new System.EventHandler(this.Students_ListBox_SelectedIndexChange);
            // 
            // Students_Label
            // 
            this.Students_Label.AutoSize = true;
            this.Students_Label.Location = new System.Drawing.Point(13, 13);
            this.Students_Label.Name = "Students_Label";
            this.Students_Label.Size = new System.Drawing.Size(52, 13);
            this.Students_Label.TabIndex = 2;
            this.Students_Label.Text = "Students:";
            // 
            // ScoreTotal_Label
            // 
            this.ScoreTotal_Label.AutoSize = true;
            this.ScoreTotal_Label.Location = new System.Drawing.Point(314, 297);
            this.ScoreTotal_Label.Name = "ScoreTotal_Label";
            this.ScoreTotal_Label.Size = new System.Drawing.Size(61, 13);
            this.ScoreTotal_Label.TabIndex = 4;
            this.ScoreTotal_Label.Text = "Score total:";
            // 
            // ScoreCount_Label
            // 
            this.ScoreCount_Label.AutoSize = true;
            this.ScoreCount_Label.Location = new System.Drawing.Point(314, 330);
            this.ScoreCount_Label.Name = "ScoreCount_Label";
            this.ScoreCount_Label.Size = new System.Drawing.Size(68, 13);
            this.ScoreCount_Label.TabIndex = 5;
            this.ScoreCount_Label.Text = "Score count:";
            // 
            // Average_Label
            // 
            this.Average_Label.AutoSize = true;
            this.Average_Label.Location = new System.Drawing.Point(314, 365);
            this.Average_Label.Name = "Average_Label";
            this.Average_Label.Size = new System.Drawing.Size(50, 13);
            this.Average_Label.TabIndex = 6;
            this.Average_Label.Text = "Average:";
            // 
            // ScoreTotal_TextBox
            // 
            this.ScoreTotal_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ScoreTotal_TextBox.Location = new System.Drawing.Point(395, 294);
            this.ScoreTotal_TextBox.Name = "ScoreTotal_TextBox";
            this.ScoreTotal_TextBox.ReadOnly = true;
            this.ScoreTotal_TextBox.Size = new System.Drawing.Size(50, 20);
            this.ScoreTotal_TextBox.TabIndex = 7;
            // 
            // ScoreCount_TextBox
            // 
            this.ScoreCount_TextBox.Location = new System.Drawing.Point(395, 327);
            this.ScoreCount_TextBox.Name = "ScoreCount_TextBox";
            this.ScoreCount_TextBox.ReadOnly = true;
            this.ScoreCount_TextBox.Size = new System.Drawing.Size(50, 20);
            this.ScoreCount_TextBox.TabIndex = 8;
            // 
            // Average_TextBox
            // 
            this.Average_TextBox.Location = new System.Drawing.Point(395, 362);
            this.Average_TextBox.Name = "Average_TextBox";
            this.Average_TextBox.ReadOnly = true;
            this.Average_TextBox.Size = new System.Drawing.Size(50, 20);
            this.Average_TextBox.TabIndex = 9;
            // 
            // AddNewStudent_Button
            // 
            this.AddNewStudent_Button.Location = new System.Drawing.Point(475, 71);
            this.AddNewStudent_Button.Name = "AddNewStudent_Button";
            this.AddNewStudent_Button.Size = new System.Drawing.Size(100, 42);
            this.AddNewStudent_Button.TabIndex = 10;
            this.AddNewStudent_Button.Text = "Add New...";
            this.AddNewStudent_Button.UseVisualStyleBackColor = true;
            this.AddNewStudent_Button.Click += new System.EventHandler(this.AddNewStudent_Button_Click);
            // 
            // UpdateStudent_Button
            // 
            this.UpdateStudent_Button.Location = new System.Drawing.Point(475, 141);
            this.UpdateStudent_Button.Name = "UpdateStudent_Button";
            this.UpdateStudent_Button.Size = new System.Drawing.Size(100, 42);
            this.UpdateStudent_Button.TabIndex = 11;
            this.UpdateStudent_Button.Text = "Update...";
            this.UpdateStudent_Button.UseVisualStyleBackColor = true;
            this.UpdateStudent_Button.Click += new System.EventHandler(this.UpdateStudent_Button_Click);
            // 
            // DeleteStudent_Button
            // 
            this.DeleteStudent_Button.Location = new System.Drawing.Point(475, 218);
            this.DeleteStudent_Button.Name = "DeleteStudent_Button";
            this.DeleteStudent_Button.Size = new System.Drawing.Size(100, 42);
            this.DeleteStudent_Button.TabIndex = 12;
            this.DeleteStudent_Button.Text = "Delete";
            this.DeleteStudent_Button.UseVisualStyleBackColor = true;
            this.DeleteStudent_Button.Click += new System.EventHandler(this.DeleteStudent_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(500, 362);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 21);
            this.Exit_Button.TabIndex = 13;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // FormStudentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 400);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.DeleteStudent_Button);
            this.Controls.Add(this.UpdateStudent_Button);
            this.Controls.Add(this.AddNewStudent_Button);
            this.Controls.Add(this.Average_TextBox);
            this.Controls.Add(this.ScoreCount_TextBox);
            this.Controls.Add(this.ScoreTotal_TextBox);
            this.Controls.Add(this.Average_Label);
            this.Controls.Add(this.ScoreCount_Label);
            this.Controls.Add(this.ScoreTotal_Label);
            this.Controls.Add(this.Students_Label);
            this.Controls.Add(this.Students_ListBox);
            this.Controls.Add(this.SaveFile_Button);
            this.Controls.Add(this.OpenFile_Button);
            this.Name = "FormStudentScores";
            this.Text = "Student Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFile_Button;
        private System.Windows.Forms.Button SaveFile_Button;
        private System.Windows.Forms.ListBox Students_ListBox;
        private System.Windows.Forms.Label Students_Label;
        private System.Windows.Forms.Label ScoreTotal_Label;
        private System.Windows.Forms.Label ScoreCount_Label;
        private System.Windows.Forms.Label Average_Label;
        private System.Windows.Forms.TextBox ScoreTotal_TextBox;
        private System.Windows.Forms.TextBox ScoreCount_TextBox;
        private System.Windows.Forms.TextBox Average_TextBox;
        private System.Windows.Forms.Button AddNewStudent_Button;
        private System.Windows.Forms.Button UpdateStudent_Button;
        private System.Windows.Forms.Button DeleteStudent_Button;
        private System.Windows.Forms.Button Exit_Button;
    }
}

