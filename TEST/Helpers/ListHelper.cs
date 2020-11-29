using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TEST.Models;

namespace TEST.Helpers
{
        public static class ListHelper
        {
            public static MvcHtmlString CreateList(this HtmlHelper html,IEnumerable<User> items)
            {
                TagBuilder ul = new TagBuilder("ul");
                foreach (var item in items)
                {
                    TagBuilder li = new TagBuilder("li");
                    li.SetInnerText(item.Email);
                    ul.InnerHtml += li.ToString();
                }
                return new MvcHtmlString(ul.ToString());
            }
        }
    }
