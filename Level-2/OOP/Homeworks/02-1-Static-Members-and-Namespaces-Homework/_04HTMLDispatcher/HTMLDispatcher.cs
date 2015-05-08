using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04HTMLDispatcher
{
    static class HTMLDispatcher
    {
        public static string CreateImage(string imageSource, string alt, string title)
        {
            ElementBuilder imageTag = new ElementBuilder("img");
            imageTag.AddAttribute("src", imageSource);
            imageTag.AddAttribute("alt", alt);
            imageTag.AddAttribute("title", title);
            return imageTag.ToString();
        }
        public static string CreateURL(string url, string title, string text)
        {
            ElementBuilder urlTag = new ElementBuilder("a");
            urlTag.AddAttribute("href", url);
            urlTag.AddAttribute("title", title);
            urlTag.AddContent(text);
            return urlTag.ToString();
        }
        public static string CreateInput(string inputType, string name, string value)
        {
            ElementBuilder inputTag = new ElementBuilder("input");
            inputTag.AddAttribute("type", inputType);
            inputTag.AddAttribute("name", name);
            inputTag.AddAttribute("value", value);
            return inputTag.ToString();
        }
    }
}
