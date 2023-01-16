using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackBuilder
{

    public class SubjectModel
    {
        public List<Subject> subjects { get; set; }
    }
    
    public class Subject
    {
        public string subject { get; set; }
        public List<Question> questions { get; set; }
    }

    public class Question
    {
        public string concept { get; set; }
        public string question { get; set; }
    }

}
