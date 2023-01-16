
namespace FeedbackBuilder
{
    partial class FeedbackReadyForm
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
            this.txt_feedback = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_feedback
            // 
            this.txt_feedback.Location = new System.Drawing.Point(21, 26);
            this.txt_feedback.Multiline = true;
            this.txt_feedback.Name = "txt_feedback";
            this.txt_feedback.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_feedback.Size = new System.Drawing.Size(1229, 517);
            this.txt_feedback.TabIndex = 0;
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 651);
            this.Controls.Add(this.txt_feedback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Feedback";
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.Feedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_feedback;
    }
}