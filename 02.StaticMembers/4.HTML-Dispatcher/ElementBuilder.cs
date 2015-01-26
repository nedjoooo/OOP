using System;
using System.Text;
using System.Web;

namespace _4.HTML_Dispatcher
{
    public class ElementBuilder
    {
        private string name;
        private string attributes;
        private string content;

        public ElementBuilder(string name)
        {
            this.Name = name;
        }

        public string Name 
        {
            get { return this.name; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Input cannot be empty!");
                }
                this.name = value;
            }
        }

        public void AddAtribute(string attribute, string value)
        {
            this.attributes += " " + attribute + "=\"" + value +"\"";
        }

        public void AddContent(string content)
        {
            this.content = HttpUtility.HtmlEncode(content);
            //this.content = content;
        }

        public static string operator *(ElementBuilder element, int quantityAttribute)
        {
            string overloadAttribute = "";
            for (int i = 0; i < quantityAttribute; i++)
            {
                overloadAttribute += element.ToString() + "\n";
            }
            return overloadAttribute;
        }

        public override string ToString()
        {
            return "<" + this.name + this.attributes + ">" + HttpUtility.HtmlDecode(this.content) +"</" + this.name + ">";
        }
    }
}
