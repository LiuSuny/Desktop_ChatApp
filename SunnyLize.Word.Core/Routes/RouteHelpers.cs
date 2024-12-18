﻿using static Dna.FrameworkDI;

namespace SunnyLize.Word.Core
{
    /// <summary>
    /// Helper methods for getting and working with web routes
    /// </summary>
    public static class RouteHelpers
    {
        /// <summary>
        /// Converts a relative URL into an absolute URL
        /// </summary>
        /// <param name="relativeUrl">The relative URL</param>
        /// <returns>Returns the absolute URL including the Host URL</returns>
        public static string GetAbsoluteRoute(string relativeUrl)
        {
            // Get the host
            var host = Configuration["SunnyLizeWordServer:HostUrl"];

            // If they are not passing any URL...
            if (string.IsNullOrEmpty(relativeUrl))
                // Return the host
                return host;

            // If the relative URL does not start with /...
            if (!relativeUrl.StartsWith("/"))
                // Add the /
                relativeUrl = $"/{relativeUrl}";

            // Return combined URL
            return Configuration["SunnyLizeWordServer:HostUrl"] + relativeUrl;
        }
    }
}
