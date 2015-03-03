using ConsoleForum.Contracts;
using ConsoleForum.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Entities.Posts
{
    class Answer : Post, IAnswer
    {
        private bool isBestAnswer;

        public Answer(int id, string body, User author)
            : base(id, body, author)
        {
            this.isBestAnswer = false;
        }

        public void MakeBestAnswer()
        {
            this.isBestAnswer = true;
        }

        public bool getBestAnswer()
        {
            return this.isBestAnswer;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            if(this.isBestAnswer)
            {
                output.AppendLine(MarkBestAnswer());
            }
            output.Append(base.ToString());
            output.AppendLine(string.Format("Answer Body: {0}", this.Body))
                .AppendLine("--------------------");

            if (this.isBestAnswer)
            {
                output.AppendLine(MarkBestAnswer());
            }

            return (output.ToString());
        }

        private string MarkBestAnswer()
        {
            return "********************";
        }
    }
}
