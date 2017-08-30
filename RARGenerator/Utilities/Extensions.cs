using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RARGenerator.Utilities
{
    public static class Extensions
    {
        public static string GetNavigationClasses(bool isValid, bool wasStarted, string currentAction, string actionToTest)
        {
            string classes = "";

            if (isValid)
            {
                classes = "complete";
            }

            if (wasStarted && !isValid)
            {
                classes = "incomplete";
            }

            if (currentAction.ToLower() == actionToTest.ToLower())
            {
                classes += " active";
            }

            return classes;
        }
    }
}