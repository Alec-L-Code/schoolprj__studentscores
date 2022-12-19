namespace Student_Scores
{
    partial class DialogFormAddStudent
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
            this.AddScore_Label = new System.Windows.Forms.Label();
            this.ScoresList_Label = new System.Windows.Forms.Label();
            this.StudentName_TextBox = new System.Windows.Forms.TextBox();
            this.AddScore_TextBox = new System.Windows.Forms.TextBox();
            this.ScoresList_TextBox = new System.Windows.Forms.TextBox();
            this.AddScore_Button = new System.Windows.Forms.Button();
            this.ClearScores_Button = new System.Windows.Forms.Button();
            this.FormSubmitOK_Button = new System.Windows.Forms.Button();
            this.FormSubmitCancel_Buttom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentName_Label
            // 
            this.StudentName_Label.AutoSize = true;
            this.StudentName_Label.Location = new System.Drawing.Point(37, 24);
            this.StudentName_Label.Name = "StudentName_Label";
            this.StudentName_Label.Size = new System.Drawing.Size(38, 13);
            this.StudentName_Label.TabIndex = 0;
            this.StudentName_Label.Text = "Name:";
            // 
            // AddScore_Label
            // 
            this.AddScore_Label.AutoSize = true;
            this.AddScore_Label.Location = new System.Drawing.Point(37, 60);
            this.AddScore_Label.Name = "AddScore_Label";
            this.AddScore_Label.Size = new System.Drawing.Size(38, 13);
            this.AddScore_Label.TabIndex = 1;
            this.AddScore_Label.Text = "Score:";
            // 
            // ScoresList_Label
            // 
            this.ScoresList_Label.AutoSize = true;
            this.ScoresList_Label.Location = new System.Drawing.Point(37, 101);
            this.ScoresList_Label.Name = "ScoresList_Label";
            this.ScoresList_Label.Size = new System.Drawing.Size(43, 13);
            this.ScoresList_Label.TabIndex = 2;
            this.ScoresList_Label.Text = "Scores:";
            // 
            // StudentName_TextBox
            // 
            this.StudentName_TextBox.Location = new System.Drawing.Point(88, 21);
            this.StudentName_TextBox.Name = "StudentName_TextBox";
            this.StudentName_TextBox.Size = new System.Drawing.Size(251, 20);
            this.StudentName_TextBox.TabIndex = 3;
            this.StudentName_TextBox.TextChanged += new System.EventHandler(this.StudentName_TextBox_TextChanged);
            // 
            // AddScore_TextBox
            // 
            this.AddScore_TextBox.Location = new System.Drawing.Point(88, 57);
            this.AddScore_TextBox.Name = "AddScore_TextBox";
            this.AddScore_TextBox.Size = new System.Drawing.Size(106, 20);
            this.AddScore_TextBox.TabIndex = 4;
            // 
            // ScoresList_TextBox
            // 
            this.ScoresList_TextBox.Enabled = false;
            this.ScoresList_TextBox.Location = new System.Drawing.Point(88, 98);
            this.ScoresList_TextBox.Name = "ScoresList_TextBox";
            this.ScoresList_TextBox.Size = new System.Drawing.Size(251, 20);
            this.ScoresList_TextBox.TabIndex = 5;
            // 
            // AddScore_Button
            // 
            this.AddScore_Button.Location = new System.Drawing.Point(212, 57);
            this.AddScore_Button.Name = "AddScore_Button";
            this.AddScore_Button.Size = new System.Drawing.Size(83, 20);
            this.AddScore_Button.TabIndex = 6;
            this.AddScore_Button.Text = "Add Score";
            this.AddScore_Button.UseVisualStyleBackColor = true;
            this.AddScore_Button.Click += new System.EventHandler(this.AddScore_Button_Click);
            // 
            // ClearScores_Button
            // 
            this.ClearScores_Button.Location = new System.Drawing.Point(256, 137);
            this.ClearScores_Button.Name = "ClearScores_Button";
            this.ClearScores_Button.Size = new System.Drawing.Size(83, 20);
            this.ClearScores_Button.TabIndex = 7;
            this.ClearScores_Button.Text = "Clear Scores";
            this.ClearScores_Button.UseVisualStyleBackColor = true;
            this.ClearScores_Button.Click += new System.EventHandler(this.ClearScores_Button_Click);
            // 
            // FormSubmitOK_Button
            // 
            this.FormSubmitOK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.FormSubmitOK_Button.Enabled = false;
            this.FormSubmitOK_Button.Location = new System.Drawing.Point(159, 181);
            this.FormSubmitOK_Button.Name = "FormSubmitOK_Button";
            this.FormSubmitOK_Button.Size = new System.Drawing.Size(83, 20);
            this.FormSubmitOK_Button.TabIndex = 8;
            this.FormSubmitOK_Button.Text = "OK";
            this.FormSubmitOK_Button.UseVisualStyleBackColor = true;
            // 
            // FormSubmitCancel_Buttom
            // 
            this.FormSubmitCancel_Buttom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FormSubmitCancel_Buttom.Location = new System.Drawing.Point(256, 181);
            this.FormSubmitCancel_Buttom.Name = "FormSubmitCancel_Buttom";
            this.FormSubmitCancel_Buttom.Size = new System.Drawing.Size(83, 20);
            this.FormSubmitCancel_Buttom.TabIndex = 9;
            this.FormSubmitCancel_Buttom.Text = "Cancel";
            this.FormSubmitCancel_Buttom.UseVisualStyleBackColor = true;
            // 
            // DialogFormAddStudent
            // 
            this.AcceptButton = this.AddScore_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 213);
            this.ControlBox = false;
            this.Controls.Add(this.FormSubmitCancel_Buttom);
            this.Controls.Add(this.FormSubmitOK_Button);
            this.Controls.Add(this.ClearScores_Button);
            this.Controls.Add(this.AddScore_Button);
            this.Controls.Add(this.ScoresList_TextBox);
            this.Controls.Add(this.AddScore_TextBox);
            this.Controls.Add(this.StudentName_TextBox);
            this.Controls.Add(this.ScoresList_Label);
            this.Controls.Add(this.AddScore_Label);
            this.Controls.Add(this.StudentName_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogFormAddStudent";
            this.Text = "Add New Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentName_Label;
        private System.Windows.Forms.Label AddScore_Label;
        private System.Windows.Forms.Label ScoresList_Label;
        private System.Windows.Forms.TextBox StudentName_TextBox;
        private System.Windows.Forms.TextBox AddScore_TextBox;
        private System.Windows.Forms.TextBox ScoresList_TextBox;
        private System.Windows.Forms.Button AddScore_Button;
        private System.Windows.Forms.Button ClearScores_Button;
        private System.Windows.Forms.Button FormSubmitOK_Button;
        private System.Windows.Forms.Button FormSubmitCancel_Buttom;
    }
}