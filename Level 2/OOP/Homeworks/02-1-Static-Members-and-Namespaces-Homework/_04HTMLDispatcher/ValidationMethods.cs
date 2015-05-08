using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04HTMLDispatcher
{
    class ValidationMethods
    {
        public static void ValidateValue(object value, string parameter)
        {
            if ((value is string) && (string)value == "")
            {
                throw new ArgumentNullException("\"" + parameter + "\"" + " cannot be an empty string!");
            }
            //			if ((value is int) && (int)value <= 0) {
            //				throw new ArgumentOutOfRangeException ("\"" + parameter + "\"" + "cannot be a negative number or zero!");
            //			}
        }
        public static void ValidateHTMLTag(string tag)
        {
           string[] htmlTags = new string[] 
           {
               "!DOCTYPE", "a", "abbr", "acronym", "address", 
               "applet", "area", "article", "aside", "audio", "b", "base", "basefont", 
               "bdi", "bdo", "big", "blockquote", "body", "br", "button", "canvas", 
               "caption", "center", "cite", "code", "col", "colgroup", "datalist", 
               "dd", "del", "details", "dfn", "dialog", "dir", "div", "dl", "dt", "em", 
               "embed", "fieldset", "figcaption", "figure", "font", "footer", "form", 
               "frame", "frameset", "head", "header", "hgroup", "h1", "h6", "hr", "html", 
               "i", "iframe", "img", "input", "ins", "kbd", "keygen", "label", "legend", 
               "li", "link", "main", "map", "mark", "menu", "menuitem", "meta", "meter", 
               "nav", "noframes", "noscript", "object", "ol", "optgroup", "option", "output", 
               "p", "param", "pre", "progress", "q", "rp", "rt", "ruby", "s", "samp", "script", 
               "section", "select", "small", "source", "span", "strike", "strong", "style", 
               "sub", "summary", "sup", "table", "tbody", "td", "textarea", "tfoot", "th", 
               "thead", "time", "title", "tr", "track", "tt", "u", "ul", "var", "video", "wbr"
           };
           if (Array.IndexOf(htmlTags, tag) < 0)
           {
               throw new ArgumentOutOfRangeException(String.Format("\"{0}\" is not a valid HTML tag!", tag));
           }
        }
        public static void ValidateHTMLAttribute(string att)
        {
            string[] htmlAttributes = new string[] 
            {
                "hidden", "high", "href", "hreflang", "http-equiv", "icon", "id", "ismap", 
                "itemprop", "keytype", "kind", "label", "lang", "language", "list", "loop", 
                "low", "manifest", "max", "maxlength", "media", "method", "min", "multiple", 
                "name", "novalidate", "open", "optimum", "pattern", "ping", "placeholder", 
                "poster", "preload", "pubdate", "radiogroup", "readonly", "rel", "required", 
                "reversed", "rows", "rowspan", "sandbox", "spellcheck", "scope", "scoped", 
                "seamless", "selected", "shape", "size", "span", "src", "srcdoc", "srclang", 
                "srcset", "start", "step", "style", "summary", "tabindex", "target", "title", 
                "type", "usemap", "value", "width", "wrap", "border", "buffered", "challenge", 
                "charset", "checked", "cite", "class", "code", "codebase", "color", "cols", 
                "colspan", "content", "contenteditable", "contextmenu", "controls", "coords", 
                "data", "data-*", "datetime", "default", "defer", "dir", "dirname", "disabled", 
                "download", "draggable", "dropzone", "enctype", "for", "form", "formaction", 
                "headers", "height", "accept", "accept-charset", "accesskey", "action", "align", 
                "alt", "async", "autocomplete", "autofocus", "autoplay", "autosave", "bgcolor"
            };
            if (Array.IndexOf(htmlAttributes, att) < 0)
            {
                throw new ArgumentOutOfRangeException(String.Format("\"{0}\" is not a valid HTML attribute!", att));
            }
        }
        public static bool TagIsSingleton(string tag)
        {
            string[] singletonTags = new string[]
            {
                "area", "base", "br", "col", "command", "embed", "hr", "img", "input", 
                "link", "meta", "param", "source"
            };
            if (Array.IndexOf(singletonTags, tag) >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
