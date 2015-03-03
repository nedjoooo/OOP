using ConsoleForum.Contracts;
using ConsoleForum.Entities.Posts;
using ConsoleForum.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Commands
{
    class PostAnswerCommand : AbstractCommand
    {
        public PostAnswerCommand(IForum forum)
            : base(forum)
        {

        }
        public override void Execute()
        {
            if(this.Forum.CurrentQuestion == null)
            {
                this.Forum.Output.AppendLine(
                    string.Format(Messages.NoQuestionOpened));
            }
            List<string> submittedBody = new List<string>();
            for (int i = 1; i < this.Data.Count; i++)
            {
                submittedBody.Add(this.Data[i]);
            }
            string body = string.Join(" ", submittedBody);
            User user = this.Forum.CurrentUser as User;

            IAnswer answer = new Answer(this.Forum.Answers.Count + 1, body, user);
            this.Forum.Answers.Add(answer);
            this.Forum.CurrentQuestion.Answers.Add(answer);

            this.Forum.Output.AppendLine(
                    string.Format(Messages.PostAnswerSuccess, answer.Id));
        }
    }
}
