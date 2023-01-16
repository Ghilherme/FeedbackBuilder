using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbackBuilder
{
    public partial class FeedbackReadyForm : Form
    {
        private string v;

        public FeedbackReadyForm()
        {
            InitializeComponent();
        }

        public FeedbackReadyForm(string v)
        {
            this.v = v;
            InitializeComponent();
        }



        private void Feedback_Load(object sender, EventArgs e)
        {
            txt_feedback.Text = v;
        }
    }
}
