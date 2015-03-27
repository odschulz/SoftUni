using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04HTMLDispatcher
{
    class MainProgram
    {
        public static void Main(string[] args)
        {
            ElementBuilder div1 = new ElementBuilder("div");
            ElementBuilder paragraph1 = new ElementBuilder("p");
            paragraph1.AddContent("Hello");
            div1.AddContent(paragraph1.ToString());
            div1.AddAttribute("id", "page");
            div1.AddAttribute("class", "big");
            Console.WriteLine(div1 * 2);

            Console.WriteLine("--------------------------------------\n");

            ElementBuilder div2 = new ElementBuilder("div");
            div2.AddContent(HTMLDispatcher.CreateImage("Some/Source", "SomeAlt", "SomeTitle") 
                + HTMLDispatcher.CreateInput("text", "someName", "Submit") 
                + HTMLDispatcher.CreateURL("fake.com", "Some Link", "This is a sample URL"));
            Console.WriteLine(div2);
        }
    }
}
