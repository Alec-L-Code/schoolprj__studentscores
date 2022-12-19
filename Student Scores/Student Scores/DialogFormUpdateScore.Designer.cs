namespace Student_Scores
{
    partial class DialogFormUpdateScore
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
            this.CancelScore_Button = new System.Windows.Forms.Button();
            this.UpdateScore_Button = new System.Windows.Forms.Button();
            this.Score_TextBox = new System.Windows.Forms.TextBox();
            this.Score_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelScore_Button
            // 
            this.CancelScore_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelScore_Button.Location = new System.Drawing.Point(200, 103);
            this.CancelScore_Button.Name = "CancelScore_Button";
            this.CancelScore_Button.Size = new System.Drawing.Size(75, 23);
            this.CancelScore_Button.TabIndex = 7;
            this.CancelScore_Button.Text = "Cancel";
            this.CancelScore_Button.UseVisualStyleBackColor = true;
            // 
            // UpdateScore_Button
            // 
            this.UpdateScore_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UpdateScore_Button.Enabled = false;
            this.UpdateScore_Button.Location = new System.Drawing.Point(13, 103);
            this.UpdateScore_Button.Name = "UpdateScore_Button";
            this.UpdateScore_Button.Size = new System.Drawing.Size(75, 23);
            this.UpdateScore_Button.TabIndex = 6;
            this.UpdateScore_Button.Text = "Update";
            this.UpdateScore_Button.UseVisualStyleBackColor = true;
            // 
            // Score_TextBox
            // 
            this.Score_TextBox.Location = new System.Drawing.Point(115, 30);
            this.Score_TextBox.Name = "Score_TextBox";
            this.Score_TextBox.Size = new System.Drawing.Size(67, 20);
            this.Score_TextBox.TabIndex = 5;
            this.Score_TextBox.TextChanged += new System.EventHandler(this.Score_TextBox_Changed);
            // 
            // Score_Label
            // 
            this.Score_Label.AutoSize = true;
            this.Score_Label.Location = new System.Drawing.Point(53, 33);
            this.Score_Label.Name = "Score_Label";
            this.Score_Label.Size = new System.Drawing.Size(38, 13);
            this.Score_Label.TabIndex = 4;
            this.Score_Label.Text = "Score:";
            // 
            // DialogFormUpdateScore
            // 
            this.AcceptButton = this.UpdateScore_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 129);
            this.ControlBox = false;
            this.Controls.Add(this.CancelScore_Button);
            this.Controls.Add(this.UpdateScore_Button);
            this.Controls.Add(this.Score_TextBox);
            this.Controls.Add(this.Score_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogFormUpdateScore";
            this.Text = "Update Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelScore_Button;
        private System.Windows.Forms.Button UpdateScore_Button;
        private System.Windows.Forms.TextBox Score_TextBox;
        private System.Windows.Forms.Label Score_Label;
    }
}