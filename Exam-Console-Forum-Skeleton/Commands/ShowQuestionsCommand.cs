using ConsoleForum.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Commands
{
    class ShowQuestionsCommand : AbstractCommand
    {
        public ShowQuestionsCommand(IForum forum)
            : base(forum)
        {

        }
        public override void Execute()
        {
            if(this.Forum.Questions.Count == 0)
            {
                this.Forum.Output.AppendLine(
                    string.Format(Messages.NoQuestions));
                return;
            }
            var questions = this.Forum.Questions
                .OrderBy(q => q.Id)
                .ToList();
            questions.ForEach(q => this.Forum.Output.AppendLine(q.ToString()));
        }
    }
}
