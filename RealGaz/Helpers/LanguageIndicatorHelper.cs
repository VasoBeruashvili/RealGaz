using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RealGaz.Helpers
{
    public static class LanguageIndicatorHelper
    {
        public static string SetCurrentLanguageIndicator(this HtmlHelper html, string currentLanguage = "ka-GE")
        {
            return currentLanguage == "ka-GE" ? "GE" : "EN";                 
        }

        public static string HideSelectedLanguage(this HtmlHelper html, string currentLanguage, string sessionLanguage = "ka-GE")
        {
            string result = "display: block";
            if (sessionLanguage == currentLanguage)
                result = "display: none";
            return result;
        }
    }
}