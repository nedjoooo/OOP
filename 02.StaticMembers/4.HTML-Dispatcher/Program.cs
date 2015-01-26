using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HTML_Dispatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAtribute("id", "page");
            div.AddAtribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div.ToString());

            ElementBuilder li = new ElementBuilder("li");
            Console.WriteLine(li*4);
            Console.WriteLine(div*2);

            string image = HTMLDispatcher.CreateImage("atlantic ocean.jpg", "Ocean", "Atlantic Ocean");
            Console.WriteLine(image);
            string url = HTMLDispatcher.CreateURL("https://softuni.bg/", "Softuni", "Software Univercity");
            Console.WriteLine(url);
            string input = HTMLDispatcher.CreateInput("submit", "Submit", "Login");
            Console.WriteLine(input);
        }
    }
}
