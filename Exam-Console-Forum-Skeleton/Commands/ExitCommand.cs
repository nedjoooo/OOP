using ConsoleForum.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Commands
{
    class ExitCommand : AbstractCommand
    {
        public ExitCommand(IForum forum)
            : base(forum)
        {

        }
        public override void Execute()
        {
            this.Forum.HasStarted = false;
        }
    }
}
