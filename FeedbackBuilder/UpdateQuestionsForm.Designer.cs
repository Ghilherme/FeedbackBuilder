
namespace FeedbackBuilder
{
    partial class UpdateQuestionsForm
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
            this.txt_editquestions = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_editquestions
            // 
            this.txt_editquestions.Location = new System.Drawing.Point(13, 31);
            this.txt_editquestions.Multiline = true;
            this.txt_editquestions.Name = "txt_editquestions";
            this.txt_editquestions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_editquestions.Size = new System.Drawing.Size(1229, 578);
            this.txt_editquestions.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 615);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update Questions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 664);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_editquestions);
            this.Name = "UpdateQuestions";
            this.Text = "UpdateQuestions";
            this.Load += new System.EventHandler(this.UpdateQuestions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_editquestions;
        private System.Windows.Forms.Button button1;
    }
}