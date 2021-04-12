using HPlusSports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HPlusSports
{
    public static class UrlHelperExtensions
    {
        public static string Product(this System.Web.Mvc.UrlHelper urlhelper, Product product) 
        {
            return Product(urlhelper, product?.SKU);
        }
        
        public static string Product(this System.Web.Mvc.UrlHelper urlhelper, string sku) 
        {
            return urlhelper.Action("Product", "Products", new { id = sku });
        }
    }
}