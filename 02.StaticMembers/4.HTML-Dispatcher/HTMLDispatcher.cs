using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HTML_Dispatcher
{
    class HTMLDispatcher
    {
        public static string CreateImage(string source, string alt, string title)
        {
            ElementBuilder image = new ElementBuilder("img");
            image.AddAtribute("src", source);
            image.AddAtribute("alt", alt);
            image.AddAtribute("title", title);
            return image.ToString();
        }

        public static string CreateURL(string href, string title, string text)
        {
            ElementBuilder url = new ElementBuilder("a");
            url.AddAtribute("href", href);
            url.AddAtribute("title", title);
            url.AddContent(text);
            return url.ToString();
        }

        public static string CreateInput(string inputType, string name, string value)
        {
            ElementBuilder input = new ElementBuilder("input");
            input.AddAtribute("type", inputType);
            input.AddAtribute("name", name);
            input.AddAtribute("value", value);
            return input.ToString();
        }
    }
}
