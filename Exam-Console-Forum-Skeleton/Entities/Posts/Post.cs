using ConsoleForum.Contracts;
using ConsoleForum.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Entities.Posts
{
    class Post : IPost
    {
        private int id;
        private string body;
        private User author;

        public Post(int id, string body, User author)
        {
            this.Id = id;
            this.Body = body;
            this.Author = author;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Body
        {
            get
            {
                return this.body;
            }
            set
            {
                this.body = value;
            }
        }

        public IUser Author
        {
            get
            {
                return this.author;
            }
            set
            {
                this.author = value as User;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string typePost = "";
            if(this.GetType() == typeof(Question))
            {
                typePost = "Question";
            }
            else
            {
                typePost = "Answer";
            }
            output.AppendLine(string.Format("[ {0} ID: {1} ]", typePost, this.Id));
            output.AppendLine(string.Format("Posted by: {0}", this.author.Username));
            return output.ToString();
        }
    }
}
