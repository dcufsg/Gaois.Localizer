using Microsoft.AspNetCore.Http;

namespace Gaois.Localizer
{
    /// <summary>
    /// Utility methods that make it easier to construct URLs
    /// </summary>
    public static class UrlBuilder
    {
        /// <summary>
        /// Replaces the request path and returns a new URL
        /// </summary>
        /// <param name="request">The HTTP request</param>
        /// <param name="path">The string that will be inserted in place of the current path</param>
        public static string ReplacePath(HttpRequest request, string path)
        {
            return request.Scheme + "://" + request.Host + request.PathBase + path + request.QueryString;
        }
    }
}