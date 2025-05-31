using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examineon
{
    internal class Exam
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int NumberOfQuestions { get; set; }
        public List<string> Topics { get; set; }
        public string Difficulty { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string TopicsAsText => Topics != null ? string.Join(", ", Topics) : "Random";
    }
}

