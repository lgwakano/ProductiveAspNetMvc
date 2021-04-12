using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc.Html;
using HPlusSports.Models;

namespace HPlusSports
{
    public static class ProductHelpers
    {
        public static IHtmlString Rating(this System.Web.Mvc.HtmlHelper html, ProductRating rating) 
        {
            return html.Partial("_Rating", rating);
        }
    }
}