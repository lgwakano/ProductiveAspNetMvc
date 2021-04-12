using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPlusSports
{
    public static class TempDataExtensions
    {
        private const string SuccessMessageKey = "SuccessMessage";
        public static string SuccessMessage(this TempDataDictionary tempData) 
        {
            return tempData[SuccessMessageKey] as String;
        }
        public static void SuccessMessage(this TempDataDictionary tempData, string successMessage) 
        {
            tempData[SuccessMessageKey] = successMessage;
        }


    }
}