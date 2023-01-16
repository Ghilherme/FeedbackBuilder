using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace FeedbackBuilder
{
    public partial class UpdateQuestionsForm : Form
    {
        public UpdateQuestionsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateJSON(txt_editquestions.Text))
            {
                string fileName = "questions.json";
                try
                {
                    File.WriteAllText(fileName, txt_editquestions.Text);
                    MessageBox.Show("Questions updated.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.mainForm.CleanForm();
                    this.Close();

                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message,"Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            
        }

        private void UpdateQuestions_Load(object sender, EventArgs e)
        {
            string fileName = "questions.json";
            string jsonString = File.ReadAllText(fileName);
            txt_editquestions.Text = jsonString;
        }

        public static bool ValidateJSON(string text)
        {
            try
            {
                JsonDocument.Parse(text);
                return true;
            }
            catch (FormatException formatException)
            {
                MessageBox.Show(formatException.Message, "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
