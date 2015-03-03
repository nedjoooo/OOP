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
    class MakeBestAnswerCommand : AbstractCommand
    {
        public MakeBestAnswerCommand(IForum forum)
            : base(forum)
        {

        }
        public override void Execute()
        {
            if (this.Forum.CurrentUser == null)
            {
                this.Forum.Output.AppendLine(Messages.NotLogged);
                return;
            }

            if(this.Forum.CurrentQuestion == null)
            {
                this.Forum.Output.AppendLine(Messages.NoQuestionOpened);
                return;
            }

            int answerId = int.Parse(this.Data[1]);
            var currentAnswers = this.Forum.CurrentQuestion.Answers.ToList();
            var answerById = currentAnswers.Single(a => a.Id == answerId);

            if(answerById == null)
            {
                this.Forum.Output.AppendLine(Messages.NoAnswer);
                return;
            }

            User user = this.Forum.CurrentUser as User;
            if(user.Id != this.Forum.CurrentQuestion.Author.Id || user.Id == 1)
            {
                this.Forum.Output.AppendLine(Messages.NoPermission);
                return;
            }

            var isValidBestAnswer = this.Forum.CurrentQuestion.Answers
                .Select(a => a as Answer)
                .Where(a => a.getBestAnswer() == true)
                .ToList();
            if(isValidBestAnswer.Count > 0)
            {
                this.Forum.Output.AppendLine(string.Format(Messages.InvalidCommand));
                return;
            }

            for (int i = 0; i < this.Forum.CurrentQuestion.Answers.Count; i++)
            {
                if(this.Forum.CurrentQuestion.Answers[i].Id == answerId)
                {
                    Answer answer = this.Forum.CurrentQuestion.Answers[i] as Answer;
                    answer.MakeBestAnswer();
                    this.Forum.Output.AppendLine(string.Format(Messages.BestAnswerSuccess, answer.Id));
                }
            }
            
        }
    }
}
