namespace Student_Scores
{
    partial class DialogFormUpdateStudentScores
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
            this.StudentName_Label = new System.Windows.Forms.Label();
            this.StudentScores_Label = new System.Windows.Forms.Label();
            this.StudentScores_ListBox = new System.Windows.Forms.ListBox();
            this.AddScore_Button = new System.Windows.Forms.Button();
            this.StudentName_TextBox = new System.Windows.Forms.TextBox();
            this.UpdateScore_Button = new System.Windows.Forms.Button();
            this.RemoveScore_Button = new System.Windows.Forms.Button();
            this.ClearScores_Button = new System.Windows.Forms.Button();
            this.FormSubmitOK_Button = new System.Windows.Forms.Button();
            this.FormSubmitCancel_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentName_Label
            // 
            this.StudentName_Label.AutoSize = true;
            this.StudentName_Label.Location = new System.Drawing.Point(12, 9);
            this.StudentName_Label.Name = "StudentName_Label";
            this.StudentName_Label.Size = new System.Drawing.Size(38, 13);
            this.StudentName_Label.TabIndex = 0;
            this.StudentName_Label.Text = "Name:";
            // 
            // StudentScores_Label
            // 
            this.StudentScores_Label.AutoSize = true;
            this.StudentScores_Label.Location = new System.Drawing.Point(12, 48);
            this.StudentScores_Label.Name = "StudentScores_Label";
            this.StudentScores_Label.Size = new System.Drawing.Size(43, 13);
            this.StudentScores_Label.TabIndex = 1;
            this.StudentScores_Label.Text = "Scores:";
            // 
            // StudentScores_ListBox
            // 
            this.StudentScores_ListBox.FormattingEnabled = true;
            this.StudentScores_ListBox.Location = new System.Drawing.Point(61, 48);
            this.StudentScores_ListBox.Name = "StudentScores_ListBox";
            this.StudentScores_ListBox.Size = new System.Drawing.Size(106, 147);
            this.StudentScores_ListBox.TabIndex = 2;
            // 
            // AddScore_Button
            // 
            this.AddScore_Button.Location = new System.Drawing.Point(190, 48);
            this.AddScore_Button.Name = "AddScore_Button";
            this.AddScore_Button.Size = new System.Drawing.Size(75, 23);
            this.AddScore_Button.TabIndex = 3;
            this.AddScore_Button.Text = "Add";
            this.AddScore_Button.UseVisualStyleBackColor = true;
            this.AddScore_Button.Click += new System.EventHandler(this.AddScore_Button_Click);
            // 
            // StudentName_TextBox
            // 
            this.StudentName_TextBox.Location = new System.Drawing.Point(61, 6);
            this.StudentName_TextBox.Name = "StudentName_TextBox";
            this.StudentName_TextBox.ReadOnly = true;
            this.StudentName_TextBox.Size = new System.Drawing.Size(204, 20);
            this.StudentName_TextBox.TabIndex = 4;
            // 
            // UpdateScore_Button
            // 
            this.UpdateScore_Button.Location = new System.Drawing.Point(190, 89);
            this.UpdateScore_Button.Name = "UpdateScore_Button";
            this.UpdateScore_Button.Size = new System.Drawing.Size(75, 23);
            this.UpdateScore_Button.TabIndex = 5;
            this.UpdateScore_Button.Text = "Update";
            this.UpdateScore_Button.UseVisualStyleBackColor = true;
            this.UpdateScore_Button.Click += new System.EventHandler(this.UpdateScore_Button_Click);
            // 
            // RemoveScore_Button
            // 
            this.RemoveScore_Button.Location = new System.Drawing.Point(190, 129);
            this.RemoveScore_Button.Name = "RemoveScore_Button";
            this.RemoveScore_Button.Size = new System.Drawing.Size(75, 23);
            this.RemoveScore_Button.TabIndex = 6;
            this.RemoveScore_Button.Text = "Remove";
            this.RemoveScore_Button.UseVisualStyleBackColor = true;
            this.RemoveScore_Button.Click += new System.EventHandler(this.RemoveScore_Button_Click);
            // 
            // ClearScores_Button
            // 
            this.ClearScores_Button.Location = new System.Drawing.Point(190, 172);
            this.ClearScores_Button.Name = "ClearScores_Button";
            this.ClearScores_Button.Size = new System.Drawing.Size(75, 23);
            this.ClearScores_Button.TabIndex = 7;
            this.ClearScores_Button.Text = "Clear Scores";
            this.ClearScores_Button.UseVisualStyleBackColor = true;
            this.ClearScores_Button.Click += new System.EventHandler(this.ClearScores_Button_Click);
            // 
            // FormSubmitOK_Button
            // 
            this.FormSubmitOK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.FormSubmitOK_Button.Location = new System.Drawing.Point(92, 216);
            this.FormSubmitOK_Button.Name = "FormSubmitOK_Button";
            this.FormSubmitOK_Button.Size = new System.Drawing.Size(75, 23);
            this.FormSubmitOK_Button.TabIndex = 8;
            this.FormSubmitOK_Button.Text = "OK";
            this.FormSubmitOK_Button.UseVisualStyleBackColor = true;
            // 
            // FormSubmitCancel_Button
            // 
            this.FormSubmitCancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FormSubmitCancel_Button.Location = new System.Drawing.Point(190, 216);
            this.FormSubmitCancel_Button.Name = "FormSubmitCancel_Button";
            this.FormSubmitCancel_Button.Size = new System.Drawing.Size(75, 23);
            this.FormSubmitCancel_Button.TabIndex = 9;
            this.FormSubmitCancel_Button.Text = "Cancel";
            this.FormSubmitCancel_Button.UseVisualStyleBackColor = true;
            // 
            // DialogFormUpdateStudentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 240);
            this.ControlBox = false;
            this.Controls.Add(this.FormSubmitCancel_Button);
            this.Controls.Add(this.FormSubmitOK_Button);
            this.Controls.Add(this.ClearScores_Button);
            this.Controls.Add(this.RemoveScore_Button);
            this.Controls.Add(this.UpdateScore_Button);
            this.Controls.Add(this.StudentName_TextBox);
            this.Controls.Add(this.AddScore_Button);
            this.Controls.Add(this.StudentScores_ListBox);
            this.Controls.Add(this.StudentScores_Label);
            this.Controls.Add(this.StudentName_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogFormUpdateStudentScores";
            this.Text = "Update Student Scores";
            this.Load += new System.EventHandler(this.LoadStudentInfoOnFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentName_Label;
        private System.Windows.Forms.Label StudentScores_Label;
        private System.Windows.Forms.ListBox StudentScores_ListBox;
        private System.Windows.Forms.Button AddScore_Button;
        private System.Windows.Forms.TextBox StudentName_TextBox;
        private System.Windows.Forms.Button UpdateScore_Button;
        private System.Windows.Forms.Button RemoveScore_Button;
        private System.Windows.Forms.Button ClearScores_Button;
        private System.Windows.Forms.Button FormSubmitOK_Button;
        private System.Windows.Forms.Button FormSubmitCancel_Button;
    }
}