using ConsoleForum.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Commands
{
    class LogoutCommand : AbstractCommand
    {
        public LogoutCommand(IForum forum)
            : base(forum)
        {

        }
        public override void Execute()
        {
            if(this.Forum.CurrentUser != null)
            {
                this.Forum.CurrentUser = null;
                this.Forum.CurrentQuestion = null;
                this.Forum.Output.AppendLine(
                    string.Format(Messages.LogoutSuccess));
                return;
            }
            this.Forum.Output.AppendLine(
                    string.Format(Messages.NotLogged));
        }
    }
}
