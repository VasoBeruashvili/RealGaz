using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RealGaz.Helpers
{
    public static class NavigationMenuHelper
    {
        public static string IsSelected(this HtmlHelper html, string actions = "", string controllers = "", string cssClass = "selected")
        {
            ViewContext viewContext = html.ViewContext;
            bool isChildAction = viewContext.Controller.ControllerContext.IsChildAction;

            if (isChildAction)
                viewContext = html.ViewContext.ParentActionViewContext;

            RouteValueDictionary routeValues = viewContext.RouteData.Values;
            object _currentId = routeValues["id"];
            string currentId = _currentId == null ? null : routeValues["id"].ToString(); //custom validation for the same actions with different parameters named "id", it can be remove if not need
            string _currentAction = routeValues["action"].ToString();
            string currentAction = currentId == null ? _currentAction : $"{_currentAction}/{currentId}";
            string currentController = routeValues["controller"].ToString();

            if (string.IsNullOrEmpty(actions))
                actions = currentAction;

            if (string.IsNullOrEmpty(controllers))
                controllers = currentController;

            return actions.Split(':').Any(a => a == currentAction.ToLower()) && controllers == currentController.ToLower() ?
                cssClass : string.Empty;
        }
    }
}