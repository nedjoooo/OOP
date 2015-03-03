using ConsoleForum.Contracts;
using ConsoleForum.Entities.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Commands
{
    class OpenQuestionCommand : AbstractCommand
    {
        public OpenQuestionCommand(IForum forum)
            : base(forum)
        {

        }
        public override void Execute()
        {
            int id = int.Parse(this.Data[1]);
            var questions = this.Forum.Questions.ToList();
            bool isValidQuestion = false;
            foreach (var item in questions)
            {
                if(item.Id == id)
                {
                    isValidQuestion = true;
                    break;
                }
            }
            if(isValidQuestion == false)
            {
                this.Forum.Output.AppendLine(
                    string.Format(Messages.NoQuestion));
                return;
            }
            var question = questions.Single(q => q.Id == id) as Question;
            this.Forum.CurrentQuestion = question;
            this.Forum.Output.AppendLine(question.ToString());
        }
    }
}
