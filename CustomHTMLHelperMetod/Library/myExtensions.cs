using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomHTMLHelperMetod.Library
{
    public static class myExtensions
    {
        public static MvcHtmlString Button(this HtmlHelper helper, string id="", ButtonType type=ButtonType.button, string text="")
        {
            string html = string.Format("<button id='{0}' name='{0}' type='{1}'>{2}</button>", id, type.ToString(), text);
            return MvcHtmlString.Create(html);  //verilen stringi html'e cevirir.
        }
    }

        public enum ButtonType
        {
            button = 0,
            submit = 1,
            reset = 2

        }
    }
