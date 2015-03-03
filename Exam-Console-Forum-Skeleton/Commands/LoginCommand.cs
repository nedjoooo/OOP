using ConsoleForum.Contracts;
using ConsoleForum.Entities.Users;
using ConsoleForum.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Commands
{
    class LoginCommand : AbstractCommand
    {
        public LoginCommand(IForum forum)
            : base(forum)
        {

        }
        public override void Execute()
        {
            if (this.Forum.CurrentUser != null)
            {
                this.Forum.Output.AppendLine(
                    string.Format(Messages.AlreadyLoggedIn));
                return;
            }

            var users = this.Forum.Users.ToList();
            string username = this.Data[1];
            string password = PasswordUtility.Hash(this.Data[2]);
            var user = users.Single(u => u.Username == username);

            if(user == null || user.Password != password)
            {
                this.Forum.Output.AppendLine(
                    string.Format(Messages.InvalidLoginDetails));
                return;
            }          

            this.Forum.CurrentUser = user;
            this.Forum.Output.AppendLine(
                    string.Format(Messages.LoginSuccess, username));

        }
    }
}
