using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbackBuilder
{
    public partial class FeedbackBuilderForm : Form
    {
        
        public FeedbackBuilderForm()
        {
            InitializeComponent();
        }

        private static int questionsSize = 700;
        private static SubjectModel subjects;
        private static ScoresModel scores;


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            subjects = LoadQuestionsData();
            scores = LoadScoresData();

            foreach (Subject subject in subjects.subjects)
            {
                TabPage tabPage = new TabPage(subject.subject);
                tabPage.AutoScroll = true;

                BuildClassifierLabels(scores, tabPage);

                int yPosQuestions = 20;
                int yPosGroupBoxes = 0;
                foreach (Question question in subject.questions)
                {
                    yPosQuestions += 50;
                    BuildQuestions(tabPage, yPosQuestions, question);

                    yPosGroupBoxes += 50;
                    BuildScores(scores, tabPage, yPosGroupBoxes, question);

                }
                tabControl1.TabPages.Add(tabPage);

            }
        }

        private static void BuildScores(ScoresModel scores, TabPage tp, int yPosGroupBoxes, Question question)
        {
            //Build radio buttons to score each question
            GroupBox groupBox = new GroupBox();
            groupBox.Size = new Size(600, 50);
            groupBox.Location = new Point(questionsSize + 50, yPosGroupBoxes);
            groupBox.Name = "GroupBox" + question.concept.Trim();

            int xPosRadioButton = 80;
            foreach (Score score in scores.scores)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Name = "radioButton" + question.concept.Trim();
                radioButton.Text = score.score;
                radioButton.Location = new Point(xPosRadioButton, 10);
                int size = 100;
                xPosRadioButton += size + 25;
                radioButton.Size = new Size(size, 30);

                groupBox.Controls.Add(radioButton);
            }

            tp.Controls.Add(groupBox);
        }

        private static void BuildQuestions(TabPage tp, int yPos, Question question)
        {
            //Build questions
            TextBox txt = new TextBox();
            txt.ReadOnly = true;
            txt.BorderStyle = 0;
            txt.Multiline = true;
            txt.TabStop = false;
            txt.Font = new Font("", 11, FontStyle.Regular);
            txt.Name = "label" + question.concept.Trim();
            txt.Text = question.question;
            txt.Size = new Size(questionsSize, 30);
            txt.Location = new Point(10, yPos);
            tp.Controls.Add(txt);
        }

        private static void BuildClassifierLabels(ScoresModel scores, TabPage tp)
        {
            int xPos = questionsSize + 100;
            //Build classifier labels
            foreach (Score score in scores.scores)
            {
                Label label = new Label();
                label.Font = new Font(DefaultFont, FontStyle.Bold);
                label.Name = "label" + score.classifier.Trim();
                label.Text = score.score + " - " + score.classifier;
                label.Location = new Point(xPos, 0);
                int size = 100;
                label.Size = new Size(size, 30);
                xPos += size + 20;
                tp.Controls.Add(label);
            }
        }

        private static SubjectModel LoadQuestionsData()
        {
            string fileName = "questions.json";
            string jsonString = File.ReadAllText(fileName);
            SubjectModel subjects = JsonSerializer.Deserialize<SubjectModel>(jsonString);
            return subjects;
        }

        private static ScoresModel LoadScoresData()
        {
            string fileName = "scores.json";
            string jsonString = File.ReadAllText(fileName);
            ScoresModel scores = JsonSerializer.Deserialize<ScoresModel>(jsonString);
            return scores;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, Dictionary<string, List<string>>> feedbackPerSubject = new Dictionary<string, Dictionary<string, List<string>>>();

            foreach (Subject subject in subjects.subjects)
            {
                Dictionary<string, List<string>> scoreRelations = BuildScoreRelations();
                foreach (Question question in subject.questions)
                {
                    GroupBox groupBox = this.Controls.Find("GroupBox" + question.concept.Trim(), true).FirstOrDefault() as GroupBox;
                    RadioButton radioButtonSelected = groupBox.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

                    if (radioButtonSelected != null)
                    {
                        string feedbackText = scores.scores.Where(x => x.score == radioButtonSelected.Text).FirstOrDefault().feedback;
                        scoreRelations[feedbackText].Add(question.concept);
                    }
                }
                feedbackPerSubject.Add(subject.subject, scoreRelations);
            }

            string feedbackfinal = BuildFeedbackString(feedbackPerSubject);
            ShowFeedbackForm(feedbackfinal);
        }

        private static void ShowFeedbackForm(string feedbackfinal)
        {
            FeedbackReadyForm feedbackForm = new FeedbackReadyForm(feedbackfinal);
            feedbackForm.Show();
        }

        private static Dictionary<string, List<string>> BuildScoreRelations()
        {
            Dictionary<string, List<string>> scoreRelations = new Dictionary<string, List<string>>();
            foreach (Score score in scores.scores)
            {
                scoreRelations.Add(score.feedback, new List<string>());
            }
            return scoreRelations;
        }

        private string BuildFeedbackString(Dictionary<string, Dictionary<string, List<string>>> feedbackPerConcept)
        {
            StringBuilder str = new StringBuilder();
            foreach(var (concept, dicScoreRelations) in feedbackPerConcept)
            {
                str.Append(concept);
                str.AppendLine();

                foreach (var (feedback, listConcept) in dicScoreRelations)
                {
                    if(listConcept.Count != 0)
                    {
                        str.Append(feedback);
                        str.Append(" ");
                        str.AppendJoin(", ", listConcept);
                        str.AppendLine();
                    }
                }       
                str.AppendLine();
                str.AppendLine();
            }

            return str.ToString();
        }

        private void updateQuestionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateQuestionsForm updateQuestionsForm = new UpdateQuestionsForm();
            updateQuestionsForm.Show();
        }

        private void cleanAndReloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        public void CleanForm()
        {
            this.Controls["tabControl1"].Controls.Clear();
            LoadForm();
        }
    }
}
