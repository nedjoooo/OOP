using ConsoleForum.Contracts;
using ConsoleForum.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Entities.Posts
{
    class Question : Post, IQuestion
    {
        private string title;
        private IList<IAnswer> answers;

        public Question(int id, string body, User author, string title, List<IAnswer> answers)
            : base(id, body, author)
        {
            this.Title = title;
            this.Answers = answers;
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }

        public IList<IAnswer> Answers
        {
            get { return this.answers; }
            set
            {
                this.answers = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(base.ToString());
            output.AppendLine(string.Format("Question Title: {0}", this.Title))
                .AppendLine(string.Format("Question Body: {0}", this.Body))
                .AppendLine("====================");

            if(this.Answers.Count == 0)
            {
                output.Append("No answers");
                return output.ToString();
            }

            output.AppendLine("Answers:");
            var answers = this.Answers.Select(a => a as Answer).ToList();
            var bestAnswer = answers.Where(a => a.getBestAnswer() == true).ToList();
            if(bestAnswer != null)
            {
                bestAnswer.ForEach(a => output.Append(a.ToString()));
            }
            var notBestAnswers = answers.Where(a => a.getBestAnswer() == false)
                .ToList();
            notBestAnswers.ForEach(a => output.Append(a.ToString()));

            return output.ToString().Trim();
        }
    }
}
