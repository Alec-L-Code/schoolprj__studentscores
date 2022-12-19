namespace Student_Scores
{
    partial class DialogFormAddScore
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
            this.Score_Label = new System.Windows.Forms.Label();
            this.Score_TextBox = new System.Windows.Forms.TextBox();
            this.AddScore_Button = new System.Windows.Forms.Button();
            this.CancelScore_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Score_Label
            // 
            this.Score_Label.AutoSize = true;
            this.Score_Label.Location = new System.Drawing.Point(52, 30);
            this.Score_Label.Name = "Score_Label";
            this.Score_Label.Size = new System.Drawing.Size(38, 13);
            this.Score_Label.TabIndex = 0;
            this.Score_Label.Text = "Score:";
            // 
            // Score_TextBox
            // 
            this.Score_TextBox.Location = new System.Drawing.Point(114, 27);
            this.Score_TextBox.Name = "Score_TextBox";
            this.Score_TextBox.Size = new System.Drawing.Size(67, 20);
            this.Score_TextBox.TabIndex = 1;
            this.Score_TextBox.TextChanged += new System.EventHandler(this.Score_TextBox_Changed);
            // 
            // AddScore_Button
            // 
            this.AddScore_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddScore_Button.Enabled = false;
            this.AddScore_Button.Location = new System.Drawing.Point(12, 100);
            this.AddScore_Button.Name = "AddScore_Button";
            this.AddScore_Button.Size = new System.Drawing.Size(75, 23);
            this.AddScore_Button.TabIndex = 2;
            this.AddScore_Button.Text = "Add";
            this.AddScore_Button.UseVisualStyleBackColor = true;
            // 
            // CancelScore_Button
            // 
            this.CancelScore_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelScore_Button.Location = new System.Drawing.Point(199, 100);
            this.CancelScore_Button.Name = "CancelScore_Button";
            this.CancelScore_Button.Size = new System.Drawing.Size(75, 23);
            this.CancelScore_Button.TabIndex = 3;
            this.CancelScore_Button.Text = "Cancel";
            this.CancelScore_Button.UseVisualStyleBackColor = true;
            // 
            // DialogFormAddScore
            // 
            this.AcceptButton = this.AddScore_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 135);
            this.ControlBox = false;
            this.Controls.Add(this.CancelScore_Button);
            this.Controls.Add(this.AddScore_Button);
            this.Controls.Add(this.Score_TextBox);
            this.Controls.Add(this.Score_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogFormAddScore";
            this.Text = "Add Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Score_Label;
        private System.Windows.Forms.TextBox Score_TextBox;
        private System.Windows.Forms.Button AddScore_Button;
        private System.Windows.Forms.Button CancelScore_Button;
    }
}