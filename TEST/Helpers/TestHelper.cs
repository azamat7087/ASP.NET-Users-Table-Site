using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TEST.Models;

namespace TEST.Helpers
{
    public static class TestHelper
    {
        public static MvcHtmlString CreateTable(this HtmlHelper html, IEnumerable<User> items)
        {
            TagBuilder tr = new TagBuilder("tr");
            foreach (var item in items)
            {
                TagBuilder td = new TagBuilder("td");
                TagBuilder td1 = new TagBuilder("td");
                td.SetInnerText(item.First_Name);
                td1.SetInnerText(item.Email);
                tr.InnerHtml += td.ToString();
                tr.InnerHtml += td1.ToString();
            }
            return new MvcHtmlString(tr.ToString());
        }
    }
}