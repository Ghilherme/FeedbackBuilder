
namespace FeedbackBuilder
{
    partial class FeedbackBuilderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.updateQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateQuestionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanAndReloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(12, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1398, 579);
            this.tabControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(582, 631);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate Feedback";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateQuestionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1422, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // updateQuestionsToolStripMenuItem
            // 
            this.updateQuestionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateQuestionsToolStripMenuItem1,
            this.cleanAndReloadToolStripMenuItem});
            this.updateQuestionsToolStripMenuItem.Name = "updateQuestionsToolStripMenuItem";
            this.updateQuestionsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.updateQuestionsToolStripMenuItem.Text = "Features";
            // 
            // updateQuestionsToolStripMenuItem1
            // 
            this.updateQuestionsToolStripMenuItem1.Name = "updateQuestionsToolStripMenuItem1";
            this.updateQuestionsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.updateQuestionsToolStripMenuItem1.Text = "Update questions";
            this.updateQuestionsToolStripMenuItem1.Click += new System.EventHandler(this.updateQuestionsToolStripMenuItem1_Click);
            // 
            // cleanAndReloadToolStripMenuItem
            // 
            this.cleanAndReloadToolStripMenuItem.Name = "cleanAndReloadToolStripMenuItem";
            this.cleanAndReloadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cleanAndReloadToolStripMenuItem.Text = "Clean and reload";
            this.cleanAndReloadToolStripMenuItem.Click += new System.EventHandler(this.cleanAndReloadToolStripMenuItem_Click);
            // 
            // FeedbackBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 678);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FeedbackBuilderForm";
            this.Text = "Feedback Builder 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateQuestionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cleanAndReloadToolStripMenuItem;
    }
}

