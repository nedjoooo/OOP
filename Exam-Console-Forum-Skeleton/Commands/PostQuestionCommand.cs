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
    class PostQuestionCommand : AbstractCommand
    {
        public PostQuestionCommand(IForum forum)
            : base(forum)
        {

        }
        public override void Execute()
        {
            if(this.Forum.CurrentUser == null)
            {
                this.Forum.Output.AppendLine(
                    string.Format(Messages.NotLogged));
                return;
            }
            string title = this.Data[1];
            List<string> submittedBody = new List<string>();
            for (int i = 2; i < this.Data.Count; i++)
            {
                submittedBody.Add(this.Data[i]);
            }
            string body = string.Join(" ", submittedBody);
            User user = this.Forum.CurrentUser as User;

            Question question = new Question(this.Forum.Questions.Count + 1, body, user, title, new List<IAnswer>());
            this.Forum.Questions.Add(question);
            this.Forum.Output.AppendLine(
                string.Format(Messages.PostQuestionSuccess, question.Id));
        }
    }
}
