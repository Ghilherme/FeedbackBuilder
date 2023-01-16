using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackBuilder
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ScoresModel
    {
        public List<Score> scores { get; set; }
    }

    public class Score
    {
        public string score { get; set; }
        public string classifier { get; set; }
        public string feedback { get; set; }
    }


}
