using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04HTMLDispatcher
{
    class ElementBuilder
    {
        private string tagName;
        private List<string> attributes;
        private string content;

        public ElementBuilder(string tagName)
        {
            this.TagName = tagName.ToLower();
        }
        public string TagName 
        {
            private get { return this.tagName;  }
            set
            {
                ValidationMethods.ValidateValue(value, "Tag Name");
                ValidationMethods.ValidateHTMLTag(value);
                this.tagName = value;
            }
        }

        public void AddAttribute(string attribute, string value)
        {
            ValidationMethods.ValidateValue(attribute, "Attribute Name");
            ValidationMethods.ValidateValue(value, "Attribute Value");
            ValidationMethods.ValidateHTMLAttribute(attribute);
            if (this.attributes == null)
            {
               this.attributes = new List<string>();
            }
            this.attributes.Add(" " + attribute + "=\"" + value + "\"");
        }
        public void AddContent(string content)
        {
            if (ValidationMethods.TagIsSingleton(this.TagName))
            {
                throw new InvalidDataException(
                    String.Format("\"{0}\" is a singleton HTML tag and cannot have content!", this.TagName));
            }
            ValidationMethods.ValidateValue(content, "HTML Tag Content");
            this.content = content;

        }
        public override string ToString()
        {
            return String.Format("<{0}{1}>{2}{3}", 
                this.TagName, 
                this.attributes != null ? string.Join("", this.attributes) : null, 
                this.content, 
                ValidationMethods.TagIsSingleton(this.TagName) ? null : @"<\" + this.TagName + ">"
                );
        }
        public static string operator *(ElementBuilder element, int multiplier)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < multiplier; i++)
            {
                str.Append(element);
            }
            return str.ToString();
        }
    }
}
